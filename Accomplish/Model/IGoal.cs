﻿namespace Accomplish.Model
{
    using System;

    internal interface IGoal
    {
        Guid Id
        {
            get;
        }

        string Title
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        DateTime Start
        {
            get;
            set;
        }

        bool Complete
        {
            get;
            set;
        }
    }
}