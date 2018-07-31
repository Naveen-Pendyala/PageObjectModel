using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WineSearcher.Global;

namespace WineSearcher.Pages
{
    public class WineSearch
    {
        internal WineSearch()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //1.Enter Product name in wine search field
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[2]/div/div/div[1]/div/div[2]/form/div/div/span[2]/input")]
        private IWebElement EnterProductName { get; set; }

        //2.Enter Product name in wine search field
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[2]/div/div/div[1]/div/div[2]/form/div/div/span[2]/span/div/span/div[1]/div/div[2]")]
        private IWebElement SelectProduct { get; set; }

        //4.Validating the search results
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[3]/div/div/div[2]/div/div/div/div[1]/div/div[2]/div/table/tbody/tr/td[3]/a/span")]
        private IWebElement  Product{ get; set; }

        //Validating Tasting Notes for the wine

        //5. Click on Tasting Notes 
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[3]/div/div/div[2]/div/div/div/div[3]/div/div/div[2]/div/div[1]/label[2]")]
        private IWebElement TastingNotes { get; set; }

        //6.Validatin Tasting Notes
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[3]/div/div/div[2]/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[4]/div/div[1]/div[1]/div[1]")]
        private IWebElement CriticReviews { get; set; }

        //7.Validating Tasting notes
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[3]/div/div/div[2]/div/div/div/div[3]/div/div/div[2]/div/div[2]/div[4]/div/div[2]/div[1]/div[1]")]
        private IWebElement UserReviews { get; set; }








        internal void SearchingProduct()
        {
            EnterProductName.SendKeys("Villa Maria");
            Thread.Sleep(2000);

            SelectProduct.Click();
            Thread.Sleep(5000);
            

            if(Product.Displayed)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test PASS, User can search the wine successfullyusing the search bar");
            }
            else
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test FAIL,User can't serarch the wine using search bar");
            }

            TastingNotes.Click();
            Thread.Sleep(2000);

            if(CriticReviews.Displayed)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Pass,Critic Reviews Visible");
            }
            else
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Fail,Critic Revies Not Visible");
            }

            if(UserReviews.Displayed)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Pass,User Reviews Visible");
            }
            else
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Fail,User Reviews Not Visible");
            }
        }

        }
}
