using System;
using AutomationCEP.pages;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace AutomationCEP.Steps
{
    [Binding]
    public class StepDefinitions
    {

        string url = "https://www.correios.com.br";
        IWebDriver driver;
        Home home;
        Resultado resultado;
        private readonly ScenarioContext _scenarioContext;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"that I am in Correios website")]
        public void GiventhatIaminCorreioswebsite()
        {
            driver = new ChromeDriver();
            home = new Home(driver);
            resultado = new Resultado(driver);

            home.AcessarSite(url);
        }

        [When(@"I input a non-existent CEP")]
        public void WhenIinputanonexistentCEP()
        {

            home.ConsultarCep("80700000");

        }

        [Then(@"the website returns Not Found message")]
        public void ThenthewebsitereturnsNotFoundmessage()
        {
            resultado.NotFoundCEP();
        }

        [When(@"I input an existent CEP")]
        public void WhenIinputanexistentCEP()
        {
            home.ConsultarCep("01013-001");
        }

        [Then(@"the website returns the adress")]
        public void Thenthewebsitereturnstheadress()
        {
            resultado.FoundCEP();
        }

        [Given(@"that I am in a Tracking website")]
        public void GiventhatIaminaTrackingwebsite()
        {
            driver = new ChromeDriver();
            home = new Home(driver);
            resultado = new Resultado(driver);


            home.AcessarSite("https://rastreamentocorreios.info");

        }

        [When(@"I input a Tracking Number")]
        public void WhenIinputaTrackingNumber()
        {
            home.InputTracking();
        }

        [Then(@"the website returns the error")]
        public void Thenthewebsitereturnstheerror()
        {
            resultado.TrackingError();
        }

    }
}