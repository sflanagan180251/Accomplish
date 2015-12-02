namespace Accomplish.ViewModels
{
    using System.Windows.Input;

    public interface IRibbonViewModel
    {
        ICommand AddCommand
        {
            get;
        }

        ICommand CreateCommand
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
    }
}