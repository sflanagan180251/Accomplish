namespace Accomplish.Factories
{
    using Accomplish.Model;
    using Accomplish.ViewModels;
    using Prism.Events;

    internal sealed class RibbonTabViewModelFactory : IRibbonTabViewModelFactory
    {
        private readonly IEventAggregator eventAggregator;

        private readonly IAddGoalEventArgsFactory addGoalEventArgsFactory;

        public RibbonTabViewModelFactory(IEventAggregator eventAggregator, IAddGoalEventArgsFactory addGoalEventArgsFactory)
        {
            this.eventAggregator = eventAggregator;
            this.addGoalEventArgsFactory = addGoalEventArgsFactory;
        }

        public IRibbonTabViewModel Create(IGoalCollection goalCollection)
        {
            return new RibbonTabViewModel(eventAggregator, goalCollection, addGoalEventArgsFactory);
        }
    }
}