using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst {
    class Program {
        static void Main (string[] args) {

            string pathToDriver = "/Users/cliff/Desktop/SeleniumFirst/assets/";

            Console.WriteLine ("We are starting");
            // Create the reference for browser
            IWebDriver driver = new ChromeDriver (pathToDriver);

            // Navigate to Test Site
            driver.Navigate ().GoToUrl ("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine ("Browser Opened");

            // Title
            SeleniumSetMethods.SelectDropDown (driver, "TitleId", "Ms.", "Id");
            Thread.Sleep (500);
            Console.WriteLine ("Initial Complete");

            // Initial
            SeleniumSetMethods.EnterText (driver, "Initial", "PBJ", "Name");
            Thread.Sleep (500);
            Console.WriteLine ("Initial Complete");

            // First Name
            SeleniumSetMethods.EnterText (driver, "FirstName", "Pam", "Name");
            Thread.Sleep (500);
            Console.WriteLine ("FirstName Complete");

            // Middle Name
            SeleniumSetMethods.EnterText (driver, "MiddleName", "Beasley", "Name");
            Thread.Sleep (500);
            Console.WriteLine ("MiddleName Complete");

            // Click
            SeleniumSetMethods.Click (driver, "Save", "Name");
            Thread.Sleep (1000);
            Console.WriteLine ("Click Complete");
            // Close Chrome
            Thread.Sleep (3000);
            driver.Close ();
            Console.WriteLine ("Browser Closed");

        }
    }
}