using AutotestApp.Api;
using AutotestApp.Common.Api.InventoryApi;
using AutotestApp.Common.Helpers;
using AutotestApp.Common.Interfaces;
using AutotestApp.Common.Models.Api;
using AutotestApp.Common.Models.Api.RequestData.ProductApi;
using AutotestApp.Common.Models.Api.ResponseData.ErrorResponse;
using AutotestApp.Common.Models.Api.ResponseData.ProductApi;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace AutotestApp.Api.Api.InventoryApi.ProductApi
{
    public class ProductApi : BaseApi
    {
        RestRequest _request;

        public ProductApi(Credentials credentials)
        {
            _request = new RestRequest(ApiUrl.Product)
            {
                RequestFormat = DataFormat.Json
            };

            _request.AddCredentialsToHeader(credentials);
        }

        public ProductResponse CallGetProduct(ProductGetRequestData product, HttpStatusCode expectedResponseStatusCode = HttpStatusCode.OK)
        {
            ProductResponse response = DoGet<ProductResponse>(_request, product, expectedResponseStatusCode);

            return response;
        }

        public ProductResponse CallPostProduct(IProductRequestData product)
        {
            ProductResponse response = DoPost<ProductResponse>(_request, product);

            return response;
        }

        public ProductResponse CallPutProduct(IProductRequestData product)
        {
            ProductResponse response = DoPut<ProductResponse>(_request, product);

            return response;
        }

        public ApiErrorResponseModel SendInvalidProductRequest(object product, Method method,
            HttpStatusCode expectedResponseStatusCode = HttpStatusCode.OK)
        {
            ApiErrorResponseModel response = null;
            if (method == Method.GET)
            {
                response = DoGet<ApiErrorResponseModel>(_request, product, expectedResponseStatusCode);
            }

            if (method == Method.POST)
            {
                response = DoPost<List<ApiErrorResponseModel>>(_request, product, expectedResponseStatusCode).First();
            }

            if (method == Method.PUT)
            {
                response = DoPut<List<ApiErrorResponseModel>>(_request, product, expectedResponseStatusCode).First();
            }

            return response;
        }

        public ProductElement GetProductById(string id)
        {
            ProductElement foundProduct = CallGetProduct(new ProductGetRequestData { ID = id, Limit = 1 }).Products.FirstOrDefault();

            Assert.NotNull(foundProduct, $"Product wasn't found by id={id} Please check.");

            return foundProduct;
        }

        public ProductElement GetProductByType(string type)
        {
            ProductElement product = GetProducts().Where(x => x.Type == type).First();

            return product;
        }

        public List<ProductElement> GetProducts(int limit = 100, int page = 1)
        {
            List<ProductElement> foundProductList = CallGetProduct(new ProductGetRequestData { Limit = limit, Page = page }).Products;

            Assert.NotNull(foundProductList, $"Products weren't found. Please check.");

            return foundProductList;
        }

        public ProductElement GetRandomProduct()
        {
            List<ProductElement> products = GetProducts();

            ProductElement product = products[new Random().Next(products.Count)];

            return product;
        }
    }
}
