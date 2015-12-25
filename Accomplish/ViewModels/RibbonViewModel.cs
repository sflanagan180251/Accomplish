namespace Accomplish.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Accomplish.Factories;
    using Accomplish.Model;
    using Accomplish.Model.Events;
    using Accomplish.Views;
    using Prism.Events;
    using Prism.Mvvm;

    public sealed class RibbonViewModel : BindableBase, IRibbonViewModel
    {
        private readonly IRibbonTabViewFactory ribbonTabViewFactory;

        public RibbonViewModel(IEventAggregator eventAggregator, IRibbonTabViewFactory ribbonTabViewFactory)
        {
            this.ribbonTabViewFactory = ribbonTabViewFactory;

            RibbonTabs = new ObservableCollection<RibbonTabView>();

            eventAggregator.GetEvent<GoalCollectionCreatedEvent>()
                .Subscribe(AddRibbonTab);

            eventAggregator.GetEvent<CloseGoalCollectionEvent>()
                .Subscribe(RemoveRibbonTab);
        }

        public ObservableCollection<RibbonTabView> RibbonTabs { get; set; }

        private void AddRibbonTab(IGoalCollection goalCollection)
        {
            RibbonTabs.Add(ribbonTabViewFactory.Create(goalCollection));
        }

        private void RemoveRibbonTab(IGoalCollection goalCollection)
        {
            var ribbonTabToRemove =
                (from ribbonTab in RibbonTabs
                where ribbonTab.DataContext is IRibbonTabViewModel
                where ((IRibbonTabViewModel)ribbonTab.DataContext).GoalCollection == goalCollection
                select ribbonTab)
                .FirstOrDefault();

            if (ribbonTabToRemove != null)
            {
               RibbonTabs.Remove(ribbonTabToRemove);
            }
        }
    }
}