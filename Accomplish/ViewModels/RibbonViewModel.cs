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
        public RibbonViewModel(IEventAggregator eventAggregator)
        {
            AddCommand =
                new DelegateCommand(
                    () => eventAggregator.GetEvent<RibbonEvent>().Publish(RibbonEvent.EventType.Add),
                    () => true);

            CreateCommand = new DelegateCommand(() => { }, () => false);

            OpenCommand = new DelegateCommand(() => { }, () => false);

            SaveCommand = new DelegateCommand(() => { }, () => false);
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