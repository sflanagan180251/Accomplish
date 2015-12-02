namespace Accomplish.Tests.Model
{
    using System;
    using Accomplish.Model;
    using NUnit.Framework;
    using SpecEasy;

    internal sealed class GoalSpec : Spec<Goal>
    {
        private const string ExpectedGuidId = "F0128B1A-7915-4753-A23F-BAC72488F345";

        public void ConstructionWithId()
        {
            When("the goal is created", () => SUT = new Goal(new Guid(ExpectedGuidId)));

            Given("the guid provided to the goal is " + ExpectedGuidId, () => { }).Verify(() =>
                Then("the goal guid is " + ExpectedGuidId, () => Assert.IsTrue(ExpectedGuidId.Equals(SUT.Id.ToString("D"), StringComparison.InvariantCultureIgnoreCase))));
        }
    }
}