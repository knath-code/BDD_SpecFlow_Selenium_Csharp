using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace BDDFirstTest.PageObject
{
    public class HomePO
    {
        static IWebDriver chromeDriver = null;

        public IWebDriver Instance(string url)
        {
            if (chromeDriver == null)
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                chromeDriver = new ChromeDriver();

                chromeDriver.Navigate().GoToUrl(url);
                chromeDriver.Manage().Window.Maximize();

                PageFactory.InitElements(chromeDriver, this);
                #region another browser
                //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                //FirefoxDriver firefoxDriver = new FirefoxDriver();

                //new WebDriverManager.DriverManager().SetUpDriver(new InternetExplorerConfig());
                //InternetExplorerDriver ieDriver = new InternetExplorerDriver();
                #endregion
            }
            return chromeDriver;
        }

        public string getHeader()
        {
            IWebElement webElement = chromeDriver.FindElement(By.Id("id_ApplicationHeader"));
            return webElement.Text.Trim();
        }
        public static void Close()
        {
            if (chromeDriver == null)
            {
                return;
            }
            chromeDriver.Close();
            chromeDriver.Quit();
            chromeDriver = null;
        }

        #region 
        [FindsBy(How = How.Id, Using = "id_ApplicationHeader")]
        public IWebElement myApplicationHeader;

        public string getApplicationHeaderText => this.myApplicationHeader.Text.Trim();


        [FindsBy(How = How.CssSelector, Using = "body > header > nav > div > div > ul")]
        public IWebElement myMenuList;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div/h1")]
        public IWebElement myHomePageContent;

        [FindsBy(How = How.XPath, Using = "/html/body/footer/div")]
        public IWebElement myHomeBottomContent;

        [FindsBy(How = How.Id, Using = "id_Menu_Privacy")]
        public IWebElement myPrivacyButton;

        [FindsBy(How = How.Id, Using = "id_Menu_Home")]
        public IWebElement myHomeButton;

        #endregion
    }
}
