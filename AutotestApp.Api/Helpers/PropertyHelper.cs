using AutotestApp.Common.Models.Api.RequestData.ProductApi;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutotestApp.Common.Helpers
{
    public class PropertyHelper
    {
        private static PropertyInfo GetPropertyFromModel<TModel>(TModel model, string propInfoName)
        {
            PropertyInfo property
                = model.GetType().GetProperties().FirstOrDefault(s => s.Name == propInfoName);

            Assert.NotNull(property,
                $"Property '{propInfoName}' is missing in {typeof(TModel).Name}");

            return property;
        }

        public static void SetPropertyInModel<TModel, TValue>(TModel model, string propInfoName, TValue value)
        {
            PropertyInfo property = GetPropertyFromModel(model, propInfoName);
            property.SetValue(model, value);
        }

        public static void SetAllPriceTiersToNull(ProductPostRequestData model)
        {
            List<string> allPriceTiers = model.GetType().GetProperties()
               .Where(x => x.Name.StartsWith("PriceTier") && !x.Name.Equals("PriceTiers")).Select(x => x.Name).ToList();

            foreach (string priceTier in allPriceTiers)
            {
                PropertyInfo tier = GetPropertyFromModel(model, priceTier);
                tier.SetValue(model, null);
            }
        }
    }
}
