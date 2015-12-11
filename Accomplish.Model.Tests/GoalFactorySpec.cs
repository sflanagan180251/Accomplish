namespace Accomplish.Model.Tests
{
    using System;
    using Accomplish.Model.Internal;
    using NUnit.Framework;
    using Rhino.Mocks;
    using SpecEasy;

    internal sealed class GoalFactorySpec : Spec<GoalFactory>
    {
        private const string ExpectedGuidId = "F0128B1A-7915-4753-A23F-BAC72488F345";

        public void Create()
        {
            IGoal result = null;

            When("the goal is created", () => result = SUT.Create());

            Given("the guid provided to the goal is " + ExpectedGuidId, () => Get<IGuidFactory>().Stub(guidFactory => guidFactory.NewGuid()).Return(new Guid(ExpectedGuidId))).Verify(() =>
                Then("the goal guid is " + ExpectedGuidId, () => Assert.IsTrue(ExpectedGuidId.Equals(result.Id.ToString("D"), StringComparison.InvariantCultureIgnoreCase))));
        }
    }
}