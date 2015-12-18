namespace Accomplish.Factories
{
    using Accomplish.Model;
    using Accomplish.Views;

    public interface IRibbonTabViewFactory
    {
        RibbonTabView Create(IGoalList goalList);
    }
}