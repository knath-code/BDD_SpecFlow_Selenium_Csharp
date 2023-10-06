using BDDFirstTest.Mediator;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDFirstTest.Steps
{
    [Binding, Scope(Feature = "Home")]
    public class Home
    {
        private HomeMediator _homeMediator;
        public Home()
        {
            
        }

        [BeforeScenario]
        public void Initialize()
        {
            _homeMediator = new HomeMediator();
        }

        [AfterScenario]
        public void AssertTestResults()
        {
            _homeMediator.CloseBrowser();
        }

        [Given(@"Open the url '(.*)' on chrome browser")]
        public void GivenOpenTheUrlOnChromeBrowser(string url)
        {
            _homeMediator.openBrowser(url);
        }


        [Then(@"Check application name as '(.*)'")]
        public void ThenCheckApplicationNameAs(string applicationName)
        {
            _homeMediator.CheckApplicationHeader(applicationName);
        }


        #region

        [Then(@"Two menu '(.*)' should be visible on UI")]
        public void ThenTwoMenuShouldBeVisibleOnUI(string menuList)
        {
            _homeMediator.CheckMenu(menuList);
        }
        [Then(@"'(.*)' should be in the top middle portion")]
        public void ThenShouldBeInTheTopMiddlePortion(string p0)
        {
            _homeMediator.HomePageContent(p0);
        }

        [Then(@"bottom having '(.*)' as value")]
        public void ThenBottomHavingAsValue(string bottomValue)
        {
            _homeMediator.HomePageBottomContent(bottomValue);
        }

        [When(@"User click on '(.*)' Menu")]
        public void WhenUserClickOnMenu(string pmenu0)
        {
            _homeMediator.ButtonClick(pmenu0);
        }
        [Then(@"User redirect to '(.*)' page")]
        public void ThenUserRedirectToPage(string page)
        {
            // HomeWork
        }
        #endregion
    }
}
