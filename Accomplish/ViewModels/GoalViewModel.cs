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

        public GoalViewModel()
        {
            goal = new Goal();
        }

        public string Description
        {
            get
            {
                return goal.Description;
            }

            set
            {
                goal.Description = value;
                OnPropertyChanged(() => Description);
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
                goal.Title = value;
                OnPropertyChanged(() => Title);
            }
        }
    }
}