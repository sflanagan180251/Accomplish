namespace Accomplish.ViewModels
{
    using System.Windows.Input;

    public interface IRibbonApplicationMenuViewModel
    {
        ICommand NewCommand
        {
            get;
        }

        ICommand OpenCommand
        {
            get;
        }

        ICommand SaveCommand
        {
            get;
        }

        ICommand ExitCommand
        {
            get;
        }
    }
}