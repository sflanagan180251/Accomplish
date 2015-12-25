namespace Accomplish.ViewModels
{
    using System.Windows.Input;
    using Accomplish.Model;

    public interface IRibbonTabViewModel
    {
        IGoalCollection GoalCollection
        {
            get;
        }

        ICommand AddCommand
        {
            get;
        }

        ICommand CloseCommand
        {
            get;
        }
    }
}