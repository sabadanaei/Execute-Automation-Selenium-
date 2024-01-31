using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class SeleniumCustomMethod
	{
		public static void click(IWebDriver driver, By locator)
		{
			driver.FindElement(locator).Click();
		}

		public static void EnterText(IWebDriver driver, By locator, string text)
		{
			driver.FindElement(locator).Clear();
			driver.FindElement(locator).SendKeys(text);
		}

		public static void Submit(IWebDriver driver, By locator)
		{
			driver.FindElement(locator).Submit();
		}

		public static void SelectdDropDownByText(IWebDriver driver, By locator, string text)
		{
			SelectElement selectElement = new SelectElement(driver.FindElement(locator));
			selectElement.SelectByText(text);
		}

		public static void SelectdDropDownByValue(IWebDriver driver, By locator, string value)
		{
			SelectElement selectElement = new SelectElement(driver.FindElement(locator));
			selectElement.SelectByValue(value);
		}

		public static void multiSelect(IWebDriver driver, By locator, string[] values)
		{
			SelectElement selectElement = new SelectElement(driver.FindElement(locator));
			foreach (var value in values)
			{
				selectElement.SelectByText(value);
			}
		}

		public static List<string> ShowSelectedList(IWebDriver driver, By locator)
		{
			List<string> options = new List<string>();
			SelectElement selectElement = new SelectElement(driver.FindElement(locator));

			IList<IWebElement> selectedOption = selectElement.AllSelectedOptions;
			foreach (IWebElement option in selectedOption)
			{
				options.Add(option.Text);
				
			}
			return options;
		}
	}
}
