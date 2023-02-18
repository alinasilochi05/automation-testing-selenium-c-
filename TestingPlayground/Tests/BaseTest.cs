using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestingPlayground.Utils;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestingPlayground.Tests;

public class BaseTest
{
    protected IWebDriver chromeDriver;
    protected string siteUrl;
    protected LogInHandler logInHandler;
    private bool runLogin;
    protected bool isMaximized;

    public BaseTest()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--start-maximized");
        this.chromeDriver = new ChromeDriver(options);
        this.siteUrl = Urls.singIn;
        this.runLogin = true;
        this.logInHandler = new LogInHandler(chromeDriver);
     
        
    }

    public BaseTest(string siteUrl)
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("--start-maximized");
        this.chromeDriver = new ChromeDriver(options);
        this.siteUrl = siteUrl;
        this.runLogin = false;
    }

   [SetUp] 
   public void BaseSetUp()
    {
        this.chromeDriver.Navigate().GoToUrl(this.siteUrl);
        if(runLogin)
        {
            this.logInHandler.LogIn();
        }
     
    }

}
