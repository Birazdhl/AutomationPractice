using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealTask.POM
{
    class PersonalInformationPageModel
    {

        public PersonalInformationPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "id_gender1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.Name, Using = "customer_firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "customer_lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Name, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "days")]
        public IWebElement Days { get; set; }

        [FindsBy(How = How.Name, Using = "months")]
        public IWebElement Months { get; set; }

        [FindsBy(How = How.Name, Using = "years")]
        public IWebElement years { get; set; }

        [FindsBy(How = How.Name, Using = "newsletter")]
        public IWebElement NewsLetter { get; set; }

        [FindsBy(How = How.Name, Using = "optin")]
        public IWebElement Option { get; set; }

        [FindsBy(How = How.Name, Using = "address1")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Name, Using = "city")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Name, Using = "id_state")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.Name, Using = "postcode")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.Name, Using = "id_country")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.Name, Using = "phone_mobile")]
        public IWebElement MobilePhone { get; set; }

        [FindsBy(How = How.Name, Using = "alias")]
        public IWebElement Alias { get; set; }

        [FindsBy(How = How.Name, Using = "submitAccount")]
        public IWebElement Register { get; set; }


        public CategoryPageModel RegisterAccount()
        {
            Title.Click();
            FirstName.SendKeys(SendKeysValues.FirstName);
            LastName.SendKeys(SendKeysValues.LastName);
            Password.SendKeys(SendKeysValues.Password);
            new SelectElement(Days).SelectByValue(SendKeysValues.Days);
            new SelectElement(Months).SelectByValue(SendKeysValues.Months);
            new SelectElement(years).SelectByValue(SendKeysValues.Year);
            NewsLetter.Click();
            Option.Click();
            Address.SendKeys(SendKeysValues.Address);
            City.SendKeys(SendKeysValues.City);
            new SelectElement(State).SelectByValue(SendKeysValues.State);
            PostalCode.SendKeys(SendKeysValues.PostalCode);
            MobilePhone.SendKeys(SendKeysValues.MobilePhone);
            Alias.Clear();
            Alias.SendKeys(SendKeysValues.Alias);
            Register.Click();

            Console.WriteLine("User Successfully Registered");
            return new CategoryPageModel();
        }

    }
}
