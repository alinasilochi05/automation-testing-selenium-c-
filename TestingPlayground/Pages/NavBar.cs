using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPlayground.Pages
{
    public class NavBar
    {
        IWebDriver chromeDriver;

        [FindsBy(How = How.ClassName, Using = "logo")]
        public IWebElement logo;
        [FindsBy(How = How.Id, Using = "filter_keyword")]
        public IWebElement searchInput;
        [FindsBy(How = How.CssSelector, Using = "#main_menu_top > li:nth-child(3) > a")]
        public IWebElement cartButton;
        [FindsBy(How = How.CssSelector, Using = "#main_menu_top > li:nth-child(4) > a")]
        public IWebElement checkoutButton;
        [FindsBy(How = How.CssSelector, Using = "body > div > header > div.container-fluid > div > div.block_6 > ul > li > a")]
        public IWebElement currency;
        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/div/div[2]/ul/li/ul/li[1]/a")]
        public IWebElement euroCurrency;

      


        public NavBar(IWebDriver chromeDriver)
        {
        this.chromeDriver = chromeDriver;
            PageFactory.InitElements(chromeDriver, this);
        }

        public void clickOnLogo()
        {
            logo.Click();
        }

        public void setSearchInput(String searchedText)
        {
            searchInput.SendKeys(searchedText);
            searchInput.SendKeys(Keys.Enter);
        }
        public void clickOnCartButton()
        {
            cartButton.Click();
        }

        public void clickOnCheckoutButton()
        {
            checkoutButton.Click();
        }

        public void hoverOverCurrency()
        {
            Actions action = new Actions(chromeDriver);
            action.MoveToElement(currency).Perform();
        }

        public void clickOnEuro()
        {
            euroCurrency.Click();
        }
        public String getTitle()
        {
            return chromeDriver.FindElement(By.CssSelector("#product_details > div > div:nth-child(2) > div > div > h1 > span")).Text;
        }
    }
}
