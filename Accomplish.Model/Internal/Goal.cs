namespace Accomplish.Model.Internal
{
    using System;

    [Serializable]
    internal sealed class Goal : IGoal
    {
        public Guid Id
        {
            get;
            set;
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