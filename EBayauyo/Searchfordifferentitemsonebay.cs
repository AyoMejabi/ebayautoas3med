using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace EBayauyo
{
    [Binding]
    public sealed class Searchfordifferentitemsonebay
    {
        public IWebDriver driver;
       
        [Given(@"I navigate to ebay homepage")]
        public void GivenINavigateToEbayHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.kelloggs.co.uk/");
        }

        [Given(@"I hover over search for anything")]
        public void GivenIHoverOverSearchForAnything()
        {
           
        }

        [When(@"I type in iphone (.*)")]
        public void WhenITypeInIphone(int p0)
        {
            
        }

        [When(@"I clikc on the search button")]
        public void WhenIClikcOnTheSearchButton()
        {
            
        }

        [Then(@"the list of iphone(.*) phones for sale will be displayed")]
        public void ThenTheListOfIphonePhonesForSaleWillBeDisplayed(int p0)
        {
            
        }

    }
}
