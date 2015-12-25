namespace Accomplish.ViewModels
{
    using System.Linq;
    using System.Windows.Input;
    using Accomplish.Factories;
    using Accomplish.Model;
    using Accomplish.Model.Events;
    using Prism.Commands;
    using Prism.Events;
    using Prism.Mvvm;

    public sealed class RibbonTabViewModel : BindableBase, IRibbonTabViewModel
    {
        public RibbonTabViewModel(IEventAggregator eventAggregator, IGoalCollection goalCollection, IAddGoalEventArgsFactory addGoalEventArgsFactory)
        {
            this.GoalCollection = goalCollection;

            AddCommand =
                new DelegateCommand(
                    () => eventAggregator.GetEvent<AddGoalEvent>()
                              .Publish(addGoalEventArgsFactory.Create(GoalCollection)),
                    () => true);

            CloseCommand =
                new DelegateCommand(
                    () => eventAggregator.GetEvent<CloseGoalCollectionEvent>()
                              .Publish(GoalCollection),
                    () => true);
        }

        public ICommand AddCommand { get; }

        public ICommand CloseCommand { get; }

        public IGoalCollection GoalCollection { get; }
    }
}