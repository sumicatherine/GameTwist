using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameTwist.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GameTwist.Framework;
using OpenQA.Selenium.Chrome;

namespace GameTwist.TestImpl
{
    class HomePageImpl : HomePage
    {

        public HomePageImpl()
        {
            //Browsers.Init();

            PageFactory.InitElements(Browsers.getDriver, this);

        }

        public void CheckLoggedInUser()
        {
            try
            {
                //Browsers.reports.verifyElementNotAppear(NickName);

                Assert.AreEqual(true, NickName.Displayed);
                Console.WriteLine("Logged in successfully");
                ClosePopUps();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Login(string username, string password)
        {

            UserName.Clear();
            UserName.SendKeys(username);
            Password.SendKeys(password);
            SignInButton.Click();


        }
        public Boolean isAlertPresent()
        {
            try
            {
                Browsers.getDriver.SwitchTo().Alert();
                return true;
            }   // try 
            catch (NoAlertPresentException Ex)
            {
                return false;
            }   // catch 
        }   // isAlertPresent()
        public void ClosePopUps()
        {
            if (isAlertPresent())
            {
                Browsers.getDriver.Close();
                Console.WriteLine("Pop up closed.");
            }
        }
        public void Checknavigation(String gametype)
        {
            try
            {
                if (gametype == "Slots")
                {
                    String ExpectedSlotsUrl = "https://www.gametwist.com/en/games/slots/";
                    Slots.Click();
                    System.Threading.Thread.Sleep(3000);
                    Assert.AreEqual(Browsers.getDriver.Url, ExpectedSlotsUrl);
                    Console.WriteLine("Opened Slots Page");
                }
                if (gametype == "Bingo")
                {
                    String ExpectedBingoUrl = "https://www.gametwist.com/en/games/bingo/";
                    Bingo.Click();
                    System.Threading.Thread.Sleep(3000);
                    Assert.AreEqual(Browsers.getDriver.Url, ExpectedBingoUrl);
                    Console.WriteLine("Opened Bingo Page");
                }
                if (gametype == "Casino")
                {
                    String ExpectedCasinoUrl = "https://www.gametwist.com/en/games/casino/";
                    Casino.Click();
                    System.Threading.Thread.Sleep(3000);
                    Assert.AreEqual(Browsers.getDriver.Url, ExpectedCasinoUrl);
                    Console.WriteLine("Opened Casino Page");
                }
                if (gametype == "Poker")
                {
                    String ExpectedPokerUrl = "https://www.gametwist.com/en/games/poker/";
                    Poker.Click();
                    System.Threading.Thread.Sleep(3000);
                    Assert.AreEqual(Browsers.getDriver.Url, ExpectedPokerUrl);
                    Console.WriteLine("Opened Poker Page");
                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        public void Search(String SearchText)
        {
            txtSearch.SendKeys(SearchText);
            SelectGamefromSearchList();
        }

        public void SelectGamefromSearchList()
        {
            try
            {
                String ExpectedGameUrl = "https://www.gametwist.com/en/games/slots/slots-pharaohs-way/";
                List<IWebElement> lstSearchitem = new List<IWebElement>(lstSearch.FindElements(By.TagName("a")));
                Console.WriteLine("Count:" + lstSearchitem.Count);
                if (lstSearchitem.Count > 0)
                {
                    
                    foreach (var item in lstSearchitem)
                    {
                       
                        if (item.Text.Contains("Slots Pharaoh’s Way"))
                        {
                            item.Click();
                            System.Threading.Thread.Sleep(10000);
                            Assert.AreEqual(Browsers.getDriver.Url, ExpectedGameUrl);
                            Console.WriteLine("Opened Slots Pharaoh's Way game");
                            break;
                        }

                    }



                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void SelectLanguage(string Language)
        {
            var expectedLanguage = Language;
            btnLang.Click();
            List<IWebElement> lstlannguageitem = new List<IWebElement>(lstLanguage.FindElements(By.TagName("a")));
            if (lstlannguageitem.Count > 0)
            {
                foreach (var itemlang in lstlannguageitem)
                {
                    if (itemlang.Text.Contains(Language.ToString()))
                    {
                        itemlang.Click();
                        Assert.AreEqual(itemlang.Text, expectedLanguage);
                        Console.WriteLine("Language successfully changed");

                        break;
                    }
                }
            }
        }

        public void Logout()
        {
            try
            {
                NickName.Click();
                List<IWebElement> lstProfileitem = new List<IWebElement>(lstProfile.FindElements(By.TagName("button")));

                if (lstProfileitem.Count > 0)
                {
                    foreach (var item in lstProfileitem)
                    {
                        if (item.Text.Contains("Abmelden"))
                        {
                            Console.WriteLine("Successfully Logging off");
                            item.Click();
            

                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
