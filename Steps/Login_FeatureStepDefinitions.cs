using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using TechTalk.SpecFlow;
using FHSNGTestOutput.Pages;
using TechTalk.SpecFlow.Assist;
using FHSNGTestOutput.pageObjects;

namespace FHSNGTestOutput.Steps
{
    [Binding]
    public class Login_FeatureStepDefinitions
    {

       // public IWebDriver driver;
        //= new ChromeDriver(@"C:/Users/mnethery/Downloads/chromeDriver_win32/");
        //LoginPage page = new LoginPage(driver);
        

        //public LoginPage LoginPage { get => loginPage; set => loginPage = value; }

        //Step Definitions

        [Given(@"User launches Application")]
        public void GivenUserLaunchesApplication()
        {
            
            //driver = new ChromeDriver();
            // Console.WriteLine("Inside Step -Browser is open");
            // string projectPath = System.getPropery("");
            // Console.WriteLine("ProdjectPath is :" + projectPath);
            // System.setProperty("")

            //IWebDriver driver = new ChromeDriver();
            //WebDriverWait wait = new(driver, TimeSpan.FromSeconds(2));
            //driver.Url = "https://global.neptune-qa.networkninja.com/login.php?RelayState=https%3A%2F%2Fglobal.neptune-qa.networkninja.com%2Fselect-client.php");
            //LoginPage loginPage = new LoginPage(driver);

            driver.Manage().Window.Maximize();

           // wait.Timeout = TimeSpan.FromSeconds(5);

            //IWebElement loginLogo = driver.FindElement(By.ClassName("img-responsive"));
          //  Assert.That(loginLogo.Displayed, Is.True);
           // Console.WriteLine(loginLogo.Text);
        }

        [Given(@"User enters the following details")]
        public void GivenUserEntersTheFollowingDetails(Table table)
        {
            //dynamic credentials = table.CreateDynamicInstance();
            //loginPage.Login((string)credentials.userName, (string)credentials.password);  


            // Enter Username
            //webDriver.FindElement(By.Id("login")).SendKeys("SampleuserManager");
            //Click button
            //webDriver.FindElement(By.ClassName("btn-primary")).Submit();
            //IWebElement password = webDriver.FindElement(By.Id("password"));
            //Assert.That(password.Displayed, Is.True);

            //Enter Password
           // webDriver.FindElement(By.Id("password")).SendKeys("RMco820208$$$");
        }

        [Given(@"Click on the LogIn button")]
        public void GivenClickOnTheLogInButton()
        {
            //Assert.AreEqual("Login", driver.Title);
           // driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        [Then(@"Neptune Client will appear")]
        public void ThenNeptuneClientWillAppear()
        {
            ///driver.FindElement(By.LinkText("neptune-qa"));
            //IWebElement lnkneptune = driver.FindElement(By.LinkText("neptune-qa"));
           // Assert.That(lnkneptune.Displayed, Is.True);
        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
           // driver.FindElement(By.Id("bs-example-navbar-collapse-1")).Click();
            //IWebElement link = Driver.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 > ul.nav.navbar-nav.navbar-right > li.dropdown.open > ul > li:nth-child(6) > a"));

            IWebElement logOut = driver.FindElement(By.CssSelector("a[href^='/login.php?logout=t]"));
            logOut.Click();
            Console.WriteLine("User is Logging Out");
        }

        [Then(@"Login Page will appear")]
        public void ThenLoginPageWillAppear()
        {
            IWebElement loginLogo = driver.FindElement(By.ClassName("img-responsive"));
            Assert.That(loginLogo.Displayed, Is.True);
            Console.WriteLine("User Successfully Logged Out");
        }
    }
}
