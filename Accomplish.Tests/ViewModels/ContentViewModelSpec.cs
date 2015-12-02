namespace Accomplish.Tests.ViewModels
{
    using System;
    using Accomplish.Model;
    using Accomplish.ViewModels;
    using Prism.Events;
    using Rhino.Mocks;
    using SpecEasy;

    internal sealed class ContentViewModelSpec : Spec<ContentViewModel>
    {
        public void Construction()
        {
            When("the content view model is constructed", () => SUT = Get<ContentViewModel>());

            Given(() =>
                {
                    Set(Mock<RibbonEvent>());
                    Get<IEventAggregator>().Stub(eventAggregator => eventAggregator.GetEvent<RibbonEvent>()).Return(Get<RibbonEvent>());
                }).Verify(() => Then("the ribbon event will be subscribed to", () => Get<RibbonEvent>().AssertWasCalled(ribbonEvent => ribbonEvent.Subscribe(Arg<Action<RibbonEvent.EventType>>.Is.Anything, Arg<ThreadOption>.Is.Anything, Arg<bool>.Is.Anything, Arg<Predicate<RibbonEvent.EventType>>.Is.Anything))));
        }
    }
}