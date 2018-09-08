using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoTwo.POM
{
    public class RegisterPage
    {
        public IWebElement RadioBtnMale { get; set; } 

        public IWebElement RadioBtnFemale { get; set; }

        public IWebElement TxtFirstName { get; set; }

        public IWebElement TxtLastName { get; set; }

        public IWebElement SelectDay { get; set; }

        public IWebElement SelectMonth { get; set; }

        public IWebElement SelectYear { get; set; }

        public IWebElement TxtEmail { get; set; }

        public IWebElement TxtPasswrd { get; set; }

        public IWebElement TxtConfirmPasswrd { get; set; }

        public IWebElement BtnRegister { get; set; }
    }
}

