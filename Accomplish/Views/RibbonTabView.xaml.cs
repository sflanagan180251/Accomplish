namespace Accomplish.Views
{
    using System.ComponentModel;
    using System.Windows.Controls;
    using System.Windows.Controls.Ribbon;
    using Accomplish.ViewModels;
    using Microsoft.Practices.ServiceLocation;

    public partial class RibbonTabView : RibbonTab
    {
        public RibbonTabView() : this(null)
        {
        }

        internal RibbonTabView(IRibbonTabViewModel ribbonTabViewModel)
        {
            InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = ribbonTabViewModel ?? ServiceLocator.Current.GetInstance<IRibbonTabViewModel>();
            }
        }
    }
}