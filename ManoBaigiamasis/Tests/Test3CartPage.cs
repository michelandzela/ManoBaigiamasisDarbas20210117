using AutoPaskaitos.ManoBaigiamasis.Pages;
using NUnit.Framework;

namespace AutoPaskaitos.ManoBaigiamasis.Tests
{
    class Test3CartPage : Basic
    {
        private CartPage cartPage;

        [SetUp]
        public void beforeEveryTests()
        {
            cartPage = new CartPage(driver);
            cartPage.PressEshopButton2();
            cartPage.PressApsauginesPrekesLeftSide2();
            cartPage.PressApsauginesKaukes();
        }

        [Test]
        public void ShoppingSelection()
        {
            cartPage.CheckApsauginesKaukesDesplayed();
        }
        [Test]
        public void ShoppingCart()
        {
            cartPage.PressIkrepseli();
            cartPage.CheckCartContain();
        }
        [Test]
        public void Checkout()
        {
            cartPage.PressIkrepseli();
            cartPage.PressCheckout();
            cartPage.PresentAtsiskaitymas();
        }
    }
}
