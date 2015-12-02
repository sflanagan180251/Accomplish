namespace Accomplish.Model
{
    using Prism.Events;

    internal class RibbonEvent : PubSubEvent<RibbonEvent.EventType>
    {
        public enum EventType
        {
            Create,
            Open,
            Add,
            Save
        }
    }
}