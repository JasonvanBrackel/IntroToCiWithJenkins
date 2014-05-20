using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Tests
{
    [TestFixture]
    public class CalculatorDemoTests
    {
        private readonly IWebDriver _driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Firefox());

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
        public void Clicking_Button_0_Should_Append_9_to_the_Display()
        {
            TestNumber("0");
        }

        [Test]
        public void Typing_1_Should_Append_1_to_the_Display()
        {
            TestTypedNumber("1");
        }

        [Test]
        public void Typing_2_Should_Append_2_to_the_Display()
        {
            TestTypedNumber("2");
        }

        [Test]
        public void Typing_3_Should_Append_3_to_the_Display()
        {
            TestTypedNumber("3");
        }

        [Test]
        public void Typing_4_Should_Append_4_to_the_Display()
        {
            TestTypedNumber("4");
        }

        [Test]
        public void Typing_5_Should_Append_5_to_the_Display()
        {
            TestTypedNumber("5");
        }

        [Test]
        public void Typing_6_Should_Append_6_to_the_Display()
        {
            TestTypedNumber("6");
        }

        [Test]
        public void Typing_7_Should_Append_7_to_the_Display()
        {
            TestTypedNumber("7");
        }

        [Test]
        public void Typing_8_Should_Append_8_to_the_Display()
        {
            TestTypedNumber("8");
        }

        [Test]
        public void Typing_9_Should_Append_9_to_the_Display()
        {
            TestTypedNumber("9");
        }

        [Test]
        public void Typing_0_Should_Append_0_to_the_Display()
        {
            TestTypedNumber("0");
        }

        [Test]
        public void Clicking_Clear_Button_Should_Clear_Display()
        {
            _driver.FindElement(By.Id("clear")).Click();

            Assert.AreEqual(string.Empty, _driver.FindElement(By.CssSelector("div#display")).Text);
        }

        private void TestTypedNumber(string typedKey)
        {
           _driver.FindElement(By.TagName("body")).SendKeys(typedKey);
        }

        [Test]
        public void Adding_two_numbers_should_give_a_correct_result()
        {
            TestMath(3, 2, "plus", 5);
        }

        [Test]
        public void Subtracting_two_numbers_should_give_a_correct_result()
        {
            TestMath(3, 2, "-", 1);
        }

        [Test]
        public void Multiplying_two_numbers_should_give_a_correct_result()
        {
            TestMath(3, 2, "multiply", 6);
        }

        [Test]
        public void Dividing_two_numbers_should_give_a_correct_result()
        {
            TestMath(3, 2, "divide", 1.5);
        }

        private void TestMath(double leftOperand, double rightOperand, string @operator, double expectedResult)
        {
            _driver.FindElement(By.Id(leftOperand.ToString())).Click();
            _driver.FindElement(By.Id(@operator)).Click();
            _driver.FindElement(By.Id(rightOperand.ToString())).Click();
            _driver.FindElement(By.Id("equals")).Click();
            Assert.AreEqual(expectedResult.ToString(), _driver.FindElement(By.CssSelector("div#display")).Text);
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