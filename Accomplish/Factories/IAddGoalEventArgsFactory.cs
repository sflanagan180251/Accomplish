namespace Accomplish.Factories
{
    using Accomplish.Model;
    using Accomplish.Model.Events;

    public interface IAddGoalEventArgsFactory
    {
        AddGoalEventArgs Create(IGoalCollection goalCollection);
    }
}