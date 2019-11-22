using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Assessment_Selenium
{
    [TestClass]
    public class case2UnitTest2
    {
       
        [TestMethod]
        public void TestMethod_1()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\SeleniumJars"); 

            string url = "http://www.youcandealwithit.com/"; //To open website we used driver.url 
            driver.Url = url;
            Thread.Sleep(2000);     //This makes the last operation wait for given time(in milliseconds).

            string resources_title = "Calculators & Resources"; //Assigning values to variables
            string calculator_title = "Calculators";
            string budget_title = "Budget Calculator";
            string foodvalue = "300";
            string clothingvalue = "200";
            string sheltervalue = "2000";
            string monthlypayvalue = "10000";
            string monthlyothersvalue = "50";
            string foodid = "food";
            string clothingid = "clothing";
            string shelterid = "shelter";
            string monthlypayid = "monthlyPay";
            string monthlyothersid = "monthlyOther";
            string savings_budget_id = "underOverBudget";
            string monthly_expense_id = "totalMonthlyExpenses";
            string total_income_id = "totalMonthlyIncome";
            string borrowerspath = "//*[@id='siteNav']/li[1]/a";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);     // to assign wait time to each code statement
            IWebElement target = driver.FindElement(By.XPath(borrowerspath));  //Next 4 commands perform mousehover action.
            Actions action = new Actions(driver);
            Thread.Sleep(3000);     //This makes the last operation wait for given time(in milliseconds).
            action.MoveToElement(target).Build().Perform();
            Thread.Sleep(2000);     //This makes the last operation wait for given time(in milliseconds).

            driver.FindElement(By.LinkText(resources_title)).Click();       // To click on Calculators and Resources
            Thread.Sleep(2000);     //This makes the last operation wait for given time(in milliseconds).
            string webpage_title = driver.Title.ToString();     //To check title is same as link text
            if (webpage_title.Contains(resources_title))
            {
                Console.WriteLine(webpage_title +" is same as "+ resources_title+"!!");
            }
            else
            {
                Console.WriteLine(webpage_title + " is not same as " + resources_title + "!!");
            }

            driver.FindElement(By.LinkText(calculator_title)).Click();       // To click on Calculators 
            Thread.Sleep(2000);     //This makes the last operation wait for given time(in milliseconds).
            string webpage_title1 = driver.Title.ToString();        //To check title is same as link text
            if (webpage_title1.Contains(calculator_title))
            {
                Console.WriteLine(webpage_title + " is same as " + calculator_title + "!!");
            }
            else
            {
                Console.WriteLine(webpage_title + " is not same as " + calculator_title + "!!");
            }

            driver.FindElement(By.LinkText(budget_title)).Click();       // To click on Budget Calculators 
            Thread.Sleep(2000);     //This makes the last operation wait for given time(in milliseconds).
            string webpage_title2 = driver.Title.ToString();        //To check title is same as link text
            if (webpage_title2.Contains(budget_title))
            {
                Console.WriteLine(webpage_title + " is same as " + budget_title + "!!");
            }
            else
            {
                Console.WriteLine(webpage_title + " is not same as " + budget_title + "!!");
            }

            driver.FindElement(By.Id(foodid)).SendKeys(foodvalue);      // next 5 operations are for entering data
            driver.FindElement(By.Id(clothingid)).SendKeys(clothingvalue);
            driver.FindElement(By.Id(shelterid)).SendKeys(sheltervalue);
            driver.FindElement(By.Id(monthlypayid)).SendKeys(monthlypayvalue);
            driver.FindElement(By.Id(monthlyothersid)).SendKeys(monthlyothersvalue);
            Thread.Sleep(2000);     //This makes the last operation wait for given time(in milliseconds).

            double monthly_expense_value = double.Parse(driver.FindElement(By.Id(monthly_expense_id)).GetAttribute("value")); // to retrieve monthly expense value
            Thread.Sleep(2000);      //This makes the last operation wait for given time(in milliseconds).

            double total_income_value = double.Parse(driver.FindElement(By.Id(total_income_id)).GetAttribute("value")); //to retrieve monthly income
            Thread.Sleep(2000);      //This makes the last operation wait for given time(in milliseconds).

            Console.WriteLine("Total Monthly Income:" + total_income_value.ToString());     //displaying monthly income
            Console.WriteLine("Total Monthly Expenses:" + monthly_expense_value.ToString());     //displaying monthly expense   

            if ( monthly_expense_value <= total_income_value)   // to check whether the monthly expense is more or less than monthly income
            {
                Console.WriteLine("You are Warren Buffet");
            }
            else
            {
                Console.WriteLine("Start Saving!!");
            }

            string savings_budget_value = driver.FindElement(By.Id(savings_budget_id)).GetAttribute("value").ToString();    //to retrieve savings value
            Thread.Sleep(2000);

           
            Console.WriteLine("Total savings Value:"+ savings_budget_value);     // displaying savings budget value
            Console.WriteLine("Execution Successful!!");
            driver.Close();
            
        }
    }
}
