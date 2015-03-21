using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceLearner
{
    class TextSet
    {
        public string Japanese;
        public string English;
        public int TrainningCount;
        public string Explanation;
    }

    class SentenceLearner
    {
        private int _SentenseIndex;

        //private TextSet[] model = 
        //{
        //    new TextSet{Japanese="この池は、冬には凍る", English="This pond freezes in the winter."},
        //    new TextSet{Japanese="その２人の子は似た顔をしている", English="The two children look alike."},
        //    new TextSet{Japanese="水中に住んでいる虫は多い", English="Many insects live in water."}            
        //};
        List<TextSet> model = new List<TextSet>();

        private int maxIndex
        {
            get { return model.Count() - 1; }
        }

        public int MaxIndex
        {
            get { return model.Count(); }
        }

        public SentenceLearner()
        {
            _SentenseIndex = -1;

            var storage = new MyStorage();

            storage.Load(model);

            //maxIndex = model.Count();
        }

        public string GetJapanese()
        {
            return model[GetIndex()].Japanese;
        }

        public string GetPriviousJapanese()
        {
            return model[GetPriviousIndex()].Japanese;
        }

        public string GetEnglish()
        {
            return model[_SentenseIndex].English;
        }

        private int GetIndex()
        {
            _SentenseIndex++;

            if(_SentenseIndex >= maxIndex)
            {
                _SentenseIndex = 0;
            }

            return _SentenseIndex;
        }

        private int GetPriviousIndex()
        {
            _SentenseIndex--;

            if(_SentenseIndex < 0)
            {
                _SentenseIndex = maxIndex;
            }

            return _SentenseIndex;
        }

        public int GetCurrentIndex()
        {
            return _SentenseIndex + 1;
        }

        public void GetWords(Action<string> action)
        {
            var words = model[_SentenseIndex].English.Split(new char[] { ' ' });

            var ramdomWords = RandomWords(words);
            foreach(var word in ramdomWords)
            {
                action(word);
            }
        }

        public List<string> RandomWords(string[] words)
        {
            var random = new Random();
            var dic = new Dictionary<int, string>();
 
            foreach(var word in words)
            {
                dic.Add(random.Next(), word);
            }
            
            var randomWords = from n in dic
                              orderby n.Key
                              select n;

            var wordList = new List<string>();
            foreach(var randomWord in randomWords)
            {
                wordList.Add(randomWord.Value);
            }

            return wordList;
        }

        public bool CheckSentence(string actual)
        {
            var result = false;

            if(model[_SentenseIndex].English == actual.TrimStart(' '))
            {
                result = true;
            }

            return result;
        }

    }
}
