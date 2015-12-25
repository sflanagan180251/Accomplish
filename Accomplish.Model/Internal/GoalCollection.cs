namespace Accomplish.Model.Internal
{
    using System;

    internal sealed class GoalCollection : IGoalCollection
    {
        public GoalCollection(Guid uid)
        {
            Uid = uid;
        }

        public IGoalList GoalList { get; set; }

        public Guid Uid { get; }

        public string Title { get; set; }
    }
}