using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTwist.PageObjects
{
    class HomePage
    {
        
        [FindsBy(How = How.CssSelector, Using = "#branding > div.branding__content.float--right.authenticated > div.branding__top > div.branding__bar-stretch.float--left > ul > li.branding__user > div > span > span")]
        public IWebElement NickName { get; set; }
        
        [FindsBy(How = How.PartialLinkText, Using = "Slots")]
        public IWebElement Slots { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Bingo")]
        public IWebElement Bingo { get; set; }
        
        [FindsBy(How = How.PartialLinkText, Using = "Casino")]
        public IWebElement Casino { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Poker")]
        public IWebElement Poker { get; set; }

        
        [FindsBy(How = How.Id, Using = "ctl00_cphNavAndSearch_ctl01_gameSearch")]
        public IWebElement txtSearch { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='aspnetForm']/div[4]/div[1]/div/div/ul")]
        public IWebElement lstSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='branding']/div[2]/div[1]/div[4]/ul/li[6]/div[1]/span")]
        public IWebElement btnLang { get; set; }
                                             
        [FindsBy(How = How.XPath, Using = "//*[@id='branding']/div[2]/div[1]/div[4]/ul/li[6]/div[1]/ul")]
        public IWebElement lstLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='branding']/div[2]/div[1]/div[4]/ul/li[2]/div/ul")]
        public IWebElement lstProfile { get; set; }

        [FindsBy(How = How.Id, Using = "login-nickname-phLogin")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "login-password-phLogin")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "phLogin_login_button")]
        public IWebElement SignInButton { get; set; }
        //To enter user name filed

        
        [FindsBy(How = How.Id, Using = "wof_close_x")]
        public IWebElement popupclose { get; set; }


    }
}
