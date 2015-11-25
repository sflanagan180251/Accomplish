using System.ComponentModel;

namespace Accomplish.ViewModels
{
    public interface IGoalViewModel : INotifyPropertyChanged
    {
        string Title
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }
    }
}