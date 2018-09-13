using System;
using System.Reflection;
using System.Text;

namespace AutotestApp.Common
{
    public static class LogHelper
    {
        public static String GetModelInfo(Object model)
        {
            StringBuilder modelInfo = new StringBuilder(Environment.NewLine);

            foreach (PropertyInfo property in model.GetType().GetProperties())
            {
                Object propertyValue = property.GetValue(model, null);

                if (!String.IsNullOrWhiteSpace(propertyValue?.ToString()))
                {
                    modelInfo
                        .AppendFormat($"   -{property.Name}: {propertyValue}")
                        .AppendFormat(Environment.NewLine);
                }
            }

            return modelInfo.ToString();
        }
    }
}
