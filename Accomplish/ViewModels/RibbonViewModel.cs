namespace Accomplish.ViewModels
{
    using System.Windows.Input;
    using Accomplish.Model;
    using Prism.Commands;
    using Prism.Events;
    using Prism.Mvvm;

    public sealed class RibbonViewModel : BindableBase, IRibbonViewModel
    {
        public RibbonViewModel(IEventAggregator eventAggregator)
        {
            CreateCommand = new DelegateCommand(() => { }, () => false);

            OpenCommand = new DelegateCommand(() => { }, () => false);

            AddCommand =
                new DelegateCommand(
                    () => eventAggregator.GetEvent<RibbonEvent>().Publish(RibbonEvent.EventType.Add), 
                    () => true);

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