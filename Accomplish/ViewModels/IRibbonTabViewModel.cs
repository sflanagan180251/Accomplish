namespace Accomplish.ViewModels
{
    using System.Windows.Input;
    using Accomplish.Model;

    public interface IRibbonTabViewModel
    {
        IGoalList GoalList
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