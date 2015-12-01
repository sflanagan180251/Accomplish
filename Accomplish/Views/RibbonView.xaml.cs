using System.Windows.Controls;
using Accomplish.ViewModels;
using Prism.Events;

namespace Accomplish.Views
{
    /// <summary>
    ///     Interaction logic for RibbonView.xaml
    /// </summary>
    public partial class RibbonView : UserControl
    {
        public RibbonView(RibbonViewModel ribbonViewModel)
        {
            InitializeComponent();
            DataContext = ribbonViewModel;
        }
    }
}