namespace Accomplish.Model
{
    using System;

    public interface IGoal
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

        bool Complete
        {
            get;
            set;
        }
    }
}