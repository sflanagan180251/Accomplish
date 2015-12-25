namespace Accomplish.Model
{
    using Accomplish.Model.Internal;

    public sealed class GoalListFactory : IGoalListFactory
    {
        public IGoalList Create()
        {
            return new GoalList();
        }
    }
}