namespace Accomplish.Model
{
    using System;
    using Accomplish.Model.Internal;

    public sealed class GoalFactory : IGoalFactory
    {
        public IGoal Create()
        {
            return new Goal(Guid.NewGuid());
        }
    }
}