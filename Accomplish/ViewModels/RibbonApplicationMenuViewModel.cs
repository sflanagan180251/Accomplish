namespace Accomplish.ViewModels
{
    using System.Windows.Input;
    using Accomplish.Model;
    using Accomplish.Model.Events;
    using Prism.Commands;
    using Prism.Events;
    using Prism.Mvvm;

    public sealed class RibbonApplicationMenuViewModel : BindableBase, IRibbonApplicationMenuViewModel
    {
        public RibbonApplicationMenuViewModel(IEventAggregator eventAggregator, IGoalListFactory goalListFactory)
        {
            NewCommand = new DelegateCommand(() => eventAggregator.GetEvent<NewGoalListEvent>().Publish(goalListFactory.Create()),
                () => true);

            OpenCommand = new DelegateCommand(() =>
            {
            },
                () => false);

            SaveCommand = new DelegateCommand(() =>
            {
            },
                () => false);

            ExitCommand = new DelegateCommand(() => eventAggregator.GetEvent<ApplicationEvent>().Publish(ApplicationEvent.EventType.Exit),
                () => true);
        }

        public ICommand ExitCommand { get; private set; }

        public ICommand NewCommand { get; private set; }

        public ICommand OpenCommand { get; private set; }

        public ICommand SaveCommand { get; private set; }
    }
}