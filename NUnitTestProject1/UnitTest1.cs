using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitTestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()

        {
            // ����� �������
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            // ����� ������
        }
    }
}