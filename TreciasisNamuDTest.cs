using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ClassLibrary1.Test
{
    public class CheckBoxObjectTest
    {
        private static IWebDriver chromeDriver;
        private static CheckBoxObjectPage page;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            chromeDriver = new ChromeDriver();
            page = new CheckBoxObjectPage(chromeDriver);
            chromeDriver.Url = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        //[OneTimeTearDown]
        //public static void OneTimeTearDown()
        //{
        //    chromeDriver.Quit();
        //}

        [Test]
        public static void TestFirstInput()
        {
            page.NavigateToPage();
            page.FirstMethodOneCheckBox();
            page.FirstVerifyResult();

        }
        [Test]
        public static void CheckAllBoxesTest()
        {
            page.NavigateToPage();
            page.SecondMethodCheckAllBoxes();
            page.SecondVerifyResult("Uncheck All");
        }
        [Test]
        public static void UncheckAllCheckboxesTest()
        {
            page.NavigateToPage();
            page.SecondMethodCheckAllBoxes();
            page.ThirdMethodCheckBoxes();
            page.SecondVerifyResult("Check All");
            page.ThirdVerifyResult();


        }




    }

}

