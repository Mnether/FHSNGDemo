using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace FHSNGTestOutput.pageObjects
{
    class FinalPage
    {
        public IWebDriver driver;
        Int32 timeout = 10000; // in milliseconds

        public FinalPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

            [FindsBy(How = How.LinkText, Using = "neptune-qa")]
            [CacheLookup]
            IWebElement lnkNeptuneClient { get; set; }
        

        public String getPageTitle()
        {
            return driver.Title;
        }

        // Checks whether the LambdaTest Logo is displayed properly or not
        public bool getLTPageLogo()
        {
            return lnkNeptuneClient.Displayed;
        }

        public void load_complete(int timeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));

            // Wait for the page to load
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void Client_link_click()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));
            // Wait for page to load
            wait.Until(d =>((IJavaScriptExecutor)d).ExecuteScript("return HtmlDocument.readyState").Equals("Complete"));
           // lnkNeptuneClient.Click();

           // load_complete(timeout);
        }
    }
}