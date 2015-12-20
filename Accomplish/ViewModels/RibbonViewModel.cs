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

            eventAggregator.GetEvent<NewGoalListEvent>()
                .Subscribe(AddRibbonTab);

            eventAggregator.GetEvent<CloseGoalListEvent>()
                .Subscribe(RemoveRibbonTab);
        }

        public ObservableCollection<RibbonTabView> RibbonTabs { get; set; }

        private void AddRibbonTab(IGoalList goalList)
        {
            RibbonTabs.Add(ribbonTabViewFactory.Create(goalList));
        }

        private void RemoveRibbonTab(IGoalList goalList)
        {
            var ribbonTabToRemove = RibbonTabs.FirstOrDefault(ribbonTab => ribbonTab.Uid == goalList.Id.ToString());

            if (ribbonTabToRemove != null)
            {
               RibbonTabs.Remove(ribbonTabToRemove);
            }
        }
    }
}