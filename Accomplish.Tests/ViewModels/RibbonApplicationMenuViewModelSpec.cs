namespace Accomplish.Tests.ViewModels
{
    using Accomplish.Model.Events;
    using Accomplish.ViewModels;
    using NUnit.Framework;
    using Prism.Events;
    using Rhino.Mocks;
    using SpecEasy;

    internal sealed class RibbonApplicationMenuViewModelSpec : Spec<RibbonApplicationMenuViewModel>
    {
        public void Construction()
        {
            When("the ribbon view model is constructed", () => SUT = Get<RibbonApplicationMenuViewModel>());

            Then("a new command will be instantiated", () => Assert.IsNotNull(SUT.NewCommand));
            Then("the create command will not be executable", () => Assert.IsTrue(SUT.NewCommand.CanExecute(null)));

            Then("a open command will be instantiated", () => Assert.IsNotNull(SUT.OpenCommand));
            Then("the open command will not be executable", () => Assert.IsFalse(SUT.OpenCommand.CanExecute(null)));

            Then("a save command will be instantiated", () => Assert.IsNotNull(SUT.SaveCommand));
            Then("the save command will not be executable", () => Assert.IsFalse(SUT.SaveCommand.CanExecute(null)));

            Then("a close command will be instantiated", () => Assert.IsNotNull(SUT.ExitCommand));
            Then("the close command will be executable", () => Assert.IsTrue(SUT.ExitCommand.CanExecute(null)));
        }

        public void NewCommand()
        {
            var mockNewGoalCollectionEvent = Mock<NewGoalCollectionEvent>();

            When("the new command is executed", () => SUT.NewCommand.Execute(null));

            Given(() => Get<IEventAggregator>().Stub(eventAggregator => eventAggregator.GetEvent<NewGoalCollectionEvent>()).Return(mockNewGoalCollectionEvent)).Verify(() =>
                Then("a new goal collection event is raised on the event aggregator", () => mockNewGoalCollectionEvent.AssertWasCalled(newGoalCollectionEvent => newGoalCollectionEvent.Publish(Arg<object>.Is.Anything))));
        }

        public void ExitCommand()
        {
            var mockApplicationEvent = Mock<ApplicationEvent>();

            When("the exit command is executed", () => SUT.ExitCommand.Execute(null));

            Given(() => Get<IEventAggregator>().Stub(eventAggregator => eventAggregator.GetEvent<ApplicationEvent>()).Return(mockApplicationEvent)).Verify(() =>
                Then("an application exit event is raised on the event aggregator", () => mockApplicationEvent.AssertWasCalled(applicationEvent => applicationEvent.Publish(Arg<ApplicationEvent.EventType>.Is.Equal(ApplicationEvent.EventType.Exit)))));
        }
    }
}