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
            //click login on welcome page
            PropertiesCollection.Driver.FindElement(By.ClassName("ico-login"));

            Console.WriteLine("Opened URL and clicked Welcome Page");
        }

        [Test]
        public void TestRegisterSuccess()
        {

            WelcomePage welcome = new WelcomePage();
            Console.WriteLine("Click to register");
            RegisterPage register = welcome.Register();
            IWebElement BtnContinue = register.Register("Anu", "Sang", 11, "December", 2002, "pop@123.com", "@nuK1978");
            Assert.IsFalse(BtnContinue == null);
        }

        [Test]
        public void TestRegisterExistingEmail()
        {
            WelcomePage welcome = new WelcomePage();
            Console.WriteLine("Click to register");
            RegisterPage register = welcome.Register();
            IWebElement BtnContinue = register.Register("", "Sang", 11, "December", 2002, "abd@123.com", "@nuK1978");
            Assert.IsTrue(BtnContinue == null);

            //Console.WriteLine("The Specified email already exists");
            IWebElement errorMessage = PropertiesCollection.Driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div/div/div/div[2]/form/div[1]/ul/li"));
            Console.WriteLine(errorMessage);
            Boolean Message = errorMessage.Text.Contains("The specified email already exists");
            Console.WriteLine(Message);
            Assert.IsTrue(Message);
        }

        [Test]
        public void TestRegisterRequiredElements()
        {
            WelcomePage welcome = new WelcomePage();
            Console.WriteLine("Click to register");
            RegisterPage register = welcome.Register();
            IWebElement BtnContinue = register.Register("Anu", "Sang", 11, "December", 2002, "abd@123.com", "@nuK1978");
            Assert.IsTrue(BtnContinue == null);
        }

        [Test]
        public void LoginReturningCustomer()
        { 
            //click login for returning customer
            PropertiesCollection.Driver.FindElement(By.ClassName("ico-login"));
            System.Threading.Thread.Sleep(5000);
            WelcomePage welcome = new WelcomePage();

            welcome.Login("asangeethu@yahoo.com", "@nuK1978");
            Console.WriteLine("Login done");
        }

        [Test]
        public void TestCheckRequiredFieldsForRegister()
        {

        }
        /*
        [Test]
        public void Re-Register()
        {
            WelcomePage welcome = new WelcomePage();
            RegisterPage register = welcome.Register();
            MyAccountpage login = register.Register("Anu", "Sang", 11, "December", 2002, "asangeethu@yahoo.com", "@nuK1978");

        }
        */
        
    }
}
