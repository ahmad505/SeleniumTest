using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test case started ");

            IWebDriver driver = new ChromeDriver("c:/Chrome");

            driver.Navigate().GoToUrl("https://oyounmedia.com/contact-us/");
            Thread.Sleep(2000);

            IWebElement ele = driver.FindElement(By.Name("item_meta[6]"));

            ele.SendKeys("Ahmad");
            Thread.Sleep(2000);

            IWebElement ele1 = driver.FindElement(By.Name("item_meta[7]"));
            ele1.SendKeys("Afifi");
            Thread.Sleep(2000);

            IWebElement ele2 = driver.FindElement(By.Name("item_meta[9]"));
            ele2.SendKeys("AhmadAfifi@gmail.com");
            Thread.Sleep(2000);

            IWebElement ele3 = driver.FindElement(By.Name("item_meta[10]"));
            ele3.SendKeys("jerusalem");
            Thread.Sleep(2000);

            IWebElement ele4 = driver.FindElement(By.Name("item_meta[11]"));
            ele4.SendKeys("0597885245");
            Thread.Sleep(2000);

            IWebElement ele5 = driver.FindElement(By.Name("item_meta[12]"));
            ele5.SendKeys("Qudsbank");
            Thread.Sleep(2000);

            IWebElement ele6 = driver.FindElement(By.ClassName("frm_button_submit"));
            ele6.Click();
            Thread.Sleep(2000);
            Console.Write("test case ended ");
        }
    }
}