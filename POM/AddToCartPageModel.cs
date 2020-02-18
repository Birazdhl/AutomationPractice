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
    class AddToCartPageModel
    {
        public AddToCartPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//ul[@class = 'product_list grid row']//following::img)[1]")]
        public IWebElement itemInCategory { get; set; }


        [FindsBy(How = How.Name, Using = "Submit")]
        public IWebElement btnAddToCart { get; set; }
             
 

        [FindsBy(How = How.ClassName, Using = "cross")]
        public IWebElement btnCross { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href*='http://automationpractice.com/index.php?id_category=8&controller=category']")]
        public IWebElement dressCategory { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[href *= 'http://automationpractice.com/index.php?controller=order']")]
        public IWebElement GoToPayment { get; set; }


        public FinalPaymentCheckoutPageModel AddItemToCart(string orderItem)
        {
            //Thread.Sleep(5000);
            itemInCategory.Click();

            StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            btnAddToCart.Click();
            Thread.Sleep(3000);
            btnCross.Click();

            if(orderItem == "last")
            GoToPayment.Click();

            return new FinalPaymentCheckoutPageModel();
        }


    }
}
