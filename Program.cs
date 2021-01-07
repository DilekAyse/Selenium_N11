using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestTool
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string link = @"https://www.n11.com/";
            //sitemizi açmak için
            driver.Navigate().GoToUrl(link);
            driver.FindElement(By.ClassName("closeBtn")).Click();
            driver.FindElement(By.ClassName("dn-slide-deny-btn")).Click();
            driver.FindElement(By.Id("searchData")).SendKeys("bilgisayar");
            driver.FindElement(By.ClassName("searchBtn")).Click();
            //bazı durumlarda class tanımlanmamış olabiliyor o zaman XPath ile yolunu göstermemiz gerekmekte.
            driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[5]/a[2]")).Click();
            driver.FindElement(By.XPath(".//*[@id='p-434348820']/div[1]/a")).Click();
            driver.FindElement(By.ClassName("addBasketUnify")).Click();

         
        }
    }
}
