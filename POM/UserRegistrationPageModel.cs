using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealTask.POM
{
    class UserRegistrationPageModel
    {
        public  UserRegistrationPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement btnSignIn { get; set; }


        public CreateAccountPageModel GoToSignIn()
        {
           
            btnSignIn.Click();
            return new CreateAccountPageModel();
        }


    }
}
