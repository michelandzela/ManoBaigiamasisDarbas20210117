using AutoPaskaitos.ManoBaigiamasis.Pages;
using NUnit.Framework;

namespace AutoPaskaitos.ManoBaigiamasis.Tests
{
    class Test2eshop : Basic
    {
       private EShopPage eShopPage;

        [SetUp]

        public void BeforeEveryTestTwo()
        {
            eShopPage = new EShopPage(driver);
            eShopPage.PressEshopButton();
        }

        [Test]
        public void TestEShopOpen()
        {
            eShopPage.CheckEshopOpen();
        }

        [Test]
        public void TestPressApsauginesPrekesLeft()
        {
            eShopPage.PressApsauginesPrekesLeftSide();
            eShopPage.CheckApsauginesPrekesDesplayed();
        }

        [Test]
        public void TestPressApsauginesPrekesCenter()
        {
            eShopPage.PressApsauginesPrekesCenter();
            eShopPage.CheckApsauginesPrekesCenterDesplayed();
        }

        [Test]
        public void CheckReturnToHomePage()
        {
            eShopPage.HomeButton();
            eShopPage.TestHomeButton();
        }
    }
}
