using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Prism.Commands;
using System.ComponentModel;
using Microsoft.Practices.Prism.ViewModel;

namespace SentenceLearner
{
    class WordButtonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
   
        private Action<WordButtonViewModel> _action;

        public WordButtonViewModel(Action<WordButtonViewModel> action)
        {
            _action = action;
        }

        public string Word { get; set; }

        private DelegateCommand _Selected;

        public DelegateCommand Selected
        {
            get
            {
                return _Selected = _Selected ??
                    new DelegateCommand(selected);
            }
        }

        private bool _State;
        public bool State
        {
            get { return _State; }
            set
            {
                if (value != _State)
                {
                    _State = value;
                    var handler = this.PropertyChanged;
                    if( handler != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("State"));
                    }
                }
                
            }
        }

        private void selected()
        {
            State = false;
            _action(this);
        }
    }
}
