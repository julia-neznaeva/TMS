using AutotestsApp.Gui.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotetsApp.Gui.Framework.Pages
{
    

    public class QuotePage: BaseEntity
    {
        private const String _url = "http://mycarriertms.dotnet.itechcraft.com/customers/quote";

        public QuotePage()
        {
            new Browser().WaitForPageToLoad(_url);
            Log.Info(String.Format("Moving to home page"));
        }
    }
}
