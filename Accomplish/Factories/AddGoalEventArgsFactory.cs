namespace Accomplish.Factories
{
    using System.Linq;
    using Accomplish.Model;
    using Accomplish.Model.Events;

    public sealed class AddGoalEventArgsFactory : IAddGoalEventArgsFactory
    {
        public AddGoalEventArgs Create(IGoalCollection goalCollection)
        {
            return new AddGoalEventArgs(goalCollection, goalCollection.GoalList.Count());
        }
    }
}