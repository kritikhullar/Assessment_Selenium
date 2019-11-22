using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assessment_Selenium
{
    [TestClass]
    public class case1UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\SeleniumJars");

            string url = "https://www.google.com/";     //To open website we used driver.url 
            driver.Url = url;
            Thread.Sleep(2000);     //This makes the last operation wait for given time(in milliseconds).

            string nameelement = "q";       //Assigning values to variables
            string classelement = "gNO89b";
            string idelement = "resultStats";
            string search = "DXC Technologies";

            driver.FindElement(By.Name(nameelement)).SendKeys(search);      //to search DXC Technologies
            Thread.Sleep(2000);     //This makes the last operation wait for given time(in milliseconds).
            driver.FindElement(By.ClassName(classelement)).Click();     // to click on search button
            Thread.Sleep(3000);     //This makes the last operation wait for given time(in milliseconds).

            string title = driver.Title.ToString();     // To check webpage Title and search element is same
            if (title.Contains(search))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Console.WriteLine(title);
            Thread.Sleep(2000);

            string result = driver.FindElement(By.Id(idelement)).Text;      //to print result statistics
            Console.WriteLine(result);
            Thread.Sleep(2000);
            Console.WriteLine("Execution Successful!!");
            driver.Close();
            
        }
    
    }
}
