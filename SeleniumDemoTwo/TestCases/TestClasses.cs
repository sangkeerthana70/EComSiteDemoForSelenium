using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumDemoTwo.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.TestCases
{
    class TestClasses
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();

            PropertiesCollection.Driver.Navigate().GoToUrl("http://demo.nopcommerce.com/computers");

            PropertiesCollection.Driver.Manage().Window.Maximize();

            PropertiesCollection.Driver.FindElement(By.ClassName("ico-login"));

            Console.WriteLine("Opened URL and clicked Login Page");
        }

        [Test]
        public void ExecuteTest()
        {
            Authentication authentication = new Authentication();


        }
    }
}
