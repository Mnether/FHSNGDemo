using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using FHSNGTestOutput.pageObjects;  


namespace POMExample
{
    [TestFixture("chrome", "97.0", "Windows 10")]
    [TestFixture("internet explorer", "11.0", "Windows 10")]
    [TestFixture("Safari", "11.0", "macOS High Sierra")]
    [TestFixture("MicrosoftEdge", "18.0", "Windows 10")]
    [Parallelizable(ParallelScope.All)]
    public class ParallelLTTests
    {
       
       // String web_page_title = "FHSNG SITE";
        ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public String browser;
        public String version;
        public String os;

        public ParallelLTTests(String browser, String version, String os)
        {
            this.browser = browser;
            this.version = version;
            this.os = os;
        }

        [SetUp]
        public void Init()
        {
            String txtUsername = "username";
                      

            DesiredCapabilities capabilities = new DesiredCapabilities(capabilities.ToString);

            capabilities.SetCapability("user:", txtUsername);
            capabilities.SetCapability("browserName", browser);
            capabilities.SetCapability("version", version);
            capabilities.SetCapability("platform", os);

            //driver = new ChromeDriver();
            driver.Value = new RemoteWebDriver(new Uri("https://" + txtUsername ), capabilities, TimeSpan.FromSeconds(600));

            System.Threading.Thread.Sleep(2000);
        }

        [Test]
        public void LT_Login_Test()
        {
            // Add your Test credentials here
            String txtUsername = "user-name@gmail.com";
            String txtPassword = "password";
            String expected_dashboard_title = "Global";
            String fetched_dashboard_title;

            HomePage home_page = new HomePage (driver.Value);
            home_page.goToPage();

            //Keeping the error catching mechanism very minimal
            if (!home_page.getWebPageLogo())
            {
                Console.WriteLine("LT_Login_Test Failed");
            }

            // Since the LT Home page is displayed, we perform the Login Click Operation
            //home_page.goToPage();

            LoginPage login_page = new LoginPage (driver.Value);

            login_page.send_userpassword(txtUsername, txtPassword);

            // Since the wait is already added in the code, we just click the Submit button
            login_page.submit_uidpwd();
            login_page.

            // Now we have logged in and on the Dashboard page, check the title of the page
            FinalPage final_page = new FinalPage(driver.Value);

            fetched_dashboard_title = final_page.getPageTitle();
            if (fetched_dashboard_title == expected_dashboard_title)
            {
                Console.WriteLine("FHSNG Dashboard open successful");

                final_page.Client_link_click();

                Console.WriteLine("LambdaTest Automation Tab open successful");
            }
            else
            {
                Console.WriteLine("LambdaTest Dashboard open not successful");
            }
        }

        [TearDown]
        public void Cleanup()
        {
            bool passed = TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed;
            try
            {
                // Logs the result to Lambdatest
                IJavaScriptExecutor jse =(IJavaScriptExecutor)driver;
                jse .ExecuteScript("status=" + (passed ? "passed" : "failed"));
            }
            finally
            {
                // Terminates the remote webdriver session
                driver.Dispose();
            }
        }
    }
}