using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.POM
{
    public class Authentication
    {
        [Obsolete("Use newMethod instead", false)]//modify the code to use the Obsolete atrribute as PageFactory was deprecated

        //initialize page object using constructor
        public Authentication()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "button-1 register-button")]
        public IWebElement BtnRegister { get; set; }

        [FindsBy(How = How.ClassName, Using = "email")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.ClassName, Using = "password")]
        public IWebElement TxtPasswrd { get; set; }

        [FindsBy(How = How.ClassName, Using = "button-1 login-button")]
        public IWebElement BtnLogin { get; set; }

        //method to click register and launch register page
        public RegisterPage Register()
        {
            BtnRegister.Click();
        }
    }
}
