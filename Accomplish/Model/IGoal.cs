using System;

namespace Accomplish.Model
{
    internal interface IGoal
    {
        Guid Id
        {
            get;
        }

        string Description
        {
            get;
            set;
        }

        string Title
        {
            get;
            set;
        }
    }
}