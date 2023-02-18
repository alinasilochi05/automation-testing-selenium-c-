using TestingPlayground.Pages;

namespace TestingPlayground.Tests
{
    public class CategoryMenuTest : BaseTest
    {
        CategoryMenuPage categoryMenuPage;
        public CategoryMenuTest() : base()
        {
            this.categoryMenuPage = new CategoryMenuPage(chromeDriver);
        }



        [Test]
        public void openAccesoriesCategory()
        {
            this.categoryMenuPage.hoverCategory("APPAREL & ACCESSORIES");
            this.categoryMenuPage.clickOnSubCategory("Shoes");
        }
    }
}
