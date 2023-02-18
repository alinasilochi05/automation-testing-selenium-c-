using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPlayground.Pages
{
    public class CreateAccountPage
    {
        IWebDriver chromeDriver;
        [FindsBy(How = How.Id, Using = "AccountFrm_firstname")]
        public IWebElement FirstNameInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_lastname")]
        public IWebElement LastNameInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_email")]
        public IWebElement EmailInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_address_1")]
        public IWebElement AddressInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_city")]
        public IWebElement CityInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_zone_id")]
        public IWebElement RegionInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_postcode")]
        public IWebElement ZipInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_country_id")]
        public IWebElement CountryInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_loginname")]
        public IWebElement LoginNameInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_password")]
        public IWebElement PasswordInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_confirm")]
        public IWebElement ConfirmInput;

        [FindsBy(How = How.Id, Using = "AccountFrm_agree")]
        public IWebElement AgreeCheckbox;

        public CreateAccountPage (IWebDriver chromeDriver)
        {
         this.chromeDriver = chromeDriver;
         PageFactory.InitElements(chromeDriver, this);
        }

        public void setFirstNameInput(String firstName)
        {
        FirstNameInput.SendKeys(firstName);
        }

        public void setLastNameInput(String lastName) 
        {
            LastNameInput.SendKeys(lastName); 
        }
        public void setEmailInput(String email) { EmailInput.SendKeys(email); }
       
        public void setAddress(String address) { AddressInput.SendKeys(address); }
        public void setCityInput(String city) { CityInput.SendKeys(city); }
        public void setRegionInput() 
        {
            
        }
        public void setZipCode(String zip) { ZipInput.SendKeys(zip); }
        public void setLoginName(String loginName) { LoginNameInput.SendKeys(loginName); }
        public void setPasswordInput(String password) { PasswordInput.SendKeys(password); }
        public void setConfirmInput(String confirm) { ConfirmInput.SendKeys(confirm); }   
    }
}
