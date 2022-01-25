using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using FHSNGTestOutput.pageObjects;

namespace FHSNGTestOutput.pageObjects
{
    class LoginPage
    {
        private IWebDriver driver;
        Int32 timeout = 10000; // in milliseconds

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

       // [FindsBy(How = How.Id, Using = "login")]
       // [CacheLookup]
       // public IWebElement txtUserName { get; set; }

        //Password
       // [FindsBy(How = How.ClassName, Using = "password")]
       // [CacheLookup]
       // public IWebElement txtPassword { get; set; }

        //Submit_button
        //[FindsBy(How = How.ClassName, Using = "btn-primary")]
      //  [CacheLookup]
      //  private IWebElement btnLogin;

        // Successful login
       // [FindsBy(How = How.LinkText, Using = "neptune-qa")]
       // [CacheLookup]
       // private IWebElement lnkNeptuneClient;

        // Returns the Page Title
        public String getPageTitle()
        {
            return driver.Title;
        }

        async void async_delay(int delay)
        {
            await Task.Delay(delay);
        }

        public void wait_page_completion(int timeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout));

            // Wait for the page to load
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void send_userCredentals(String txtUsername, String txtPassword)
        {
            //As the page load is already complete, we can directly enter the user name then transition to the password page

            IWebElement txtUsername = driver.FindElement(By.Id("username"));
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            IWebElement btnUsernameSubmit = driver.FindElement(By.ClassName("btn-primary"));

            txtUsername.SendKeys("SampleuserManager");
            async_delay(50);

           
            btnUsernameSubmit.Click();

            txtPassword.SendKeys("RMco820208$$$");
            async_delay(50);

            //CacheLookupAttribute.Equals(txtUsername, txtPassword);
        }
        public FinalPage submit_uidpwd()
        {
            IWebElement btnLogin = driver.FindElement(By.ClassName("btn-primary"));
            btnLogin.Click();

            // Wait for the new page to load. This is the LambdaTest dashboard
            wait_page_completion(timeout);

            return new FinalPage(driver);
        }
    }
}