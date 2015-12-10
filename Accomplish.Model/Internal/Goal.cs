namespace Accomplish.Model.Internal
{
    using System;

    internal sealed class Goal : IGoal
    {
        public Goal(Guid id)
        {
            Id = id;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public bool Complete
        {
            get;
            set;
        }
    }
}