using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.POM
{
    public class FinalCheckout
    {
        [Obsolete("Use newMethod instead", false)]

        //initialize page object using constructor
        public FinalCheckout()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        IWebElement FirstName { get; set; }

        IWebElement LastName { get; set; }

        IWebElement Email { get; set; }

        IWebElement Country { get; set; }

        IWebElement City { get; set; }

        IWebElement Address1 { get; set; }

        IWebElement Zip { get; set; }

        IWebElement PhoneNumber { get; set; }

        IWebElement BtnContinue { get; set; }
    }
}
