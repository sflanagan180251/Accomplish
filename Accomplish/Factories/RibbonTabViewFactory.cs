namespace Accomplish.Factories
{
    using Accomplish.Model;
    using Accomplish.Views;

    public class RibbonTabViewFactory : IRibbonTabViewFactory
    {
        private readonly IRibbonTabViewModelFactory ribbonTabViewModelFactory;

        public RibbonTabViewFactory(IRibbonTabViewModelFactory ribbonTabViewModelFactory)
        {
            this.ribbonTabViewModelFactory = ribbonTabViewModelFactory;
        }

        public RibbonTabView Create(IGoalList goalList)
        {
            return new RibbonTabView(ribbonTabViewModelFactory.Create(goalList));
        }
    }
}