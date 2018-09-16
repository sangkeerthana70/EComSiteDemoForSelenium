using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.POM
{
    public class Checkout
    {
        [Obsolete("Use newMethod instead", false)]

        //initialize page object using constructor
        public Checkout()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }
        [FindsBy(How = How.Name, Using = "checkout")]
        IWebElement CheckoutButton { get; set; }

        [FindsBy(How = How.Id, Using = "termsofservice")]
        IWebElement CheckBox { get; set; }

        public void ClickCheckout()
        {
            CheckBox.Click();
            CheckoutButton.Click();
        }
    }
}
