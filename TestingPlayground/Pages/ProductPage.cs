using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestingPlayground.Pages
{
    public class ProductPage
    {
       public  IWebDriver chromeDriver;


        [FindsBy(How = How.CssSelector, Using = "#maincontainer > div > div > div > div > div.thumbnails.grid.row.list-inline > div:nth-child")]

        public IWebElement Product;

        [FindsBy(How = How.XPath, Using = "//a[@title='Add to Cart']")]
       
       public IWebElement CartButton;


       public ProductPage(IWebDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
            PageFactory.InitElements(chromeDriver, this);
     
        }

        public void ClickAddToCart()
        {
        IList<IWebElement> elements = chromeDriver.FindElements(By.XPath("//*[@id=\"maincontainer\"]/div/div/div/div/div[2]"));
        foreach(IWebElement element in elements)
        {
                if (element.Text == "Add To Cart")
                {
                    element.Click();
                }
        }
    }

}
}
