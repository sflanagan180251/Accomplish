namespace Accomplish
{
    using System.Windows;
    using Accomplish.Model;
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

            Container.RegisterType<IGuidFactory, GuidFactory>();
            Container.RegisterType<IGoalFactory, GoalFactory>();
            Container.RegisterType<IRibbonViewModel, RibbonViewModel>();
            Container.RegisterType<RibbonView>();
            Container.RegisterType<IContentViewModel, ContentViewModel>();
            Container.RegisterType<ContentView>();
            Container.RegisterType<IGoalListViewModel, GoalListViewModel>();
            Container.RegisterType<GoalListView>();
            Container.RegisterType<Shell>();
        }
    }
}