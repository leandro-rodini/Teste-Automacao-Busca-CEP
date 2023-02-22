using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCEP.pages
{
    class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AcessarSite(string url)
        {

            //opening the browser and going to the url
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        public void ConsultarCep(string CEP)
        {
            //refresh page
            driver.Navigate().Refresh();

            //find element by id
            var element = driver.FindElement(By.Id("relaxation"));

            //input CEP and press enter
            element.SendKeys(CEP + Keys.Enter);

        }


        public void InputTracking()
        {

            //getting element by xpath
            var element = driver.FindElement(By.XPath("//*[@id='obj']"));

            //typing the tracking number
            element.SendKeys("SS987654321BR");

            //clicking search
            var element2 = driver.FindElement(By.CssSelector("#bto"));
            element2.Click();

        }


    }


}