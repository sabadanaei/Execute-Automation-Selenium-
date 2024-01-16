using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			IWebDriver driver =  new ChromeDriver();
			driver.Navigate().GoToUrl("https://www.google.com/");
			driver.Manage().Window.Maximize();
			IWebElement webElement = driver.FindElement(By.Id("W0wltc"));
			webElement.Click();
			IWebElement webElement1 = driver.FindElement(By.Name("q"));
			webElement1.SendKeys("selenium");
			webElement1.SendKeys(Keys.Return);
		}
	}
}