namespace Accomplish
{
    using System.Windows;
    using Accomplish.Model;

    internal sealed class ApplicationWrapper : IApplication
    {
        public void Shutdown()
        {
            Application.Current.Shutdown();
        }
    }
}