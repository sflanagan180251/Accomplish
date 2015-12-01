using System.Windows.Input;

namespace Accomplish.ViewModels
{
    public interface IRibbonViewModel
    {
        ICommand CreateCommand
        {
            get;
        }

        ICommand OpenCommand
        {
            get;
        }

        ICommand AddCommand
        {
            get;
        }

        ICommand SaveCommand
        {
            get;
        }
    }
}