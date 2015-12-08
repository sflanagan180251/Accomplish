namespace Accomplish.ViewModels
{
    using System.Collections.Generic;
    using System.Windows.Input;
    using Accomplish.Model;
    using Prism.Commands;
    using Prism.Events;
    using Prism.Mvvm;

    public sealed class RibbonViewModel : BindableBase, IRibbonViewModel
    {
        private IEnumerable<KeyValuePair<string, ICommand>> commands;

        public RibbonViewModel(IEventAggregator eventAggregator)
        {
            var tempCommands = new List<KeyValuePair<string, ICommand>>();

            AddCommand =
                new DelegateCommand(
                    () => eventAggregator.GetEvent<RibbonEvent>().Publish(RibbonEvent.EventType.Add),
                    () => true);

            CreateCommand = new DelegateCommand(() => { }, () => false);

            OpenCommand = new DelegateCommand(() => { }, () => false);

            SaveCommand = new DelegateCommand(() => { }, () => false);

            tempCommands.Add(new KeyValuePair<string, ICommand>("Add", AddCommand));
            tempCommands.Add(new KeyValuePair<string, ICommand>("Create", CreateCommand));
            tempCommands.Add(new KeyValuePair<string, ICommand>("Open", OpenCommand));
            tempCommands.Add(new KeyValuePair<string, ICommand>("Save", SaveCommand));

            Commands = tempCommands;
        }

        public IEnumerable<KeyValuePair<string, ICommand>> Commands
        {
            get
            {
                return commands;
            }

            private set
            {
                SetProperty(ref commands, value);
            }
        }

        public ICommand AddCommand
        {
            get;
            private set;
        }

        public ICommand CreateCommand
        {
            get;
            private set;
        }

        public ICommand OpenCommand
        {
            get;
            private set;
        }

        public ICommand SaveCommand
        {
            get;
            private set;
        }
    }
}