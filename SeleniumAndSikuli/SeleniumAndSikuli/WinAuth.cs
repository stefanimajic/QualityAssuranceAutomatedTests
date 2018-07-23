using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sikuli4Net.sikuli_UTIL;
using Sikuli4Net.sikuli_REST;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace SeleniumAndSikuli
{
    [TestClass]
    public class WinAuth
    {
        private IWebDriver webDriver = null;
        private APILauncher launcher = new APILauncher(true);

        [TestMethod]
        public void WinAuthLogin()
        {
            launcher.Start();
            GetWebDriver("https://myappwithwinauth");

            Screen screen = new Screen();

            //Chrome patterns
            //Pattern pattern_username = new Pattern(@"c:\users\stefani\documents\visual studio 2017\Projects\SeleniumAndSikuli\SeleniumAndSikuli\Images\username.PNG");
            //Pattern pattern_password = new Pattern(@"c:\users\stefani\documents\visual studio 2017\Projects\SeleniumAndSikuli\SeleniumAndSikuli\Images\password.PNG");
            //Pattern pattern_button = new Pattern(@"c:\users\stefani\documents\visual studio 2017\Projects\SeleniumAndSikuli\SeleniumAndSikuli\Images\button.PNG");

            //Mozilla Firefox patterns
            Pattern pattern_username = new Pattern(@"c:\users\stefani\documents\visual studio 2017\Projects\SeleniumAndSikuli\SeleniumAndSikuli\Images\MFusername.PNG");
            Pattern pattern_password = new Pattern(@"c:\users\stefani\documents\visual studio 2017\Projects\SeleniumAndSikuli\SeleniumAndSikuli\Images\MFpassword.PNG");
            Pattern pattern_button = new Pattern(@"c:\users\stefani\documents\visual studio 2017\Projects\SeleniumAndSikuli\SeleniumAndSikuli\Images\MFbutton.PNG");


            screen.Wait(pattern_username, 500);
            screen.Type(pattern_username, "test", KeyModifier.NONE);

            screen.Wait(pattern_password, 500);
            screen.Type(pattern_password, "test", KeyModifier.NONE);

            screen.Wait(pattern_button, 200);
            screen.Click(pattern_button);



            Thread.Sleep(200);
           // webDriver.Quit();
            launcher.Stop();
        }

        private void GetWebDriver(string url)
        {
            //webDriver = new ChromeDriver();
            webDriver = new FirefoxDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
        }
    }
}
