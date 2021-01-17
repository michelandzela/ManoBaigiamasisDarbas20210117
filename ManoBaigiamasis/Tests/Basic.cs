using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace AutoPaskaitos.ManoBaigiamasis.Tests
{
    class Basic
    {
        public IWebDriver driver;

        [SetUp]

        public void BeforeEveryTest()
        {
            GiveDriver("chrome");
            driver.Url = "https://www.biomedikoscentras.lt/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void GiveDriver(string driverName)
        {
            if (driverName == "chrome")
            {
                driver = new ChromeDriver();
            }
            if (driverName == "firefox")
            {
                driver = new FirefoxDriver();
            }
        }
       
        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}
