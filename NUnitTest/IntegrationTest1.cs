using IsaProject.Areas.Identity.Pages.Account;
using IsaProject.Data;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using IsaProject.Models.DTO;
using SeleniumExtras.WaitHelpers;

namespace NUnitTest
{
   class IntegrationTest1
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly ApplicationDbContext _context;
        private IWebDriver _webDriver;
        private WebDriverWait _wait;
        private int _timeoutInSeconds = 30;
        private static string _driverPath = Environment.CurrentDirectory + "\\WebDriverGoogleChome\\";


        [SetUp]
        public void SetUp()
        {
            _webDriver = new ChromeDriver(_driverPath);
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(_timeoutInSeconds));
        }

        #region Integration  Test

        public bool LogInEmployee(IWebDriver webDriver, WebDriverWait wait, LoginDTO loginDTO)
        {
            bool result = true;
            try
            {
                webDriver.Navigate().GoToUrl("http://localhost:44339/Identity/Account/Login");
                webDriver.Manage().Window.Maximize();
                IWebElement webElement;
                Thread.Sleep(1000);

                // Username
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("username_input")));
                webElement = webDriver.FindElement(By.Id("username_input"));
                webElement.Clear();
                webDriver.FindElement(By.Id("username_input")).SendKeys(loginDTO.username);

                // password
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("password_input")));
                webElement = webDriver.FindElement(By.Id("password_input"));
                webElement.Clear();
                webDriver.FindElement(By.Id("password_input")).SendKeys(loginDTO.password);

                Thread.Sleep(1000);
                webDriver.FindElement(By.Id("submit_login")).Click();
                Thread.Sleep(5000);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("discort_elementMeni")));
                var element = webDriver.FindElement(By.Id("discort_elementMeni")).Displayed;
                if (element)
                {
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source + " - " + ex.Message + " - " + ex.StackTrace);
                return result;
            }
            finally
            {

            }

        }

        [Test]
        public async Task LoginTest_Valid()
        {
            LoginDTO loginDTO = new LoginDTO("zoranastamenkovic1998.com", "Koprivica123!");
            var results = LogInEmployee(_webDriver, _wait, loginDTO);
            Assert.IsTrue(results);
        }
        #endregion

        [TearDown]
        public void Dispose()
        {
            Thread.Sleep(2000);
            _context.Dispose();
            _webDriver.Quit();
        }
    }
}

