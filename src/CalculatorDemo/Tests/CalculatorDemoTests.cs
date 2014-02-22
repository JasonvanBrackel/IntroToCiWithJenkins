using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Tests
{
    [TestFixture]
    public class CalculatorDemoTests
    {
        private IWebDriver _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"),
                                                         DesiredCapabilities.Firefox());

        [SetUp]
        public void OpenCalculator()
        {
            _driver.Url = "http://apps.apprenda.jason/calculator--v1/";
        }

        [Test]
        public void Clicking_Button_1_Should_Append_1_to_the_Display()
        {
            TestNumber("1");
        }

        [Test]
        public void Clicking_Button_2_Should_Append_2_to_the_Display()
        {
            TestNumber("2");
        }

        [Test]
        public void Clicking_Button_3_Should_Append_3_to_the_Display()
        {
            TestNumber("3");
        }

        [Test]
        public void Clicking_Button_4_Should_Append_4_to_the_Display()
        {
            TestNumber("4");
        }

        [Test]
        public void Clicking_Button_5_Should_Append_5_to_the_Display()
        {
            TestNumber("5");
        }

        [Test]
        public void Clicking_Button_6_Should_Append_6_to_the_Display()
        {
            TestNumber("6");
        }
        
        [Test]
        public void Clicking_Button_7_Should_Append_7_to_the_Display()
        {
            TestNumber("7");
        }

        [Test]
        public void Clicking_Button_8_Should_Append_8_to_the_Display()
        {
            TestNumber("8");
        }

        [Test]
        public void Clicking_Button_9_Should_Append_9_to_the_Display()
        {
            TestNumber("9");
        }

        [Test]
        public void Clicking_Clear_Button_Should_Clear_Display()
        {
            _driver.FindElement(By.Id("clear")).Click();

            Assert.AreEqual(string.Empty, _driver.FindElement(By.CssSelector("div#display")).Text);
        }

        
        private void TestNumber(string number)
        {
            _driver.FindElement(By.Id(number)).Click();

            Assert.AreEqual(number, _driver.FindElement(By.CssSelector("div#display")).Text);
        }

        [TestFixtureTearDown]
        public void Close()
        {
            _driver.Close();
        }
    }

}