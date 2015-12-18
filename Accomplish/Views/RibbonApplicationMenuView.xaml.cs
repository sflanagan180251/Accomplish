namespace Accomplish.Views
{
    using System.ComponentModel;
    using System.Windows.Controls;
    using System.Windows.Controls.Ribbon;
    using Accomplish.ViewModels;
    using Microsoft.Practices.ServiceLocation;

    public partial class RibbonApplicationMenuView : RibbonApplicationMenu
    {
        public RibbonApplicationMenuView() : this(null)
        {
        }

        internal RibbonApplicationMenuView(IRibbonApplicationMenuViewModel ribbonApplicationMenuViewModel)
        {
            InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = ribbonApplicationMenuViewModel
                              ?? ServiceLocator.Current.GetInstance<IRibbonApplicationMenuViewModel>();
            }
        }
    }
}