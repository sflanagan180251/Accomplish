namespace Accomplish.Tests.ViewModels
{
    using System;
    using System.Diagnostics;
    using Accomplish.Common.Utils;
    using Accomplish.Model;
    using Accomplish.ViewModels;
    using NUnit.Framework;
    using Prism.Events;
    using Rhino.Mocks;
    using SpecEasy;
    using System.Linq;

    internal sealed class ContentViewModelSpec : Spec<ContentViewModel>
    {
        public void Construction()
        {
            When("the content view model is constructed", () => SUT = Get<ContentViewModel>());

            Given(() =>
            {
                Set(Mock<RibbonEvent>());
                Get<IEventAggregator>().Stub(eventAggregator => eventAggregator.GetEvent<RibbonEvent>()).Return(Get<RibbonEvent>());
            }).Verify(() =>
            Then("the ribbon event will be subscribed to", () => Get<RibbonEvent>().AssertWasCalled(ribbonEvent => ribbonEvent.Subscribe(Arg<Action<RibbonEvent.EventType>>.Is.Anything, Arg<ThreadOption>.Is.Anything, Arg<bool>.Is.Anything, Arg<Predicate<RibbonEvent.EventType>>.Is.Anything))));
        }

        public void RibbonEventSubscription()
        {
            RibbonEvent.EventType? eventType = null;

            When("a ribbon event is raised", () =>
            {
                SUT = Get<ContentViewModel>();
                Debug.Assert(eventType != null, "eventType != null");
                Get<IEventAggregator>().GetEvent<RibbonEvent>().Publish(eventType.Value);
            });

            Given(() => Set<IEventAggregator>(new EventAggregator())).Verify(() =>
                EnumUtils.GetValues<RibbonEvent.EventType>().ToList().ForEach(eventTypeToRaise =>
                    Given($"the eventType to raise is {eventTypeToRaise}", () => eventType = eventTypeToRaise).Verify(() =>
                        Then($"the event value will be stored as {eventTypeToRaise} in the content text", () => Assert.AreEqual(eventTypeToRaise.ToString(), SUT.ContentText)))));
        }
    }
}