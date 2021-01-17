using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoPaskaitos.ManoBaigiamasis.Pages
{
    class CartPage : BasicPages
    {
        public CartPage(IWebDriver driver) : base(driver) { }

        private IWebElement eShopButton2 => driver.FindElement(By.ClassName("nav-top-link"));
        private IWebElement apsauginesPrekesLeft2 => driver.FindElement(By.LinkText("Apsauginės prekės"));
        private IWebElement itemApsauginesKaukes => driver.FindElement(By.CssSelector(".product-small:nth-child(1) .attachment-woocommerce_thumbnail"));
        private IWebElement apsauginesKaukes => driver.FindElement(By.CssSelector("#product-10653 > div.product-container > div.product-main > div > div.product-info.summary.col-fit.col.entry-summary.product-summary > h1"));
        private IWebElement iKrepseli => driver.FindElement(By.Name("add-to-cart"));
        private IWebElement perzuretiKrepseli => driver.FindElement(By.ClassName("header-cart-title"));
        private IWebElement checkCartContain => driver.FindElement(By.CssSelector("#main > div.cart-container.container.page-wrapper.page-checkout > div > div.woocommerce.row > form > div > table > tbody > tr.cart_item > td.product-name > a"));
        private IWebElement pressCheckout => driver.FindElement(By.ClassName("wc-proceed-to-checkout"));
        private IWebElement presentAtsiskaitymas => driver.FindElement(By.ClassName("current"));
        public void PressEshopButton2()
        {
            eShopButton2.Click();
        }
        public void PressApsauginesPrekesLeftSide2()
        {
            apsauginesPrekesLeft2.Click();
        }
        public void PressApsauginesKaukes()
        {
            itemApsauginesKaukes.Click();
        } 
        public void CheckApsauginesKaukesDesplayed()
        {
            Assert.AreEqual("Apsauginė medicininė kaukė (50 vnt.)", apsauginesKaukes.Text);
        }
        public void PressIkrepseli()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 1600)");
            iKrepseli.Click();
            perzuretiKrepseli.Click();
        }
        public void CheckCartContain()
        {
            Assert.AreEqual("Apsauginė medicininė kaukė (50 vnt.)", checkCartContain.Text);
        }
        public void PressCheckout()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 1000)");
            pressCheckout.Click();
        }
        public void PresentAtsiskaitymas()
        {
            Assert.IsTrue(presentAtsiskaitymas.Displayed);
        }
    }
}
