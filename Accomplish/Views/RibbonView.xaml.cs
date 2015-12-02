using System;
using System.ComponentModel;
using System.Windows.Controls;
using Accomplish.ViewModels;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;

namespace Accomplish.Views
{
    /// <summary>
    ///     Interaction logic for RibbonView.xaml
    /// </summary>
    public partial class RibbonView : UserControl, IRibbonView
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