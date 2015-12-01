using Prism.Events;

namespace Accomplish.Model
{
    internal sealed class RibbonEvent : PubSubEvent<RibbonEvent.Event>
    {
        public enum Event
        {
            Create,
            Open,
            Add,
            Save
        }
    }
}