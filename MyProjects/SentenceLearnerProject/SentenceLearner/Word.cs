using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Prism.Commands;

namespace SentenceLearner
{
    class Item
    {
        private Action<string> _action;

        public Item(Action<string> action)
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

        private void selected()
        {
            _action(Word);
        }
    }
}
