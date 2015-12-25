namespace Accomplish.Tests.ViewModels
{
    using Accomplish.Factories;
    using Accomplish.Model;
    using Accomplish.Model.Enum;
    using Accomplish.Model.Events;
    using Accomplish.ViewModels;
    using NUnit.Framework;
    using Prism.Events;
    using Rhino.Mocks;
    using SpecEasy;

    internal sealed class RibbonTabViewModelSpec : Spec<RibbonTabViewModel>
    {
        public void Construction()
        {
            When("the ribbon view model is constructed", () => SUT = Get<RibbonTabViewModel>());

            Then("an add command will be instantiated", () => Assert.IsNotNull(SUT.AddCommand));
            Then("the add command will be executable", () => Assert.IsTrue(SUT.AddCommand.CanExecute(null)));
        }

        public void AddCommand()
        {
            AddGoalEventArgs addGoalEventArgs = null;

            When("the add command is executed", () => SUT.AddCommand.Execute(null));

            Given(() =>
            {
                addGoalEventArgs = new AddGoalEventArgs(Get<IGoalContainer>(), 0);
                Set(Mock<AddGoalEvent>());
                Get<IEventAggregator>()
                    .Stub(eventAggregator => eventAggregator.GetEvent<AddGoalEvent>())
                    .Return(Get<AddGoalEvent>());
                Get<IAddGoalEventArgsFactory>().Stub(addGoalEventArgsFactory => addGoalEventArgsFactory.Create(Get<IGoalCollection>())).Return(addGoalEventArgs);
            })
                .Verify(() =>
                        Then("the add goal event is published",
                            () => Get<AddGoalEvent>()
                                      .AssertWasCalled(addGoalEvent => addGoalEvent.Publish(Arg<AddGoalEventArgs>.Is.Same(addGoalEventArgs)))));
        }

        public void CloseCommand()
        {
            When("the close command is executed", () => SUT.CloseCommand.Execute(null));

            Given(() =>
            {
                Set(Mock<CloseGoalCollectionEvent>());
                Get<IEventAggregator>()
                    .Stub(eventAggregator => eventAggregator.GetEvent<CloseGoalCollectionEvent>())
                    .Return(Get<CloseGoalCollectionEvent>());
            })
                .Verify(() =>
                        Then("the close goal collection event is published",
                            () => Get<CloseGoalCollectionEvent>()
                                      .AssertWasCalled(closeGoalCollectionEvent => closeGoalCollectionEvent.Publish(Arg<IGoalCollection>.Is.Same(Get<IGoalCollection>())))));
        }
    }
}