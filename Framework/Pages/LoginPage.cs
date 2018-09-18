using AutotestsApp.Gui.Elements;
using AutotestsApp.Gui.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutotestsApp.Gui.Forms
{
    public class LoginPage
    {
        private TextBox _email => new TextBox(By.XPath("//input[@type = 'email']"), "Email input", _driver);
        private TextBox _password=>new TextBox(By.XPath("//input[@type = 'password']"), "Password input", _driver);
        private Button _signIn => new Button(By.XPath("//button[@type = 'submit']"), "SIGN IN button", _driver);
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public LoginPage EnterEmail(String email)
        {
            _email.SetText(email);
            return this;
        }

        public LoginPage EnterPassword(String password)
        {
            _password.SetText(password);
            return this;
        }

        public void ClickOnSignIn()
        {
            _signIn.Click();
        }

        public void LogIn(String email, String password)
        {
            EnterEmail(email);
            EnterPassword(password);
            ClickOnSignIn();
            new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("http://mycarriertms.dotnet.itechcraft.com/customers/home"));

        }




    }
}