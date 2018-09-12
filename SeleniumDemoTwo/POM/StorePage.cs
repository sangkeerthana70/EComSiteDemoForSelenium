using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.POM
{
    public class StorePage
    {
        [Obsolete("Use newMethod instead", false)]

        //initialize page object using constructor
        public StorePage()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "product-item")]
        IWebElement FeaturedProducts { get; set; }

        [FindsBy(How = How.ClassName, Using = "add-to-cart-button")]
        IWebElement AddCart { get; set; }

        //shop item
        public void ShopProduct()
        {
            AddCart.Click();
        }
    }


}
