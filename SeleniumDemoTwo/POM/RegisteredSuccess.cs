using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.POM
{
    public class RegisteredSuccess
    {
        [Obsolete("Use newMethod instead", false)]
        public RegisteredSuccess()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "register-continue")]
        public IWebElement BtnContinue { get; set; }

        public StorePage Continue()
        {
            BtnContinue.Click();
            return new StorePage();
        }
    }
}
