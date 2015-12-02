namespace Accomplish.Views
{
    using System.ComponentModel;
    using Accomplish.ViewModels;
    using Microsoft.Practices.ServiceLocation;

    public partial class RibbonView
    {
        public RibbonView() : this(null)
        {
        }

        public RibbonView(IRibbonViewModel ribbonViewModel)
        {
            InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = ribbonViewModel ?? ServiceLocator.Current.GetInstance<IRibbonViewModel>();
            }
        }
    }
}