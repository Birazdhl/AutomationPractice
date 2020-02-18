using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTask.POM
{
    class CategoryPageModel
    {
        public CategoryPageModel()
        {
            PageFactory.InitElements(StaticDriver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[href*='http://automationpractice.com/index.php?id_category=3&controller=category']")]
        public IWebElement WomenCategory { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title = 'Dresses']//following::a[@title = 'Dresses']")]
        public IWebElement dressCategory { get; set; }


        public AddToCartPageModel GoToCategory(string step)
        {
            if(step == "Final")
            {
                StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                dressCategory.Click();
            }
            else
            { 
                StaticDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                WomenCategory.Click();
            }
            return new AddToCartPageModel();
        }
    }
}
