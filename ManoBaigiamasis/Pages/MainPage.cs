using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoPaskaitos.ManoBaigiamasis.Pages
{
    class MainPage : BasicPages
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        private IWebElement logInButton => driver.FindElement(By.CssSelector("#masthead > div.header-inner.flex-row.container.logo-center.medium-logo-center > div.flex-col.hide-for-medium.flex-right > ul > li.account-item.has-icon > a > i"));
        private IWebElement emailBox => driver.FindElement(By.Id("username"));
        private IWebElement password => driver.FindElement(By.Id("password"));
        private IWebElement logIn => driver.FindElement(By.Name("login"));
        private IWebElement faultEmail => driver.FindElement(By.CssSelector(".woocommerce-error > li"));
        private IWebElement wrongPassword => driver.FindElement(By.CssSelector(".woocommerce-error > li"));
        
        public MainPage PressLogInButton()
        {
            logInButton.Click();
            return this; // panaudojau ir return this
        }
        public MainPage WriteCorrectEmail()
        {
            string email = "j.michalcenko@gmail.com";
            emailBox.SendKeys(email);
            return this;
        }
        public MainPage WriteCorrectPassword()
        {
            string mypassword = "AutoTestavimas2020";
            password.SendKeys(mypassword);
            return this;
        }
        public MainPage PressPrisijungti()
        {
            logIn.Click();
            return this;
        }
        public void WriteBadEmail() // naudojau per voida, kad nenaudoti - return this. Man priimtinesnis void panaudojimas.
        {
            string bademail = "something";
            emailBox.SendKeys(bademail);
        }
        public void WriteBadPassword()
        {
            string badpassword = "badpassword";
            password.SendKeys(badpassword);
        }
        public void CheckFault()
        {
            Assert.AreEqual("KLAIDA: Netinkamas vartotojo vardas. Pamiršote slaptažodį?", faultEmail.Text);
        }
        public void CheckWrongPassword()
        {
            Assert.AreEqual("KLAIDA: Įvestas slaptažodis el pašto adresui j.michalcenko@gmail.com yra neteisingas. Pamiršote slaptažodį?", wrongPassword.Text); // del sitos
        }
        public void CheckLogOutButton()
        {
            Assert.IsNotNull(driver.FindElement(By.CssSelector("#masthead > div.header-inner.flex-row.container.logo-center.medium-logo-center > div.flex-col.hide-for-medium.flex-right > ul > li.account-item.has-icon.has-dropdown > ul > li.woocommerce-MyAccount-navigation-link.woocommerce-MyAccount-navigation-link--customer-logout > a")));
        }
    }
}
