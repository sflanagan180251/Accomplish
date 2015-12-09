namespace Accomplish.ViewModels
{
    using System.Windows.Input;

    internal interface IRibbonViewModel
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