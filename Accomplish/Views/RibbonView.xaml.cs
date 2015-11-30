using System.Windows.Controls;
using Accomplish.ViewModels;

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
            DataContext = new RibbonViewModel();
        }
    }
}