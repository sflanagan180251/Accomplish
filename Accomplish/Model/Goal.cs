using System;

namespace Accomplish.Model
{
    internal sealed class Goal : IGoal
    {
        public Goal(Guid id)
        {
            Id = id;
        }

        public string Title
        {
            get;
            set;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public string Description
        {
            get;
            set;
        }
    }
}
