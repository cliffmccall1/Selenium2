using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst {
    class Program {
        static void Main (string[] args) {

            string pathToDriver = "/Users/cliff/Desktop/SeleniumFirst/assets/";
            // Create the reference for browser
            IWebDriver driver = new ChromeDriver (pathToDriver);
            Console.WriteLine ("We are starting");

            // Navigate to Test Site
            driver.Navigate ().GoToUrl ("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine ("Browser Opened");

            // Select Title
            SeleniumSetMethods.SelectDropDown (driver, "TitleId", "Mr.", "Id");
            // Verify Selection
            Console.WriteLine ("Title value is: " + SeleniumGetMethods.GetFromDropDown (driver, "TitleId", "Id"));

            // Enter Initial
            SeleniumSetMethods.EnterText (driver, "Initial", "JH", "Name");
            // Verify Text Entered
            Console.WriteLine ("Initial value is: " + SeleniumGetMethods.GetText (driver, "Initial", "Name"));

            // Enter First Name
            SeleniumSetMethods.EnterText (driver, "FirstName", "Jim", "Name");
            // Verify Text Entered
            Console.WriteLine ("FirstName value is: " + SeleniumGetMethods.GetText (driver, "FirstName", "Name"));

            // Enter Middle Name
            SeleniumSetMethods.EnterText (driver, "MiddleName", "Halpert", "Name");
            // Verify Text Entered
            Console.WriteLine ("MiddleName value is: " + SeleniumGetMethods.GetText (driver, "MiddleName", "Name"));

            // Click
            SeleniumSetMethods.Click (driver, "Save", "Name");
            // Close Chrome
            driver.Close ();
            Console.WriteLine ("Browser Closed");

        }
    }
}