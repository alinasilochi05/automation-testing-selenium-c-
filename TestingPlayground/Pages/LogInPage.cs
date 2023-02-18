using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPlayground.Pages
{
    public class LogInPage
    {
         public IWebDriver chromeDriver;

        [FindsBy(How = How.Id, Using = "loginFrm_loginname")]
        public IWebElement LoginInput;

        [FindsBy(How = How.Id, Using = "loginFrm_password")]
        public IWebElement PasswordInput;

        [FindsBy(How = How.CssSelector, Using = "#loginFrm>fieldset>button")]
        public IWebElement LoginButton;




        public LogInPage(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
            PageFactory.InitElements(chromeDriver, this);
            
        }

        public void SetUsernameInput(string username)
        {
            LoginInput.SendKeys(username);
        }
        public void SetPasswordInput(string password)
        {
           PasswordInput.SendKeys(password);
        }

    public void clickLoginButton()
        {
            LoginButton.Click();
        }
    }
}
