namespace Accomplish.Model
{
    using System;

    public interface IGoal : IUnique, IGoalContainer
    {
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