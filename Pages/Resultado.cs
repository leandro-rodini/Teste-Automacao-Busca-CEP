using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCEP.pages
{
    class Resultado
    {
        private IWebDriver driver;

        public Resultado(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void NotFoundCEP()
        {

            //change tab
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            //getting element by id
            var element = driver.FindElement(By.Id("mensagem-resultado"));

            //checking if element has the following text
            const string noData = "Não há dados a serem exibidos";
            Assert.AreEqual(element.Text, noData);
            driver.Quit();
        }


        public void FoundCEP()
        {

            //change tab
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            //getting element by xpath
            var element = driver.FindElement(By.XPath("//*[@id='resultado-DNEC']/tbody/tr/td[1]"));

            //getting element by Css Selector
            var element2 = driver.FindElement(By.CssSelector("#resultado-DNEC > tbody > tr > td:nth-child(3)"));

            //checking if elements have the following text
            const string rua = "Rua Quinze de Novembro - lado ímpar";
            const string uf = "São Paulo/SP";
            Assert.AreEqual(element.Text, rua);
            Assert.AreEqual(element2.Text, uf);

            //closing browser
            driver.Quit();


        }

        public void TrackingError()
        {
            //getting element by Css Selector
            var element = driver.FindElement(By.CssSelector("#track-details > div.container > div > p:nth-child(1) > b"));
            
            //checking if element has the following text
            const string error = "O sistema dos Correios não possui dados sobre o objeto informado.";
            Assert.AreEqual(element.Text, error);

            //closing browser
            driver.Quit();

        }
    }
}