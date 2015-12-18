namespace Accomplish.Tests.ViewModels
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using Accomplish.Common.Utils;
    using Accomplish.Model.Enum;
    using Accomplish.ViewModels;
    using NUnit.Framework;
    using Prism.Events;
    using Rhino.Mocks;
    using SpecEasy;

    internal sealed class GoalListViewModelSpec : Spec<GoalListViewModel>
    {
        public void Construction()
        {
            When("the goal list view model is constructed", () => SUT = Get<GoalListViewModel>());

            Given(() =>
            {
                Set(Mock<RibbonEvent>());
                Get<IEventAggregator>().Stub(eventAggregator => eventAggregator.GetEvent<RibbonEvent>()).Return(Get<RibbonEvent>());
            }).Verify(() =>
                Then("the ribbon event will be subscribed to", () => Get<RibbonEvent>().AssertWasCalled(ribbonEvent => ribbonEvent.Subscribe(Arg<Action<RibbonEvent.EventType>>.Is.Anything, Arg<ThreadOption>.Is.Anything, Arg<bool>.Is.Anything, Arg<Predicate<RibbonEvent.EventType>>.Is.Anything))));
        }

        public void AddEvent()
        {
            RibbonEvent.EventType? eventType = null;

            When("a ribbon event is raised",
                () =>
                {
                    SUT = Get<GoalListViewModel>();
                    Debug.Assert(eventType != null, "eventType != null");
                    Get<IEventAggregator>().GetEvent<RibbonEvent>().Publish(eventType.Value);
                });

            Given(() => Set<IEventAggregator>(new EventAggregator())).Verify(() => EnumUtils.GetValues<RibbonEvent.EventType>().ToList().ForEach(eventTypeToRaise => Given("the eventType to raise is " + eventTypeToRaise, () => eventType = eventTypeToRaise).Verify(() =>
            {
                switch (eventTypeToRaise)
                {
                    case RibbonEvent.EventType.Add:
                        Then("a goal is added to the collection", () => Assert.AreEqual(1, SUT.Goals.Count()));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Implement functionality for missing enum " + eventType);
                }
            })));
        }
    }
}