namespace Accomplish.Tests.ViewModels
{
    using Accomplish.ViewModels;
    using NUnit.Framework;
    using SpecEasy;

    internal sealed class RibbonApplicationMenuViewModelSpec : Spec<RibbonApplicationMenuViewModel>
    {
        public void Construction()
        {
            When("the ribbon view model is constructed", () => SUT = Get<RibbonApplicationMenuViewModel>());

            Then("a new command will be instantiated", () => Assert.IsNotNull(SUT.NewCommand));
            Then("the create command will not be executable", () => Assert.IsFalse(SUT.NewCommand.CanExecute(null)));

            Then("a open command will be instantiated", () => Assert.IsNotNull(SUT.OpenCommand));
            Then("the open command will not be executable", () => Assert.IsFalse(SUT.OpenCommand.CanExecute(null)));

            Then("a save command will be instantiated", () => Assert.IsNotNull(SUT.SaveCommand));
            Then("the save command will not be executable", () => Assert.IsFalse(SUT.SaveCommand.CanExecute(null)));

            Then("a close command will be instantiated", () => Assert.IsNotNull(SUT.ExitCommand));
            Then("the close command will be executable", () => Assert.IsTrue(SUT.ExitCommand.CanExecute(null)));
        }
    }
}