namespace Accomplish.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Accomplish.Model;

    internal interface IGoalListViewModel
    {
        ObservableCollection<IGoal> Goals
        {
            get;
        }
    }
}