namespace Accomplish.Model
{
    using System;
    using System.Collections.Generic;
    using Accomplish.Model.Enum;

    public interface IRecurrancePattern
    {
        WhenToRecur WhenToRecur
        {
            get;
            set;
        }

        IEnumerable<DayOfWeek> DaysOfWeek
        {
            get;
            set;
        }

        IEnumerable<int> DaysOfMonth
        {
            get;
            set;
        }

        IEnumerable<Weeks> WeeksOfMonth
        {
            get;
            set;
        }

        IEnumerable<int> MonthsOfYear
        {
            get;
            set;
        }
    }
}