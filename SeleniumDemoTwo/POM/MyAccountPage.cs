using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.POM
{
    public class MyAccountPage
    {
        [Obsolete("Use newMethod instead", false)]

        //initialize page object using constructor
        public MyAccountPage()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement TxtPasswrd { get; set; }

        [FindsBy(How = How.ClassName, Using = "login-button")]
        public IWebElement BtnLogIn { get; set; }

        //method to login
        public void Login(string email, string passwrd)
        {
            TxtEmail.SendKeys(email);
            TxtPasswrd.SendKeys(passwrd);
            BtnLogIn.Click();
            //return new WelcomePage();
        }

    }
}
