﻿namespace Accomplish.Model
{
    using System;

    internal sealed class Goal : IGoal
    {
        public Goal(Guid id)
        {
            Id = id;
        }

        public string Description
        {
            get;
            set;
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
    }
}