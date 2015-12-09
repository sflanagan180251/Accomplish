namespace Accomplish.Model
{
    using System;

    public interface IRecurrance
    {
        WhenToRecur WhenToRecur
        {
            get;
            set;
        }

        TimeSpan Period
        {
            get;
            set;
        }

        DateTime? Expires
        {
            get;
            set;
        }

        int? Remaining
        {
            get;
            set;
        }
    }
}