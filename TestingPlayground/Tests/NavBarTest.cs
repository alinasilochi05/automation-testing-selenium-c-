using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPlayground.Pages;

namespace TestingPlayground.Tests
{
    
    public class NavBarTest : BaseTest
    {
        NavBar navBar;
        public NavBarTest() : base()
        {
         this.navBar  = new NavBar(chromeDriver);
        }

        [Test]
        public void goToHomePageFromLogo()
        {
            this.navBar.clickOnLogo();
            Assert.That(chromeDriver.Title, Is.EqualTo("A place to practice your automation skills!"));
        }

        [Test]
        public void searchKeyword()
        {
            this.navBar.setSearchInput("lips");
            String actualTitle = this.navBar.getTitle();
            Assert.True(actualTitle.Contains("Lips"));
        }

        [Test]
        public void openCart()
        {
            this.navBar.clickOnCartButton();
        }

        [Test]
        public void openCheckout()
        {
            this.navBar.clickOnCheckoutButton();
        }

        [Test]
        public void selectEuroCurrency()
        {
            this.navBar.hoverOverCurrency();
            this.navBar.clickOnEuro();
        }
    }
}
