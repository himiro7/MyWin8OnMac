using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Prism.Commands;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace SentenceLearner
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private SentenceLearner model = new SentenceLearner();

        public MainPageViewModel()
        {
            JapaneseSentense = "日本語の文章です";
            EnglishSentense = "This area is for English Sentense";
            Words = new ObservableCollection<Item>();
        }

        private string _JapaneseSentense;
        public string JapaneseSentense
        {
            get { return _JapaneseSentense; }
            set
            {
                if(value != _JapaneseSentense)
                {
                    _JapaneseSentense = value;
                    var handler = this.PropertyChanged;
                    if( handler != null )
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("JapaneseSentense"));
                    }
                }
            }
        }

        private string _EnglishSentense;
        public string EnglishSentense
        {
            get { return _EnglishSentense; }
            set
            {
                if (value != _EnglishSentense)
                {
                    _EnglishSentense = value;
                    var handler = this.PropertyChanged;
                    if (handler != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("EnglishSentense"));
                    }
                }
            }
        }

        private DelegateCommand _OkCommand;
        public DelegateCommand OkCommand
        {
            get
            {
                return _OkCommand = _OkCommand ??
                    new DelegateCommand(okCommand);
            }
        }


        private void okCommand()
        {

        }

        private DelegateCommand _NextCommand;
        public DelegateCommand NextCommand
        {
            get
            {
                return _NextCommand = _NextCommand ??
                    new DelegateCommand(nextCommand);
            }
        }

        private void nextCommand()
        {
            JapaneseSentense = model.GetJapanese();
            Words.Clear();
            model.GetWords((word) =>
                {
                    Words.Add(new Item(myAction) { Word = word });
                });

            EnglishSentense = "";
        }

        //private ObservableCollection<Item> _Words;
        public ObservableCollection<Item> Words { get; set; }

        private void myAction(string word)
        {
            var sb = new StringBuilder();
            sb.Append(EnglishSentense);
            sb.Append(" ");
            sb.Append(word);

            EnglishSentense = sb.ToString();
        }
    }
}
