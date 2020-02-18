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
    class FinalPaymentCheckoutPageModel
    {
        public FinalPaymentCheckoutPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@title = 'Proceed to checkout']//following::a[@title = 'Proceed to checkout']")]
        public IWebElement btnProceedToCheckout { get; set; }

        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement btnNextProceedToCheckout { get; set; }

        [FindsBy(How = How.Name, Using = "cgv")]
        public IWebElement chkAgreement { get; set; }

        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement btnShipCheckout { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href*='http://automationpractice.com/index.php?fc=module&module=cheque&controller=payment']")]
        public IWebElement payByCheck { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cart_navigation\"]/button")]
        public IWebElement btnConfirmOrder { get; set; }
        
        public void Checkout()
        {
            btnProceedToCheckout.Click();
            btnNextProceedToCheckout.Click();
            chkAgreement.Click();
            btnShipCheckout.Click();
            payByCheck.Click();
            btnConfirmOrder.Click();
            Thread.Sleep(2000);

        }

    }
}
