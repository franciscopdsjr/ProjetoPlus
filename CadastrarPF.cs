﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace Portal
{
    /// <summary>
    /// Descrição resumida para CadastrarPF
    /// </summary>
    [TestClass]
    public class CadastrarPF
    {
        [TestMethod]
        public void CadastroPF()
        {
            #region Abrir o Chrome
            //inicializando o chrome
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://main.safety8.local/#/login?cnpj=72.408.271%2F0001-91");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(3000);
            #endregion

            #region Login
            var cnpj = driver.FindElement(By.Id("cnpj"));
            cnpj.SendKeys("72408271000191");
            {
                var elemento = driver.FindElement(By.CssSelector(".logo-login-q"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(elemento).ClickAndHold().Perform();
            }
            {
                var elemento = driver.FindElement(By.CssSelector(".efeitoOverlay"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(elemento).Release().Perform();
            }
            driver.FindElement(By.CssSelector(".container-fluid")).Click();
            driver.FindElement(By.CssSelector(".ng-scope > .animated")).Click();
            {
                var dropdown = driver.FindElement(By.CssSelector(".ng-scope > .animated"));
                dropdown.FindElement(By.XPath("/html/body/div[5]/div[2]/div[2]/div/div/div/div/div/div[2]/div[2]/select/option[3]")).Click();
                //driver.Quit();
            }

            driver.FindElement(By.CssSelector(".ng-scope > .animated")).Click();
            driver.FindElement(By.Id("usuario")).Click();
            driver.FindElement(By.Id("usuario")).SendKeys("francisco");
            driver.FindElement(By.Id("senha")).SendKeys("F123456");
            driver.FindElement(By.CssSelector(".button-login-q")).Click();
            #endregion

            #region Cadastrar Cliente PF
            System.Threading.Thread.Sleep(2000);//Aguardando a pagina carregar
            driver.FindElement(By.Id("botaoMenu")).Click();
            System.Threading.Thread.Sleep(1000);//Aguardando a pagina carregar
            driver.FindElement(By.CssSelector("div:nth-child(3) > ul > li:nth-child(2) > a > span")).Click();
            System.Threading.Thread.Sleep(1000);//Aguardando a pagina carregar
            driver.FindElement(By.CssSelector("div:nth-child(5) > div.container-fluid > div:nth-child(3) > div.index-conteudo.ng-scope.animated.fadeIn.conteudo-geral > div > div > form > div.paddingCard.col-lg-7.col-md-12.col-sm-12.col-xs-12 > div > div.clearfix.card-header.bg-card-teal > button")).Click();
            //Informa Nome
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_cli_nome")).Click();
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_cli_nome")).SendKeys("FAUSTO SILVA");
            //Informa CPF
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_cli_cpf_cnpj")).Click();
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_cli_cpf_cnpj")).SendKeys("589.050.489-43");
            //Informa data nascimento
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_cli_data_nascimento")).Click();
            driver.FindElement(By.CssSelector(".today")).Click();
            //Informa ponto de venda
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_pto_codigo")).Click();
            driver.FindElement(By.LinkText("MATRIZ")).Click();
            //Informa vendedor
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_vend_codigo")).Click();
            driver.FindElement(By.LinkText("FRANCISCO")).Click();
            //Informa Origem
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_cliori_codigo")).Click();
            driver.FindElement(By.LinkText("GERAL")).Click();

            driver.ExecuteJavaScript("window.scroll(0,1000)");//Executa js
            //Informa o endereço
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_tpender_codigo")).Click();
            driver.FindElement(By.LinkText("Residencial")).Click();
            driver.FindElement(By.Id("campoCep")).Click();
            driver.FindElement(By.Id("campoCep")).SendKeys("84025-350");

            {
                var element = driver.FindElement(By.CssSelector(".efeitoOverlay"));
                Actions builder = new Actions(driver);
                //builder.MoveToElement(element).Release().Perform();
            }
            //Salva
            driver.FindElement(By.CssSelector(".container-fluid")).Click();
            driver.FindElement(By.Name("frmAutoFormclientesundefined_edt_ender_numero")).SendKeys("350");
            driver.FindElement(By.CssSelector("div:nth-child(2) > .btn > span:nth-child(2)")).Click();
        }
        #endregion
    }
}
