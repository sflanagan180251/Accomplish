namespace Accomplish.Model.Events
{
    using System;

    public sealed class AddGoalEventArgs : EventArgs
    {
        public AddGoalEventArgs(IGoalContainer goalContainer, int position)
        {
            GoalContainer = goalContainer;
            Position = position;
        }

        public IGoalContainer GoalContainer
        {
            get;
        }

        public int Position
        {
            get;
        }
    }
}