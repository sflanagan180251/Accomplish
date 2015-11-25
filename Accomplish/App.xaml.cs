using System.Windows;

namespace Accomplish
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Bootstrapper bootStrapper = new Bootstrapper();
            bootStrapper.Run();
        }
    }
}
