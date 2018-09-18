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

        [FindsBy(How = How.Id, Using = "BillingNewAddress_FirstName")]
        IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_LastName")]
        IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_Email")]
        IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_CountryId")]
        IWebElement Country { get; set; }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_City")]
        IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_Address1")]
        IWebElement Address1 { get; set; }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_ZipPostalCode")]
        IWebElement Zip { get; set; }

        [FindsBy(How = How.Id, Using = "BillingNewAddress_PhoneNumber")]
        IWebElement PhoneNumber { get; set; }


        IWebElement BtnContinue { get; set; }
    }
}
