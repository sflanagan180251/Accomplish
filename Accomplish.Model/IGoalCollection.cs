﻿namespace Accomplish.Model
{
    using System;

    public interface IGoalCollection : IUnique, IGoalContainer
    {
        string Title
        {
            get;
            set;
        }
    }
}