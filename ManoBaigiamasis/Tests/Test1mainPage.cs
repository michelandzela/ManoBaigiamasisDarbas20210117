using AutoPaskaitos.ManoBaigiamasis.Pages;
using NUnit.Framework;

namespace AutoPaskaitos.ManoBaigiamasis.Tests
{
    class Test1mainPage : Basic
    {
        private MainPage mainPage;

        [SetUp]
        public void beforeEveryTest()
        {
            mainPage = new MainPage(driver);
        }

        [Test]
        public void LogIn()
        {
            mainPage
                .PressLogInButton()
                .WriteCorrectEmail()
                .WriteCorrectPassword()
                .PressPrisijungti()
                .CheckLogOutButton();
        }

        [Test]
        public void BadLogIn()
        {
            mainPage.PressLogInButton();
            mainPage.WriteBadEmail();
            mainPage.WriteCorrectPassword();
            mainPage.PressPrisijungti();
            mainPage.CheckFault();
        }

        [Test]
        public void BadPassword()
        {
            mainPage.PressLogInButton();
            mainPage.WriteCorrectEmail();
            mainPage.WriteBadPassword();
            mainPage.PressPrisijungti();
            mainPage.CheckWrongPassword();
        }
    }
}
