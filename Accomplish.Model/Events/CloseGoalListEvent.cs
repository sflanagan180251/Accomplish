namespace Accomplish.Model.Events
{
    using Prism.Events;

    public sealed class CloseGoalListEvent : PubSubEvent<IGoalList>
    {
    }
}