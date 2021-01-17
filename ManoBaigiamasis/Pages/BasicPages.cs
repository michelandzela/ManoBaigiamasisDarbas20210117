using OpenQA.Selenium;

namespace AutoPaskaitos.ManoBaigiamasis.Pages
{
    public class BasicPages
    {
        protected IWebDriver driver;
        
        public BasicPages(IWebDriver driver)
        {
            this.driver = driver;
        } 
    }
}
