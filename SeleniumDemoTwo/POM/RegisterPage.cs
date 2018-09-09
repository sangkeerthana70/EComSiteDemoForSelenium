using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.POM
{
    public class RegisterPage
    {
        [Obsolete("Use newMethod instead", false)]

        //initialize page object using constructor
        public RegisterPage()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }
        
        [FindsBy(How = How.Id, Using = "gender-male")]
        public IWebElement RadioBtnMale { get; set; } 

        [FindsBy(How = How.Id, Using = "gender-female")]
        public IWebElement RadioBtnFemale { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement TxtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "LastName")]
        public IWebElement TxtLastName { get; set; }

        [FindsBy(How = How.Name, Using = "DateOfBirthday")]
        public IWebElement SelectDay { get; set; }

        [FindsBy(How = How.Name, Using = "DateOfBirthMonth")]
        public IWebElement SelectMonth { get; set; }

        [FindsBy(How = How.Name, Using = "DateOfBirthYear")]
        public IWebElement SelectYear { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement TxtPasswrd { get; set; }

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        public IWebElement TxtConfirmPasswrd { get; set; }

        [FindsBy(How = How.Id, Using = "register-button")]
        public IWebElement BtnRegister { get; set; }

        //method to fill register form
        public MyAccountPage SignIn(string fname, string lname, int date, string month, int year, string email, string passwrd, string confirmpasswrd)
        {
            TxtFirstName.SendKeys(fname);
            TxtLastName.SendKeys(lname);
            SelectDay.SendKeys(date.ToString());
            SelectMonth.SendKeys(month);
            SelectYear.SendKeys(year.ToString());
            TxtEmail.SendKeys(email);
            TxtPasswrd.SendKeys(passwrd);
            TxtConfirmPasswrd.SendKeys(confirmpasswrd);
            BtnRegister.Click();

            return new MyAccountPage();
        }
    }
}

