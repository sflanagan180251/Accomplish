namespace Accomplish.Tests.ViewModels
{
    using Accomplish.Model.Enum;
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
            When("the add command is executed", () => SUT.AddCommand.Execute(null));

            Given(() =>
            {
                Set(Mock<RibbonEvent>());
                Get<IEventAggregator>()
                    .Stub(eventAggregator => eventAggregator.GetEvent<RibbonEvent>())
                    .Return(Get<RibbonEvent>());
            })
                .Verify(() =>
                        Then("the add ribbon event is published", 
                            () => Get<RibbonEvent>()
                                      .AssertWasCalled(ribbonEvent => ribbonEvent.Publish(RibbonEvent.EventType.Add))));
        }
    }
}