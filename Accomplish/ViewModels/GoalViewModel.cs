using Accomplish.Model;
using Microsoft.Practices.Prism.Mvvm;

namespace Accomplish.ViewModels
{
    internal sealed class GoalViewModel : BindableBase, IGoalViewModel
    {
        private readonly IGoal goal;

        internal GoalViewModel(IGoal goal)
        {
            this.goal = goal;
        }

        public GoalViewModel(IGoalFactory goalFactory)
        {
            goal = goalFactory.Create();
        }

        public GoalViewModel()
        {
            
        }

        public string Description
        {
            get
            {
                return goal.Description;
            }
            set
            {
                if (goal.Description != value)
                {
                    goal.Description = value;
                    OnPropertyChanged(() => Description);
                }
            }
        }

        public string Title
        {
            get
            {
                return goal.Title;
            }
            set
            {
                if (goal.Title != value)
                {
                    goal.Title = value;
                    OnPropertyChanged(() => Title);
                }
            }
        }
    }
}