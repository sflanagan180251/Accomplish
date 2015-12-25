namespace Accomplish.Factories
{
    using Accomplish.Model;
    using Accomplish.ViewModels;
    using Prism.Events;

    internal sealed class RibbonTabViewModelFactory : IRibbonTabViewModelFactory
    {
        private readonly IEventAggregator eventAggregator;

        public RibbonTabViewModelFactory(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public IRibbonTabViewModel Create(IGoalCollection goalCollection)
        {
            return new RibbonTabViewModel(eventAggregator, goalCollection);
        }
    }
}