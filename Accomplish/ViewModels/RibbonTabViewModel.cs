namespace Accomplish.ViewModels
{
    using System.Windows.Input;
    using Accomplish.Model;
    using Accomplish.Model.Events;
    using Prism.Commands;
    using Prism.Events;
    using Prism.Mvvm;

    public sealed class RibbonTabViewModel : BindableBase, IRibbonTabViewModel
    {
        public RibbonTabViewModel(IEventAggregator eventAggregator, IGoalList goalList)
        {
            this.GoalList = goalList;

            AddCommand =
                new DelegateCommand(
                    () => eventAggregator.GetEvent<AddGoalEvent>()
                              .Publish(goalList),
                    () => true);

            CloseCommand =
                new DelegateCommand(
                    () => eventAggregator.GetEvent<CloseGoalListEvent>()
                              .Publish(goalList),
                    () => true);
        }

        public ICommand AddCommand { get; }

        public ICommand CloseCommand { get; }

        public IGoalList GoalList { get; }
    }
}