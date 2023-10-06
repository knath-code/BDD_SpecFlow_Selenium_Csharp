using BDDFirstTest.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BDDFirstTest.Mediator
{
    public class HomeMediator
    {
        IWebDriver m_driver;
        HomePO homePO;
        public HomeMediator()
        {
            homePO = new HomePO();
        }
        public void openBrowser(string url)
        {
            m_driver = homePO.Instance(url);
        }

        public void CheckApplicationHeader(string applicationHeader)
        {
            string header = homePO.getApplicationHeaderText;//getHeader();
            Assert.AreEqual(applicationHeader, header);
        }

        public void CloseBrowser()
        {
            HomePO.Close();
        }


        #region
        public void CheckMenu(string menuList)
        {
            bool flag = false;
            string[] menus = menuList.Split(",");
            foreach (var item in menus)
            {
                IList<IWebElement> Elements = homePO.myMenuList.FindElements(By.TagName("li"));
                foreach (IWebElement element in Elements)
                {
                    Thread.Sleep(1000);
                    if (element.Text.Trim() == item.Trim())
                    {
                        flag = true;
                    }
                }

                Assert.IsTrue(flag);
            }
        }

        public void HomePageContent(string content)
        {
            Assert.AreEqual(content, homePO.myHomePageContent.Text);
        }

        public void HomePageBottomContent(string content)
        {
            Assert.IsTrue(homePO.myHomeBottomContent.Text.Trim().Contains(content));
        }

        public void ButtonClick(string buttonType)
        {
            switch (buttonType)
            {
                case "Privacy":
                    homePO.myPrivacyButton.Click();
                    Thread.Sleep(5000);
                    break;
                case "Home":
                    homePO.myHomeButton.Click();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
