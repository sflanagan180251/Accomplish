namespace Accomplish
{
    using System.Windows;
    using Accomplish.ViewModels;
    using Accomplish.Views;
    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;
    using Prism.Unity;

    internal sealed class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<IRibbonViewModel, RibbonViewModel>();
            Container.RegisterType<RibbonView>();
            Container.RegisterType<IContentViewModel, ContentViewModel>();
            Container.RegisterType<ContentView>();
            Container.RegisterType<Shell>();
        }
    }
}