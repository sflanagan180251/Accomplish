using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Accomplish.Model
{
    internal sealed class CommandHandler : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public CommandHandler(Action<object> execute)
        {
            this.execute = execute;
            canExecute = parameter => true;
        }

        public CommandHandler(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
