using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using GameTwist.PageObjects;
using GameTwist.TestImpl;
using GameTwist.Framework;


namespace GameTwist.TestCases
{
    
    public class TestScripts:Browsers
    {

         
        

        [SetUp]
        public void BeforTest()
        {
            Browsers.Init();
          
        }

               

        [Test] 
        public void GameTwistTest()

        {

            try
            {

                HomePageImpl homepage_impl = new HomePageImpl();
                homepage_impl.Login("sumivisi", "@Password!");               
                System.Threading.Thread.Sleep(3000);
                homepage_impl.CheckLoggedInUser();
                System.Threading.Thread.Sleep(3000);
                if (Browsers.getDriver.Url.Contains("https://www.gametwist.com/de/"))
                    {
                    homepage_impl.SelectLanguage("English");
                    }
                System.Threading.Thread.Sleep(5000);
                homepage_impl.Checknavigation("Slots");
                homepage_impl.Checknavigation("Bingo");
                homepage_impl.Checknavigation("Casino");
                homepage_impl.Checknavigation("Poker");
                System.Threading.Thread.Sleep(5000);
                homepage_impl.Search("Slot");
                System.Threading.Thread.Sleep(5000);
                if (Browsers.getDriver.Url.Contains("https://www.gametwist.com/en/"))
                {
                    homepage_impl.SelectLanguage("Deutsch");
                }
                System.Threading.Thread.Sleep(5000);
                homepage_impl.Logout();
               
               
            }
            catch (Exception)
            {

                throw;
            }

        }
         [TearDown]
        public void AfterTest()
        {
           Browsers.Close();

        }

        }
    }
