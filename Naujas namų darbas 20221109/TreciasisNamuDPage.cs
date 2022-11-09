using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
namespace ClassLibrary1.Page
{

    public class CheckBoxObjectPage : BasePage
    {
        private /*kintamasis*/ const string pageUrl = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
        private IWebElement oneCheckBox => Driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement resultElement => Driver.FindElement(By.Id("txtAge"));
        private IWebElement button => Driver.FindElement(By.CssSelector("#check1"));
        private IReadOnlyCollection<IWebElement> GetCheckboxesCollection => Driver.FindElements(By.CssSelector(".cb1-element"));

        public CheckBoxObjectPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != pageUrl)
            {
                Driver.Url = pageUrl;
            }
        }

        public void FirstMethodOneCheckBox()
        {
            if (!oneCheckBox.Selected)
            {
                oneCheckBox.Click();
            }
        }

        public void FirstVerifyResult()
        {
            Assert.AreEqual("Success - Check box is checked", resultElement.Text, "Result text is wrong");
        }


        public void SecondMethodCheckAllBoxes()
        {
            foreach (IWebElement checkbox in GetCheckboxesCollection)
            {
                if (!checkbox.Selected)
                {
                    button.Click();
                }
            }
        }
        public void SecondVerifyResult(string value)
        {
            Assert.IsTrue(value.Equals(button.GetAttribute("value")), "Button value is not correct");
        }
        public void ThirdMethodCheckBoxes()
        {
            button.Click();
        }

        public void ThirdVerifyResult()
        {
            foreach (IWebElement checkbox in GetCheckboxesCollection)
            {
                Assert.That(!checkbox.Selected, "Check box was not unselected");
            }

        }
    }
}



