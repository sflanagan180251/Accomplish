namespace Accomplish.Model.Enum
{
    using Prism.Events;

    public class RibbonEvent : PubSubEvent<RibbonEvent.EventType>
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