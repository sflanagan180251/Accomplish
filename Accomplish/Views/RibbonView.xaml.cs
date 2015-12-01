using System.Windows.Controls;
using Accomplish.ViewModels;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;

namespace Accomplish.Views
{
    /// <summary>
    ///     Interaction logic for RibbonView.xaml
    /// </summary>
    public partial class RibbonView : UserControl
    {
        public RibbonView()
        {
            InitializeComponent();
            DataContext = ServiceLocator.Current.GetInstance<IRibbonViewModel>();
        }
    }
}