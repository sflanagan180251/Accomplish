namespace Accomplish.Model
{
    using Accomplish.Model.Internal;

    public sealed class GoalCollectionFactory : IGoalCollectionFactory
    {
        private readonly IGuidFactory guidFactory;

        private readonly IGoalListFactory goalListFactory;

        public GoalCollectionFactory(IGuidFactory guidFactory, IGoalListFactory goalListFactory)
        {
            this.guidFactory = guidFactory;
            this.goalListFactory = goalListFactory;
        }

        public IGoalCollection Create()
        {
            return new GoalCollection(guidFactory.NewGuid())
                {
                    GoalList = goalListFactory.Create()
                };
        }
    }
}