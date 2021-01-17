using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoPaskaitos.ManoBaigiamasis.Pages
{
    class EShopPage : BasicPages
    {
        public EShopPage(IWebDriver driver) : base(driver) { }

        private IWebElement eShopButton => driver.FindElement(By.ClassName("nav-top-link"));
        private IWebElement eShopWritten => driver.FindElement(By.ClassName("shop-page-title"));
        private IWebElement apsauginesPrekesLeft => driver.FindElement(By.LinkText("Apsauginės prekės"));
        private IWebElement apsauginesPrekesCenter => driver.FindElement(By.ClassName("col-inner"));
        private IWebElement homePageButton => driver.FindElement(By.Id("logo"));

        public void PressEshopButton()
        {
            eShopButton.Click();
        }
        public void CheckEshopOpen()
        {
            Assert.IsTrue(eShopWritten.Displayed);
        }
        public void PressApsauginesPrekesLeftSide()
        {
            apsauginesPrekesLeft.Click();
        }
        public void CheckApsauginesPrekesDesplayed()
        {
            Assert.AreEqual("https://www.biomedikoscentras.lt/kategorija/medicinines-prekes/", driver.Url);
        }
        public void PressApsauginesPrekesCenter()
        {
            apsauginesPrekesCenter.Click();
        }
        public void CheckApsauginesPrekesCenterDesplayed()
        {
            Assert.AreEqual("https://www.biomedikoscentras.lt/kategorija/medicinines-prekes/", driver.Url);
        }
        public void HomeButton()
        {
            homePageButton.Click();
        }
        public void TestHomeButton()
        {
            Assert.AreEqual("https://www.biomedikoscentras.lt/", driver.Url);
        }
    }
}
