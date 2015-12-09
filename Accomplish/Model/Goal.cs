namespace Accomplish.Model
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

        public DateTime Start
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