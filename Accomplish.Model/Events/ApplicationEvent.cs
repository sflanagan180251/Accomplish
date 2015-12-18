namespace Accomplish.Model.Events
{
    using Prism.Events;
    public sealed class ApplicationEvent : PubSubEvent<ApplicationEvent.EventType>
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