using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPlayground.Pages;

namespace TestingPlayground.Utils
{
    public class LogInHandler
    {
        LogInPage logInPage;
        public LogInHandler(IWebDriver chromeDriver)
        {
            this.logInPage = new LogInPage(chromeDriver);
        }

        public void LogIn()
        {
         this.logInPage.SetUsernameInput("gloria");
         this.logInPage.SetPasswordInput("pass");
         this.logInPage.clickLoginButton();
        }
    }
}
