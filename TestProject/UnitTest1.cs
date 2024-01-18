using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://www.google.com/");
			driver.Manage().Window.Maximize();
			IWebElement webElement = driver.FindElement(By.Id("W0wltc"));
			webElement.Click();
			IWebElement webElement1 = driver.FindElement(By.Name("q"));
			webElement1.SendKeys("selenium");
			webElement1.SendKeys(Keys.Return);
		}

		[Test]
		public void EaWebSiteTest()
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl("http://eaapp.somee.com/");
			IWebElement LoginLink = driver.FindElement(By.Id("loginLink"));
			LoginLink.Click();
			IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
			txtUserName.SendKeys("admin");
			IWebElement txtPassword = driver.FindElement(By.Name("Password"));
			txtPassword.SendKeys("password");
			//IWebElement btnLogin = driver.FindElement(By.ClassName("btn"));
			IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn"));

			btnLogin.Submit();

		}

		[Test]
		public void EaWebSiteTestReduced()
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl("http://eaapp.somee.com/");
			driver.FindElement(By.Id("loginLink")).Click();
			driver.FindElement(By.Name("UserName")).SendKeys("admin");
			driver.FindElement(By.Name("Password")).SendKeys("password");

			//IWebElement btnLogin = driver.FindElement(By.ClassName("btn"));
			driver.FindElement(By.CssSelector(".btn")).Submit();

		}

		[Test]
		public void WrokingWithAdvancedControls ()
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://play1.automationcamp.ir/forms.html");

			SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("select_tool")));
			selectElement.SelectByText("Protractor");

			SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id("select_lang")));
			multiSelect.SelectByValue("java");
			multiSelect.SelectByValue("python");

			IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;
			foreach (IWebElement option in selectedOption)
			{
				Console.WriteLine(option.Text);
			}
		}
	}
}