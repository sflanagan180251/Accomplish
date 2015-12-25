namespace Accomplish.Model
{
    public interface IGoal : IUnique, IGoalContainer, ITitled, ICompletable
    {
        string Description { get; set; }
    }
}