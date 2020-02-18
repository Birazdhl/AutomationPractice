using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealTask.POM
{
    class CreateAccountPageModel
    {
        public CreateAccountPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "email_create")]
        public IWebElement txtEmailAddress { get; set; }

        [FindsBy(How = How.Name, Using = "SubmitCreate")]
        public IWebElement btnCreateAccount { get; set; }

        public PersonalInformationPageModel CreateAccount()
        {
            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(45);
            txtEmailAddress.SendKeys(SendKeysValues.EmailAddressToRegister);
            btnCreateAccount.Submit();
            return new PersonalInformationPageModel();
        }
    }
}
