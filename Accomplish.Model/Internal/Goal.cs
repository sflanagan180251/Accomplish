namespace Accomplish.Model.Internal
{
    using System;

    [Serializable]
    internal sealed class Goal : IGoal
    {
        public bool Complete { get; set; }

        public string Description { get; set; }

        public IGoalList GoalList { get; set; }

        public Guid Uid { get; set; }

        public string Title { get; set; }
    }
}