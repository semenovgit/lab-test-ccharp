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
            // перед тестами
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("http://www.cian.ru");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            // после тестов
        }
    }
}