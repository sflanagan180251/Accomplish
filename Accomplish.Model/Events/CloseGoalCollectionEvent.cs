namespace Accomplish.Model.Events
{
    using Prism.Events;

    public sealed class CloseGoalCollectionEvent : PubSubEvent<IGoalCollection>
    {
    }
}