using OpenQA.Selenium;

namespace ClassLibrary1.Page
{
    public class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }




    }
}


