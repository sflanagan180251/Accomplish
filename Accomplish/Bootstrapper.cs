namespace Accomplish
{
    using System.Windows;
    using Accomplish.Factories;
    using Accomplish.Model;
    using Accomplish.Model.Services;
    using Accomplish.ViewModels;
    using Accomplish.Views;
    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;
    using Prism.Events;
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

            Container.RegisterType<IApplication, ApplicationWrapper>();
            Container.RegisterType<IGuidFactory, GuidFactory>();
            Container.RegisterType<IGoalFactory, GoalFactory>();
            Container.RegisterType<IGoalListFactory, GoalListFactory>();
            Container.RegisterType<IGoalCollectionFactory, GoalCollectionFactory>();

            Container.RegisterType<IRibbonTabViewFactory, RibbonTabViewFactory>();
            Container.RegisterType<IRibbonTabViewModelFactory, RibbonTabViewModelFactory>();
            Container.RegisterType<IRibbonApplicationMenuViewModel, RibbonApplicationMenuViewModel>();
            Container.RegisterType<RibbonApplicationMenuView>();
            Container.RegisterType<IRibbonTabViewModel, RibbonTabViewModel>();
            Container.RegisterType<RibbonTabView>();
            Container.RegisterType<IRibbonViewModel, RibbonViewModel>();
            Container.RegisterType<RibbonView>();
            Container.RegisterType<IContentViewModel, ContentViewModel>();
            Container.RegisterType<ContentView>();
            Container.RegisterType<IGoalListViewModel, GoalListViewModel>();
            Container.RegisterType<GoalListView>();
            Container.RegisterType<Shell>();

            // services
            Container.RegisterType<IGoalCollectionService, GoalCollectionService>(new ContainerControlledLifetimeManager());

            // force resolution so they are created
            Container.Resolve<IGoalCollectionService>();
        }
    }
}