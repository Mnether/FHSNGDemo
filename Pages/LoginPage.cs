using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
//using FHSNGTestOutput.Steps;
using SeleniumExtras.PageObjects;


namespace FHSNGTestOutput.Pages
{
    public class LoginPage
    {
        String test_url = "https://www.google.com/url?q=https://global.neptune-acceptance.networkninja.com/admin/edit_role.php?id%3D1&sa=D&source=docs&ust=1642695191040214&usg=AOvVaw0O6uo3kcCDiYZ9MeyhM-Zv";

        private IWebDriver driver;
        private WebDriverWait wait;

        //private IWebElement txtUserName => driver.FindElement(By.Id("login"));
        //private IWebElement txtPassword => driver.FindElement(By.Id("password"));
        //private IWebElement btnLogin => driver.FindElement(By.ClassName("btn-primary"));


        //public IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(driver, this);
        }
        //Username
       // [FindsBy(How = How.Id, Using = "login")]
       // [CacheLookup]
       // private IWebElement txtUserName;
        //Password
       // [FindsBy(How = How.Id, Using = "password")]
       // [CacheLookup]
       // private IWebElement txtPassword;
        //Submit_button
       // [FindsBy(How = How.ClassName, Using = "btn-primary")]
       // [CacheLookup]
        //private IWebElement btnLogin;
        // Successful login
       // [FindsBy(How = How.LinkText, Using = "neptune-qa")]
        //[CacheLookup]
       // private IWebElement lnkNeptuneClient;

        public void gotoPage()
        {
            driver.Navigate().GoToUrl(test_url);
        }
        public String GETpAGEtITLE()
        {
            return driver.Title;
        }



        //UI Elements

        //dynamic credentials = Table.CreateDynamicInstance();
        //public IWebElement txtUserName => WebDriver.FindElement(By.Id("login"));
        // public IWebElement txtPassword => WebDriver.FindElement(By.Id("password"));
        //public IWebElement btnLogin => WebDriver.FindElement(By.ClassName("btn-primary"));
        //public IWebElement lnkNeptuneClient => driver.FindElement(By.LinkText("neptune-qa"));

       // public void Login(string username, string password = "test")
        //{
        //    txtUserName.SendKeys(username);

          //  txtPassword.SendKeys(password);
          //  btnLogin.Click();
          //  var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            // wait.Until(ExpectedConditions.Stlenessof(btnLogin));
            //return new




           // public void ClickLogin() => btnLogin.Click();

            public bool IsNeptuneClientExist()
        {
             return lnkNeptuneClient.Displayed;
        
            //public void Login(string)
        }    
    }
}
