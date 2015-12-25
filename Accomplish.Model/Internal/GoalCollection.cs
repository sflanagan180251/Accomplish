namespace Accomplish.Model.Internal
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal sealed class GoalCollection : IGoalCollection
    {
        public GoalCollection(Guid id)
        {
            Id = id;
        }

        public Guid Id
        {
            get;
        }

        public string Title
        {
            get; set;
        }

        public IGoalList GoalList
        {
            get;
            set;
        }
    }
}