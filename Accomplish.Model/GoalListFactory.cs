namespace Accomplish.Model
{
    using Accomplish.Model.Internal;

    public sealed class GoalListFactory : IGoalListFactory
    {
        private readonly IGuidFactory guidFactory;

        public GoalListFactory(IGuidFactory guidFactory)
        {
            this.guidFactory = guidFactory;
        }

        public IGoalList Create()
        {
            return new GoalList(guidFactory.NewGuid());
        }
    }
}