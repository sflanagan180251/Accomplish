namespace Accomplish.ViewModels
{
    using Accomplish.Model.Enum;
    using Prism.Events;
    using Prism.Mvvm;

    internal sealed class ContentViewModel : BindableBase, IContentViewModel
    {
        private string contentText;

        public ContentViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<RibbonEvent>().Subscribe(eventType => ContentText = eventType.ToString());
        }

        public string ContentText
        {
            get
            {
                return contentText;
            }
            set
            {
                SetProperty(ref contentText, value);
            }
        }
    }
}