using AutotestsApp.Gui.Forms;
using System;

namespace AutotestsApp.Gui.Pages
{
    public class HomePage : BaseEntity
    {
        private const String _url = "http://mycarriertms.dotnet.itechcraft.com/customers/home";


        public HomePage()
        {
            new Browser().WaitForPageToLoad(_url);
            Log.Info(String.Format("Moving to home page"));
        }
    }
}