using Accomplish.Model;
using Microsoft.Practices.Prism.Mvvm;

namespace Accomplish.ViewModels
{
    internal sealed class GoalViewModel : BindableBase, IGoalViewModel
    {
        private string description;
        private string title;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                SetProperty(ref description, value);
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                SetProperty(ref title, value);
            }
        }
    }
}