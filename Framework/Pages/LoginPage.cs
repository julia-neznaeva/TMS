using AutotestsApp.Gui.Elements;
using AutotestsApp.Gui.Pages;
using OpenQA.Selenium;
using System;

namespace AutotestsApp.Gui.Forms
{
    public class LoginPage
    {
        private TextBox _email => new TextBox(By.XPath("//input[@type = 'email']"), "Email input");
        private TextBox _password=>new TextBox(By.XPath("//input[@type = 'password']"), "Password input");
        private Button _signIn => new Button(By.XPath("//button[@type = 'submit']"), "SIGN IN button");

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

        public HomePage LogIn(String email, String password)
        {
            EnterEmail(email);
            EnterPassword(password);
            ClickOnSignIn();
            return new HomePage();
        }




    }
}