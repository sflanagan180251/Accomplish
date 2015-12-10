namespace Accomplish.Model
{
    using System;

    public interface IRecurranceRange
    {
        DateTime Start
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