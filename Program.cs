using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RealTask.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            p.Initialize();
            p.Test();
            p.CleanUp();
            
        }

        [SetUp]
        public void Initialize()
        {
            //Setting Value for All Send Keys in the Case
            SendKeysValues.SetValuesForSendKeys();

            StaticDriver.driver = new FirefoxDriver();
            StaticDriver.driver.Navigate().GoToUrl("http://automationpractice.com");
        }

        [Test]
        public void Test()
        {
            //Case 1 Registration In the Site

            UserRegistrationPageModel pageModel = new UserRegistrationPageModel();
            CreateAccountPageModel crtAcc = pageModel.GoToSignIn();

            PersonalInformationPageModel userDetails = crtAcc.CreateAccount();
            CategoryPageModel ctrModel = userDetails.RegisterAccount();


            //Case 2 Buying Item From 2 different categoris and proceeding to checkout

            AddToCartPageModel addToCart = ctrModel.GoToCategory("NotFinal");
            addToCart.AddItemToCart("First");

            AddToCartPageModel secondItem = ctrModel.GoToCategory("Final");

            FinalPaymentCheckoutPageModel finPay = addToCart.AddItemToCart("last");
            finPay.Checkout();
        }

        [TearDown]
        public void CleanUp()
        {
            StaticDriver.driver.Close();
            Console.WriteLine("Test Passed");
        }

    }
}
