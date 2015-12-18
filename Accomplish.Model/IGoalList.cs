namespace Accomplish.Model
{
    using System;
    using System.Collections.Generic;

    public interface IGoalList : IEnumerable<IGoal>
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