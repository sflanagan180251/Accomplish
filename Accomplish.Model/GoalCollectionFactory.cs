namespace Accomplish.Model
{
    using Accomplish.Model.Internal;

    public sealed class GoalCollectionFactory : IGoalCollectionFactory
    {
        private readonly IGuidFactory guidFactory;

        public GoalCollectionFactory(IGuidFactory guidFactory)
        {
            this.guidFactory = guidFactory;
        }

        public IGoalCollection Create()
        {
            return new GoalCollection(guidFactory.NewGuid());
        }
    }
}