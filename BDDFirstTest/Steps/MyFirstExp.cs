using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDFirstTest.Steps
{
    [Binding, Scope(Feature = "MyTestExp")]
    public class MyFirstExp
    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number1)
        {
            Assert.AreEqual(50, number1);
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number1)
        {
            Assert.AreEqual(70, number1);
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Assert.IsTrue(true);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(120, p0);
        }

        [Then(@"the result of (.*) and (.*) should be (.*)")]
        public void ThenTheResultOfAndShouldBe(int p0, int p1, int p2)
        {
            Assert.AreEqual(p0 + p1, p2);
        }


    }
}
