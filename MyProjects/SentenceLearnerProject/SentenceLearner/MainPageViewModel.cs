using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Microsoft.Practices.Prism.Commands;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace SentenceLearner
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private SentenceLearner model = new SentenceLearner();
        private Stack<WordButtonViewModel> commandStack = new Stack<WordButtonViewModel>();

        public MainPageViewModel()
        {
            JapaneseSentense = "日本語の文章です";
            EnglishSentense = "This area is for English Sentense";
            Words = new ObservableCollection<WordButtonViewModel>();
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

        private string _SentenceNumber;
        public string SentenceNumber
        {
            get { return _SentenceNumber; }
            set
            {
                if(value != _SentenceNumber)
                {
                    _SentenceNumber = value;
                    var handler = this.PropertyChanged;
                    if(handler != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("SentenceNumber"));
                    }
                }
            }
        }

        private string _Progress;
        public string Progress
        {
            get { return _Progress; }
            set
            {
                if(value != _Progress)
                {
                    _Progress = (int.Parse(value) / (model.MaxIndex / 100)).ToString();
                    var handler = this.PropertyChanged;
                    if(handler != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Progress"));
                    }
                }
            }
        }

        private string _Result;
        public string Result
        {
            get { return _Result; }
            set
            {
                if(value != _Result)
                {
                    _Result = value;
                    var handler = this.PropertyChanged;
                    if(handler != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("Result"));
                    }
                }
            }
        }

        private DelegateCommand _GiveUpCommand;
        public DelegateCommand GiveUpCommand
        {
            get
            {
                return _GiveUpCommand = _GiveUpCommand ??
                    new DelegateCommand(giveUpCommand);
            }
        }

        private void giveUpCommand()
        {
            EnglishSentense = model.GetEnglish();
        }

        private DelegateCommand _BackCommand;
        public DelegateCommand BackCommand
        {
            get
            {
                return _BackCommand = _BackCommand ??
                    new DelegateCommand(backCommand);
            }
        }

        private void backCommand()
        {
            JapaneseSentense = model.GetPriviousJapanese();
            initText();
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

        private DelegateCommand _CancelCommand;
        public DelegateCommand CancelCommand
        {
            get
            {
                return _CancelCommand = _CancelCommand ??
                    new DelegateCommand(cancelCommand);
            }
        }

        private void cancelCommand()
        {
            if(commandStack.Count != 0)
            {
                var wordButtonViewModel = commandStack.Pop();
                wordButtonViewModel.State = true;

                EnglishSentense = TrimEnglishSentence(wordButtonViewModel.Word);
             }
        }

        private string TrimEnglishSentence(string word)
        {
            return EnglishSentense.Remove(EnglishSentense.Length - word.Length - 1);

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
            initText();
        }

        private void initText()
        {
            Result = "";
            SentenceNumber = model.GetCurrentIndex().ToString();
            Progress = SentenceNumber;
            Words.Clear();
            commandStack.Clear();

            model.GetWords((word) =>
            {
                Words.Add(new WordButtonViewModel(myAction) { Word = word, State = true });
            });

            EnglishSentense = "";
        }

        //private ObservableCollection<Item> _Words;
        public ObservableCollection<WordButtonViewModel> Words { get; set; }

        private void myAction(WordButtonViewModel word)
        {
            var sb = AppendWord(word.Word);

            commandStack.Push(word);

            if (model.CheckSentence(sb.ToString()))
            {
                //sb.Append("  =>");
                //sb.Append(" Collect !!");
                Result = "Collect !!";
                commandStack.Clear();
            }

            EnglishSentense = sb.ToString();
        }

        private StringBuilder AppendWord(string word)
        {
            var sb = new StringBuilder();
            sb.Append(EnglishSentense);
            sb.Append(" ");
            sb.Append(word);

            return sb;
        }
    }
}
