namespace Accomplish.Views
{
    using System.ComponentModel;
    using Accomplish.ViewModels;
    using Microsoft.Practices.ServiceLocation;

    public partial class ContentView
    {
        public ContentView()
            : this(null)
        {
        }

        public ContentView(IContentViewModel contentViewModel)
        {
            InitializeComponent();

            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = contentViewModel ?? ServiceLocator.Current.GetInstance<IContentViewModel>();
            }
        }
    }
}