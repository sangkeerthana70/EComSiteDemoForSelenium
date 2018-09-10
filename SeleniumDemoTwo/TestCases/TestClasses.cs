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

            PropertiesCollection.Driver.Navigate().GoToUrl("http://demo.nopcommerce.com");

            PropertiesCollection.Driver.Manage().Window.Maximize();

            PropertiesCollection.Driver.FindElement(By.ClassName("ico-login"));

            Console.WriteLine("Opened URL and clicked Login Page");
        }

        [Test]
        public void ExecuteTest()
        {
            
            WelcomePage welcome = new WelcomePage();
            Console.WriteLine("Click to register");
            RegisterPage register = welcome.Register();
            MyAccountPage login = register.Register("Anu", "Sang", 11, "December", 2002, "asangeethu@yahoo.com","@nuK1978");
            Console.WriteLine("Registration done");
            PropertiesCollection.Driver.FindElement(By.ClassName("ico-login"));
            System.Threading.Thread.Sleep(5000);
            welcome = new WelcomePage();
            login.Login("asangeethu@yahoo.com", "@nuK1978");
            Console.WriteLine("Login done");
        }
    }
}
