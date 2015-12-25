namespace Accomplish.Model
{
    using Accomplish.Model.Internal;

    public sealed class GoalFactory : IGoalFactory
    {
        private readonly IGuidFactory guidFactory;

        public GoalFactory(IGuidFactory guidFactory)
        {
            this.guidFactory = guidFactory;
        }

        public IGoal Create()
        {
            return new Goal { Uid = guidFactory.NewGuid() };
        }
    }
}