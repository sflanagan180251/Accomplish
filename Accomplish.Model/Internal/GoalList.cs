namespace Accomplish.Model.Internal
{
    using System;
    using System.Collections.Generic;

    internal sealed class GoalList : List<IGoal>, IGoalList
    {
        public GoalList(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

        public string Title { get; set; }
    }
}