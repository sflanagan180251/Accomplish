namespace Accomplish.Common.Tests.Utils
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using Accomplish.Common.Utils;
    using NUnit.Framework;
    using SpecEasy;
    internal sealed class EnumUtilsSpec : Spec
    {
        enum TestEnum
        {
            Value1,
            Value2
        }

        public void GetValues()
        {
            List<TestEnum> result = null;
            List<TestEnum> expectedResult = new List<TestEnum>(new [] {TestEnum.Value1, TestEnum.Value2, });

            When("the values are retrieved", () => result = EnumUtils.GetValues<TestEnum>()
                                                                .ToList());

            Then("the list of values matches " + string.Join(", ", expectedResult), () => Assert.IsTrue(result.SequenceEqual(expectedResult)));
        }
    }
}