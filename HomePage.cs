using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHSNGTestOutput.pageObjects;
using NUnit.Framework;
using POMExample;

namespace FHSNGTestOutput.pageObjects
{
    class HomePage
    {
        String test_url = "https://global.neptune-acceptance.networkninja.com/login.php?RelayState=https%3A%2F%2Fglobal.neptune-acceptance.networkninja.com%2Fadmin%2Fedit_role.php%3Fid%3D1";

        private IWebDriver driver;
        private WebDriverWait wait;
        //Int32 timeout = 10000; // inmilliseconds

        private HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
        //Username
        ///var homePage = new HomePage();
       /// PageFactory.InitElements(driver, homePage);
         ///   homePage.MyAccount.Click();

         //   var loginPage = new LoginPage();
         //   PageFactory.InitElements(driver,loginPage);
          //  loginPage.Username.SendKeys("");
          //  loginPage.Password.SendKeys("Password");
          //  loginPage.submit.Submit();


        [FindsBy(How = How.Id, Using = "login")][CacheLookup]
      
       // public IWebElement txtUserName { get; set; }
        //public void SelectOperator(String txtUsername, String txtPassword)
        {
          //  this.txtUserName.SendKeys(txtUsername);

          //  this.txtPassword.SendKeys(txtPassword);

           // new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(.Displayed(this.txtUserName));
          
        //}
    /

        //Password
       // [FindsBy(How = How.ClassName, Using = "password")]
       // [CacheLookup]
       // public IWebElement txtPassword { get; set; }

        //Submit_button
        //[FindsBy(How = How.LinkText, Using = "btn-primary")]
        //[CacheLookup]
        //public IWebElement btnLogin { get; set; }
       // String LinkText = btnLogin.GetAttribute("LinkText");
        
        

        // Successful login
        //[FindsBy(How = How.LinkText, Using = "neptune-qa")]
        //[CacheLookup]
        //private IWebElement lnkNeptuneClient;

        async void async_delay()
        {
            await Task.Delay(50);

        }

        public void wait_page_completion(int timeout)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            //Wait for page to load
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("Complete"));
        }

        // Go to the designated page
        public void goToPage()
        {
            driver.Navigate().GoToUrl(test_url);
        }

        // Returns the Page Title
        public String getPageTitle()
        {
            return driver.Title;
        }

        // Logo displayed
        //public String getSearchText()
        //{
           // return elem_search_text.Text;
        //}

        // Checks whether the Logo is displayed properly or not
        public bool getWebPageLogo()
        {

            Assert.That(lnkNeptuneClient.Displayed, Is.True);
            return true;
           //return lnkNeptuneClient.Displayed("");
        }

       // public SearchPage test_search(string input_search)
        //{
         //   elem_search_text.SendKeys(input_search);
            //wait.Until(ExpectedConditions.ElementToBeClickable(elem_submit_button)).Submit();
          //  elem_search_text.Submit();
          //  return new SearchPage(driver);
        
    }
}
