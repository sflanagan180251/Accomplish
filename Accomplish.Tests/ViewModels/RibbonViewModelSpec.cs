namespace Accomplish.Tests.ViewModels
{
    using System;
    using Accomplish.Model;
    using Accomplish.ViewModels;
    using NUnit.Framework;
    using Prism.Events;
    using Rhino.Mocks;
    using SpecEasy;

    internal sealed class RibbonViewModelSpec : Spec<RibbonViewModel>
    {
        public void Construction()
        {
            When("the ribbon view model is constructed", () => SUT = Get<RibbonViewModel>());

            Then("an add command will be instantiated", () => Assert.IsNotNull(SUT.AddCommand));
            Then("the add command will be executable", () => Assert.IsTrue(SUT.AddCommand.CanExecute(null)));

            Then("a create command will be instantiated", () => Assert.IsNotNull(SUT.CreateCommand));
            Then("the create command will not be executable", () => Assert.IsFalse(SUT.CreateCommand.CanExecute(null)));

            Then("a open command will be instantiated", () => Assert.IsNotNull(SUT.OpenCommand));
            Then("the open command will not be executable", () => Assert.IsFalse(SUT.OpenCommand.CanExecute(null)));

            Then("a save command will be instantiated", () => Assert.IsNotNull(SUT.SaveCommand));
            Then("the save command will not be executable", () => Assert.IsFalse(SUT.SaveCommand.CanExecute(null)));
        }
    }
}