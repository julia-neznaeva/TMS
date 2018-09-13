using AutotestsApp.Gui.Elements;
using OpenQA.Selenium;

namespace AutotestsApp.Gui.Forms
{
    public class LandingPage: BaseEntity
    {
        public Link SignInLink => new Link(By.XPath("//ul[@class = 'header-menu']//li[.='Sign In']"), "SignIn Link");

        public LoginPage SignIn()
        {
            SignInLink.Click();
            return new LoginPage();
        }
    }
}
