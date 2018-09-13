﻿using AutotestApp.Common.Models.Api.RequestData.ProductApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AutotestApp.Common.Models.Api.ResponseData.ProductApi
{
    public class ProductElement
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("SKU")]
        public string SKU { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Brand")]
        public string Brand { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("CostingMethod")]
        public string CostingMethod { get; set; }

        [JsonProperty("DropShipMode")]
        public string DropShipMode { get; set; }

        [JsonProperty("DefaultLocation")]
        public string DefaultLocation { get; set; }

        [JsonProperty("Length")]
        public decimal Length { get; set; }

        [JsonProperty("Width")]
        public decimal Width { get; set; }

        [JsonProperty("Height")]
        public decimal Height { get; set; }

        [JsonProperty("Weight")]
        public object Weight { get; set; }

        [JsonProperty("UOM")]
        public string UOM { get; set; }

        [JsonProperty("WeightUnits")]
        public string WeightUnits { get; set; }

        [JsonProperty("DimensionsUnits")]
        public object DimensionsUnits { get; set; }

        [JsonProperty("Barcode")]
        public string Barcode { get; set; }

        [JsonProperty("MinimumBeforeReorder")]
        public decimal MinimumBeforeReorder { get; set; }

        [JsonProperty("ReorderQuantity")]
        public decimal ReorderQuantity { get; set; }

        [JsonProperty("PriceTier1")]
        public string PriceTier1 { get; set; }

        [JsonProperty("PriceTier2")]
        public string PriceTier2 { get; set; }

        [JsonProperty("PriceTier3")]
        public string PriceTier3 { get; set; }

        [JsonProperty("PriceTier4")]
        public string PriceTier4 { get; set; }

        [JsonProperty("PriceTier5")]
        public string PriceTier5 { get; set; }

        [JsonProperty("PriceTier6")]
        public string PriceTier6 { get; set; }

        [JsonProperty("PriceTier7")]
        public string PriceTier7 { get; set; }

        [JsonProperty("PriceTier8")]
        public string PriceTier8 { get; set; }

        [JsonProperty("PriceTier9")]
        public string PriceTier9 { get; set; }

        [JsonProperty("PriceTier10")]
        public string PriceTier10 { get; set; }

        [JsonProperty("PriceTiers")]
        public Dictionary<string, string> PriceTiers { get; set; }

        [JsonProperty("AverageCost")]
        public long AverageCost { get; set; }

        [JsonProperty("ShortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("AdditionalAttribute1")]
        public string AdditionalAttribute1 { get; set; }

        [JsonProperty("AdditionalAttribute2")]
        public string AdditionalAttribute2 { get; set; }

        [JsonProperty("AdditionalAttribute3")]
        public string AdditionalAttribute3 { get; set; }

        [JsonProperty("AdditionalAttribute4")]
        public string AdditionalAttribute4 { get; set; }

        [JsonProperty("AdditionalAttribute5")]
        public string AdditionalAttribute5 { get; set; }

        [JsonProperty("AdditionalAttribute6")]
        public string AdditionalAttribute6 { get; set; }

        [JsonProperty("AdditionalAttribute7")]
        public string AdditionalAttribute7 { get; set; }

        [JsonProperty("AdditionalAttribute8")]
        public string AdditionalAttribute8 { get; set; }

        [JsonProperty("AdditionalAttribute9")]
        public string AdditionalAttribute9 { get; set; }

        [JsonProperty("AdditionalAttribute10")]
        public string AdditionalAttribute10 { get; set; }

        [JsonProperty("AttributeSet")]
        public object AttributeSet { get; set; }

        [JsonProperty("DiscountRule")]
        public object DiscountRule { get; set; }

        [JsonProperty("Tags")]
        public string Tags { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("StockLocator")]
        public string StockLocator { get; set; }

        [JsonProperty("COGSAccount")]
        public object CogsAccount { get; set; }

        [JsonProperty("RevenueAccount")]
        public object RevenueAccount { get; set; }

        [JsonProperty("ExpenseAccount")]
        public object ExpenseAccount { get; set; }

        [JsonProperty("InventoryAccount")]
        public object InventoryAccount { get; set; }

        [JsonProperty("PurchaseTaxRule")]
        public object PurchaseTaxRule { get; set; }

        [JsonProperty("SaleTaxRule")]
        public object SaleTaxRule { get; set; }

        [JsonProperty("LastModifiedOn")]
        public DateTimeOffset LastModifiedOn { get; set; }

        [JsonProperty("Sellable")]
        public string Sellable { get; set; }

        [JsonProperty("PickZones")]
        public string PickZones { get; set; }

        [JsonProperty("BillOfMaterial")]
        public bool BillOfMaterial { get; set; }

        [JsonProperty("AutoAssembly")]
        public bool AutoAssembly { get; set; }

        [JsonProperty("AutoDisassembly")]
        public bool AutoDisassembly { get; set; }

        [JsonProperty("QuantityToProduce")]
        public long QuantityToProduce { get; set; }

        [JsonProperty("AssemblyInstructionURL")]
        public string AssemblyInstructionUrl { get; set; }

        [JsonProperty("AssemblyCostEstimationMethod")]
        public string AssemblyCostEstimationMethod { get; set; }

        [JsonProperty("Suppliers")]
        public List<Supplier> Suppliers { get; set; }

        [JsonProperty("ReorderLevels")]
        public List<ReorderLevel> ReorderLevels { get; set; }

        [JsonProperty("BillOfMaterialsProducts")]
        public List<BillOfMaterialsProduct> BillOfMaterialsProducts { get; set; }

        [JsonProperty("BillOfMaterialsServices")]
        public List<BillOfMaterialsService> BillOfMaterialsServices { get; set; }

        [JsonProperty("Movements")]
        public List<Movement> Movements { get; set; }

        [JsonProperty("Attachments")]
        public List<Attachment> Attachments { get; set; }
    }
}