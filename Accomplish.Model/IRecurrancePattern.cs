namespace Accomplish.Model
{
    using System;
    using System.Collections.Generic;
    using Accomplish.Model.Enum;

    public interface IRecurrancePattern
    {
        IEnumerable<int> DaysOfMonth { get; set; }

        IEnumerable<DayOfWeek> DaysOfWeek { get; set; }

        IEnumerable<int> MonthsOfYear { get; set; }

        IEnumerable<Weeks> WeeksOfMonth { get; set; }

        WhenToRecur WhenToRecur { get; set; }
    }
}