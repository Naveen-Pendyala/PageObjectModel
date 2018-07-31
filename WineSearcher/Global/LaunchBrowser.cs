using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using MongoDB.Driver.Core.Operations;
using static WineSearcher.Global.CommonMethods;

namespace WineSearcher.Global
{
    internal class Launchbrowser
    {
        //create constructor
        public Launchbrowser()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


       

        internal void LaunchingBrowser()
        {
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "LoginPage");

            // Navigating to Login page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));

            
        }
    }
}

