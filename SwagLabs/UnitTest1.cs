using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SwagLabs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("log4Net")]
        public void TestMethod001()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
            string actualText = driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
        }
        [TestMethod]
        [TestCategory("log4Net")]
        public void TestMethod002()
        {
            //This is a test method
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
            var select = driver.FindElement(By.ClassName("product_sort_container"));
            var selectDropDown = new SelectElement(select);
            selectDropDown.SelectByValue("lohi");
            driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie")).Click();
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            driver.FindElement(By.Id("checkout")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("Aarish");
            driver.FindElement(By.Id("last-name")).SendKeys("Irfan");
            driver.FindElement(By.Id("postal-code")).SendKeys("75280");
            driver.FindElement(By.Id("continue")).Click();
            driver.FindElement(By.Id("finish")).Click();
            string actualText = driver.FindElement(By.ClassName("complete-header")).Text;
            Assert.AreEqual("Thank you for your order!", actualText);
            driver.FindElement(By.Id("back-to-products")).Click();
            driver.Close();
        }
    }
}
