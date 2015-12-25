namespace Accomplish.Model.Events
{
    using System;

    public sealed class AddGoalEventArgs : EventArgs
    {
        public AddGoalEventArgs(IGoalList goalList, int position)
        {
            GoalList = goalList;
            Position = position;
        }

        public IGoalList GoalList
        {
            get;
        }

        public int Position
        {
            get;
        }
    }
}