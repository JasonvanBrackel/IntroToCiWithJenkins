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
        public void Button_1_Should_Append_1_to_the_Display()
        {
            TestNumber("1");
        }

        [Test]
        public void Button_2_Should_Append_2_to_the_Display()
        {
            TestNumber("2");
        }

        [Test]
        public void Button_3_Should_Append_3_to_the_Display()
        {
            TestNumber("3");
        }

        [Test]
        public void Button_4_Should_Append_4_to_the_Display()
        {
            TestNumber("4");
        }

        [Test]
        public void Button_5_Should_Append_5_to_the_Display()
        {
            TestNumber("5");
        }

        [Test]
        public void Button_6_Should_Append_6_to_the_Display()
        {
            TestNumber("6");
        }
        
        [Test]
        public void Button_7_Should_Append_7_to_the_Display()
        {
            TestNumber("7");
        }

        [Test]
        public void Button_8_Should_Append_8_to_the_Display()
        {
            TestNumber("8");
        }

        [Test]
        public void Button_9_Should_Append_9_to_the_Display()
        {
            TestNumber("9");
        }

        [Test]
        [Ignore]
        public void Clear_Button_Should_Clear_Display()
        {
            TestNumber("clear");
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