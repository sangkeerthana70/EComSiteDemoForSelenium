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
            PropertiesCollection.Driver.FindElement(By.ClassName("ico-login")).Click();

            Console.WriteLine("Opened URL and clicked Welcome Page");
        }

        [Test]
        public void TestRegisterSuccess()
        {

            WelcomePage welcome = new WelcomePage();
            Console.WriteLine("Click to register");
            RegisterPage register = welcome.Register();
            IWebElement BtnContinue = register.Register("Anu", "Sang", 11, "December", 2002, "tom@123.com", "@nuK1978");
            Assert.IsFalse(BtnContinue == null);
        }

        [Test]
        public void TestRegisterExistingEmail()
        {
            WelcomePage welcome = new WelcomePage();
            Console.WriteLine("Click to register");
            RegisterPage register = welcome.Register();
            IWebElement BtnContinue = register.Register("Anu", "Sang", 11, "December", 2002, "abd@123.com", "@nuK1978");
            Assert.IsTrue(BtnContinue == null);

            //Console.WriteLine("The Specified email already exists");
            IWebElement errorMessage = PropertiesCollection.Driver.FindElement(By.XPath("/html/body/div[6]/div[3]/div/div/div/div[2]/form/div[1]/ul/li"));
            Console.WriteLine(errorMessage);
            Boolean Message = errorMessage.Text.Contains("The specified email already exists");
            Console.WriteLine(Message);
            Assert.IsTrue(Message);
        }

        [Test]
        public void TestRegisterRequiredElement()
        {
            // Console.ReadLine();
            Console.WriteLine("1.Test to check if First name field is empty");
            WelcomePage welcome = new WelcomePage();
            Console.WriteLine("Click to register");
            RegisterPage register = welcome.Register();
            IWebElement BtnContinue = register.Register("", "Sang", 11, "December", 2002, "abd@123.com", "@nuK1978");
            Assert.IsTrue(BtnContinue == null);

            Console.WriteLine("First name is required.");
            IWebElement reqFirstName = PropertiesCollection.Driver.FindElement(By.Id("FirstName-error"));
            Console.WriteLine(reqFirstName);
            Boolean FNMessage = reqFirstName.Text.Contains("First name is required.");
            Console.WriteLine(FNMessage);
            Assert.IsTrue(FNMessage);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("2.Test to Check if Last Name field is empty");
            welcome = new WelcomePage();
            Console.WriteLine("Click to register");
            register = welcome.Register();
            BtnContinue = register.Register("Anu", "", 11, "December", 2002, "abd@123.com", "@nuK1978");
            Assert.IsTrue(BtnContinue == null);

            Console.WriteLine("Last name is required.");
            IWebElement reqLastName = PropertiesCollection.Driver.FindElement(By.Id("LastName-error"));
            Console.WriteLine(reqLastName);
            Boolean LNMessage = reqLastName.Text.Contains("Last name is required.");
            Console.WriteLine(LNMessage);
            Assert.IsTrue(LNMessage);
            
            Console.WriteLine("****************************************************************");
            Console.WriteLine("3.Check for empty email field");
            welcome = new WelcomePage();
            register = welcome.Register();
            BtnContinue = register.Register("Anu", "Sang", 11, "December", 2002, "", "@nuK1978");

            Console.WriteLine("Email is required.");
            IWebElement reqEmailField = PropertiesCollection.Driver.FindElement(By.Id("Email-error"));
            Console.WriteLine(reqEmailField);
            Boolean EmailMessage = reqEmailField.Text.Contains("Email is required.");
            Console.WriteLine(EmailMessage);
            Assert.IsTrue((BtnContinue == null) && (EmailMessage));


            Console.WriteLine("****************************************************************");
            Console.WriteLine("4.Check for invalid Email");
            welcome = new WelcomePage();
            register = welcome.Register();
            BtnContinue = register.Register("Anu", "Sang", 11, "December", 2002, "abd123", "@nuK1978");

            Console.WriteLine("Wrong email");
            IWebElement wrongEmail = PropertiesCollection.Driver.FindElement(By.Id("Email-error"));
            Console.WriteLine(wrongEmail);
            Boolean WrongEmailMessage = wrongEmail.Text.Contains("Wrong email");
            Console.WriteLine(WrongEmailMessage);
            Assert.IsTrue((BtnContinue == null) && (WrongEmailMessage));

            Console.WriteLine("****************************************************************");
            Console.WriteLine("5.Check  password strength");
            welcome = new WelcomePage();
            register = welcome.Register();
            BtnContinue = register.Register("Anu", "Sang", 11, "December", 2002, "abd@123", "qwert");

            Console.WriteLine("The password should have at least 6 characters.");
            IWebElement passwordError = PropertiesCollection.Driver.FindElement(By.Id("Password-error"));
            Console.WriteLine(passwordError);
            Boolean passwordErrorMessage = passwordError.Text.Contains("The password should have at least 6 characters.");
            Console.WriteLine(passwordErrorMessage);
            Assert.IsTrue((BtnContinue == null) && (passwordErrorMessage));

            Console.WriteLine("****************************************************************");
            Console.WriteLine("6.Check empty password");
            welcome = new WelcomePage();
            register = welcome.Register();
            BtnContinue = register.Register("Anu", "Sang", 11, "December", 2002, "abd@123", "");

            Console.WriteLine("Password is required.");
            IWebElement emptyPasswrd = PropertiesCollection.Driver.FindElement(By.Id("Password-error"));
            Console.WriteLine(emptyPasswrd);
            Boolean emptyPasswrdMessage = emptyPasswrd.Text.Contains("Password is required.");
            Console.WriteLine(emptyPasswrdMessage);
            Assert.IsTrue((BtnContinue == null) && (emptyPasswrdMessage));


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
        public void ShopItem()
        {
            WelcomePage welcome = new WelcomePage();

            StorePage shop = welcome.Login("asangeethu@yahoo.com", "@nuK1978");
            Console.WriteLine("Login done");           
            shop.ShopProduct();

        }
    }
}
