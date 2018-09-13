using System;
using System.Text;

namespace AutotestApp.Common.Helpers
{
    public class StringUtil
    {
        public string GenerateProductPostfix()
        {
            return $"Created {DateTime.Now.ToString("dd-mm-yyyy HH: mm: ss.ffff")}";
        }

        public string GenerateRandomString(int size)
        {
            size -= 2;
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 1; i < size + 1; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return $"B{builder.ToString().Replace("O", " ").Replace("A", " ")}X";
        }

        public string GenerateCommaDelimitedString(int size)
        {
            return GenerateRandomString(size).Replace("C", ",");
        }

        #region Exception texts generators
        public string GetInvalidSkuErrorMessage(string sku)
        {
            return $"Failed to update product: SKU \"{sku}\" already exists! Please provide different value";
        }

        public string GetBrandNotFoundErrorMessage(string brand)
        {
            return $"Brand '{brand.Trim()}' was not found in reference book";
        }

        public string GetUomNotFoundErrorMessage(string uom)
        {
            return $"Unit of measure with name '{uom}' was not found reference book.";
        }

        public string GetNegativeValueErrorMessage(string dimensionName)
        {
            return $"{dimensionName} value can't be less than zero.";
        }

        public string GetNotFoundUnitMeasureMessage(string unitName)
        {
            return $"Unit of measure with name '{unitName}' was not found.";
        }

        public string GetInvalidAdditionalAttributeMessage(string fieldName, string attributeName)
        {
            string attributeNumber = attributeName.Replace("AdditionalAttribute", string.Empty);

            return $"Invalid value for property '{fieldName}'.Maximum Additional Attribute {attributeNumber}"
                + " field length is 256 characters";
        }

        public string GetInvalidAdditionalAttributeMessageForPut(string attributeName)
        {
            string attributeNumber = attributeName.Replace("AdditionalAttribute", string.Empty);

            return $"Maximum Additional Attribute {attributeNumber} field length is 256 characters";
        }

        public string GetNotFoundDiscountRuleMessage(string discountRule)
        {
            return $"Discount Rule '{discountRule}' was not found in reference book";
        }
        #endregion
    }
}
