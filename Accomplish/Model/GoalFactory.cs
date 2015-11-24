using System;

namespace Accomplish.Model
{
    internal sealed class GoalFactory : IGoalFactory
    {
        public Goal Create()
        {
            return new Goal(Guid.NewGuid());
        }
    }
}