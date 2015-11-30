using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace Accomplish.ViewModels
{
    internal sealed class RibbonViewModel : BindableBase
    {
        public ICommand CreateCommand
        {
            get;
            private set;
        }

        public RibbonViewModel()
        {
            //CreateCommand = new DelegateCommand();
        }
    }
}
