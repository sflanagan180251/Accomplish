namespace Accomplish.Factories
{
    using Accomplish.Model;
    using Accomplish.ViewModels;

    public interface IRibbonTabViewModelFactory
    {
        IRibbonTabViewModel Create(IGoalCollection goalCollection);
    }
}