using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Selenium
{
    class Program
    {
        static void Main(string[] args)
        {


            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            IWebDriver driver = new ChromeDriver(options);
            string email = "test@yahoo.com";
            string password = "test123";

            

            driver.Url = "http://facebook.com";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); //waits x seconds before throwing an exception

            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.XPath("//*[@id='pass']")).SendKeys(password + Keys.Enter);

            driver.FindElement(By.XPath("//*[@id='navItem_777474744']/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]/div/div[2]/div[3]/ul/li[3]/a")).Click();

            List<IWebElement> friends = driver.FindElements(By.XPath("//div[@class= 'fsl fwb fcb']/a")).ToList();

            Console.WriteLine("Total Friends On Page : " +friends.Count);

            foreach(IWebElement x in friends)
            {
                Console.WriteLine(x.Text);
            }

            Console.ReadKey();
             


        }

    }
}
