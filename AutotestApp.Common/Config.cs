using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Dynamic;

namespace AutotestApp.Common
{
    public static class Config
    {
        public class Items : DynamicObject
        {
            private NameValueCollection _items;

            public Items()
            {
                _items = ConfigurationManager.AppSettings;
            }

            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = _items[binder.Name];
                return result != null;
            }
        }

        public static dynamic Instance { get { return new Items(); } }
    }
}
