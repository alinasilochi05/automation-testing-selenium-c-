using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestingPlayground.Pages
{
    public class CategoryMenuPage
    {
         public IWebDriver chromeDriver;

       // [FindsBy(How = How.XPath, Using = "#categorymenu > nav > ul > li:nth-child(2) > a")]
       // public IWebElement Category;

        public CategoryMenuPage(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
            PageFactory.InitElements(chromeDriver, this);
        }

    

        public void hoverCategory(String text)
        {
            IList<IWebElement> categories = chromeDriver.FindElements(By.XPath("//*[@id=\"categorymenu\"]/nav/ul/li[2]/a"));
            foreach (IWebElement category in categories)
            {
                System.Console.WriteLine(category.Text);

                if (category.Text == text)
                { 
                    Actions action = new Actions(chromeDriver);
                   action.MoveToElement(category).Perform();
                  
                }
            }
        }

        public void clickOnSubCategory(String text)
        {
            IList<IWebElement> SubCategories = chromeDriver.FindElements(By.XPath("//*[@id=\"categorymenu\"]/nav/ul"));
            foreach (IWebElement SubCategory in SubCategories)
            {
                System.Console.WriteLine(SubCategory.Text);

                if (SubCategory.Text == text)
                {
                  SubCategory.Click();
                }
            }
        }
    }
}
