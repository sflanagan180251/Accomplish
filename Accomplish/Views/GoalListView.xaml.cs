namespace Accomplish.Views
{
    using System.ComponentModel;
    using System.Windows.Controls;
    using Accomplish.ViewModels;
    using Microsoft.Practices.ServiceLocation;

    public partial class GoalListView : UserControl
    {
        public GoalListView()
            : this(null)
        {
        }

        internal GoalListView(IGoalListViewModel goalListViewModel)
        {
            InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = goalListViewModel ?? ServiceLocator.Current.GetInstance<IGoalListViewModel>();
            }
        }
    }
}