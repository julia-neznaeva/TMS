namespace AutotestApp.Common.Сonstants
{
    public class ApiException
    {
        public const string INVALID_ID_EXCPETION = "ID parameter must be of GUID type";
        public const string ID_NOT_PROVIDED_EXCPETION = "Required attribute 'ID' not provided.";
        public const string PRODUCT_WITH_SPECIFIED_ID_NOT_FOUND = "Product with specified 'ID' not found.";
        public const string SPECIFIED_ATTRIBUTE_SKU_ALREADY_EXISTS = "Specified attribute 'SKU' already exists.";
        public const string SPECIFIED_ATTRIBUTE_NAME_ALREADY_EXISTS = "Product with specified 'Name' already exists.";

        public const string PUT_SKU_ALREADY_EXISTS = "Failed to update product: SKU \"TI819AC86LMF\" already exists! Please provide different value";

        public const string SKU_NOT_PROVIDED_EXCPETION = "Required attribute 'SKU' not provided.";
        public const string NAME_NOT_PROVIDED_EXCPETION = "Required attribute 'Name' not provided.";

        public const string SKU_CANNOT_BE_EMPTY = "Attribute 'SKU' can't be empty.";
        public const string NAME_CANNOT_BE_EMPTY = "Attribute 'Name' cannot be empty.";


        public const string SKU_MORE_THAN_50_SYMBOLS = "Required attribute 'SKU' length can't be more than 50 characters.";

        public const string NAME_MORE_THAN_256_SYMBOLS = "Required attribute 'Name' maximum length is 256 characters.";
        public const string NAME_MORE_THAN_256_SYMBOLS_PUT = "Attribute 'Name' maximum length is 256 characters.";

        public const string CATEGORY_MORE_THAN_256_SYMBOLS = "Category name maximum length can't be more than 256 characters.";
        public const string BRAND_MORE_THAN_256_SYMBOLS = "Brand length can't be more than 256 characters";

        public const string TYPE_ATTRIBUTE_IS_INVALID = "Required attribute 'Type' valid values are 'Stock' and 'Service'.";
        public const string TYPE_NOT_PROVIDED_EXCPETION = "Required attribute 'Type' not provided.";

        public const string COSTING_METHOD_NOT_PROVIDED = "Required attribute 'CostingMethod' not provided.";
        public const string COSTING_METHOD_IS_INVALID = "Required attribute 'CostingMethod' not valid.";
        public const string COSTING_METHOD_CANNOT_BE_EMPTY = "CostingMethod cannot be empty.";
        public const string COSTING_METHOD_NOT_VALID = "Attribute 'CostingMethod' not valid.";

        public const string DROPSHIP_METHOD_IS_INVALID = "Provided Drop Ship Mode not valid.";

        public const string UOM_ATTRIBUTE_IS_INVALID = "Required attribute 'UOM' is invalid.";
        public const string UOM_CANNOT_BE_EMPTY = "UOM cannot be empty.";

        public const string CATEGORY_NOT_FOUND = "Category not found.";
        public const string CATEGORY_IS_EMPTY = "Category cannot be empty.";

        public const string SKU_FOR_PUT_MORE_THAN_50_SYMBOLS = "Attribute 'SKU' length can't be more than 50 characters.";

        public const string BARCODE_MORE_THAN_256_SYMBOLS = "Barcode maximum length is 256 characters";

        public const string TAGS_MORE_THAN_256_SYMBOLS = "Tags maximum length is 256 characters";

        public const string PRICE_TIER_VALUE_IS_INVALID = "PriceTier value is invalid.";

        public const string PRICE_TIERS_VALUE_CANNOT_BE_EMPTY = "PriceTiers value cannot be empty.";
        public const string PRICE_TIERS_VALUE_IS_INVALID = "PriceTiers value is invalid.";

        public const string SHORT_DESCRIPTION_IS_INVALID = "Invalid value for property 'ShortDescription'." +
            "Maximum Short Description field length is 500 characters";

        public const string SHORT_DESCRIPTION_MORE_THAN_500_SYMBOLS = "Maximum Short Description field length is 500 characters";

        public const string ATTRIBUTSET_NAME_MORE_THAN_50_SYMBOLS = "AttributeSet Name maximum length is 50 characters";

        public const string ATTRIBUTSET_NOT_FOUND = "Product's attribute set with this name is not found in Additional Attribute Sets reference book";

        public const string DICOUNT_RULE_MORE_THAN_128_SYMBOLS = "Discount Rule maximum name length is 128 characters";

        public const string SATUS_SHOULD_BE_ACTIVE_OR_DEPRECATED = "Status value should be Active or Deprecated.";
        public const string STATUS_NOT_PROVIDED = "Required attribute 'Status' not provided.";
        public const string STATUS_IS_INVALID = "Attribute 'Status' is invalid.";

        public const string STOCK_LOCATOR_MORE_THAN_256_SYMBOLS = "StockLocator maximum length is 256 characters";

        public const string SELLABLE_VALUE_IS_INVALID = "Sellable value should be true or false";

        public const string PICK_ZONES_MORE_THAN_256_SYMBOLS = "PickZones maximum length is 512 characters";


    }
}
