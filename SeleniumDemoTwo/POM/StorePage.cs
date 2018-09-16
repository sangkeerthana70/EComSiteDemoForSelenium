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

       

        [FindsBy(How = How.XPath, Using = "/html/body/div[6]/div[3]/div/div/div/div/div[4]/div[2]/div[2]/div/div[2]/div[3]/div[2]/input[1]")]
        IWebElement AddCart { get; set; }

        //IWebElement AddCart2 { get; set; }

        [FindsBy(How = How.ClassName, Using = "cart-label")]
        IWebElement ShoppingCart { get; set; }


            
        //shop item
        public Checkout ShopProduct()
        {
            AddCart.Click();
            System.Threading.Thread.Sleep(5000);
            PropertiesCollection.Driver.FindElement(By.Id("add-to-cart-button-4")).Click();
            ShoppingCart.Click();
            Console.WriteLine("Click on shopping cart");
            return new Checkout();

        }
    }


}
