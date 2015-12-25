namespace Accomplish.Model.Events
{
    using Prism.Events;

    public class ApplicationEvent : PubSubEvent<ApplicationEvent.EventType>
    {
        public enum EventType
        {
            New,
            Open,
            Save,
            Close,
            Exit
        }
    }
}