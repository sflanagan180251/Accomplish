namespace Accomplish.Model
{
    using System;

    internal interface IGoal
    {
        string Description
        {
            get;
            set;
        }

        Guid Id
        {
            get;
        }

        string Title
        {
            get;
            set;
        }
    }
}