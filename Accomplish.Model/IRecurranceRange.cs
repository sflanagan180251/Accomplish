namespace Accomplish.Model
{
    using System;

    public interface IRecurranceRange
    {
        DateTime? Expires { get; set; }

        int? Remaining { get; set; }

        DateTime Start { get; set; }
    }
}