namespace Accomplish.Model
{
    using System;

    public interface IGoalCollection : IGoalList
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
    }
}