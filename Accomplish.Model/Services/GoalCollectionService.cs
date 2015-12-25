namespace Accomplish.Model.Services
{
    using Accomplish.Model.Events;
    using Prism.Events;

    public sealed class GoalCollectionService : IGoalCollectionService
    {
        public GoalCollectionService(IEventAggregator eventAggregator, IGoalCollectionFactory goalCollectionFactory)
        {
            eventAggregator.GetEvent<NewGoalCollectionEvent>().Subscribe(obj => eventAggregator.GetEvent<GoalCollectionCreatedEvent>().Publish(goalCollectionFactory.Create()), ThreadOption.PublisherThread, keepSubscriberReferenceAlive: true);
        }
    }
}