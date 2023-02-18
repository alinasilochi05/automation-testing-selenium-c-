using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestingPlayground.Pages;
using TestingPlayground.Utils;

namespace TestingPlayground.Tests
{
    public class LogInTest : BaseTest
    {
        LogInPage logInPage;
        LogInHandler logInHandler;
       

        public LogInTest() : base(Urls.singIn)
        {
         this.logInPage = new LogInPage(this.chromeDriver);
         this.logInHandler = new LogInHandler(chromeDriver);   
        
        }

        [Test]
        public void GoToHomePage()
        {
            this.logInHandler.LogIn();
        }
       
       
    }
}
