using AutotestApp.Api.Api.Quote1StepApi;
using AutotestApp.Bl.Mapper;
using AutotestApp.Bl.Model.GetQuoteData;
using AutotestApp.Bl.QuoteServices;
using AutotestApp.Common.Api;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.ApiTest
{
    [TestFixture]
    public class GetQuoteDataApiTests: BaseApiTest
    {
        private QuoteService _quoteService;
        private Int32 _customerId { get; set; }

        [OneTimeSetUp]
        public void SetToken()
        {
            AutomapperFactory.Initialize();
            _quoteService = new QuoteService();
        }

        [Test]
        public void GetQuoteDataAccessorial()
        {
            TokenApi tokenApi = new TokenApi();

            String token = tokenApi.GetToken("kate.test21@gmail.com", "123456789").Token;

            GetQuoteDataApi getQuoteData = new GetQuoteDataApi(token);

            var quote = getQuoteData.Request();

            IEnumerable<Accessorial> originSiteAccessorialFromDB = _quoteService.GetOriginalSiteAccessorials().OrderBy(x=>x.accessorialId);
            IEnumerable<Accessorial> originSiteAccessorialFromApi = quote.Quote.accessorials.originalSite.OrderBy(x=>x.accessorialId);

            originSiteAccessorialFromDB.Should().BeEquivalentTo(originSiteAccessorialFromApi, "Original Site Accessorial are different");

            IEnumerable<Accessorial> originNonCommercialFromDB = _quoteService.GetOriginalNonCommercialAccessorials().OrderBy(x => x.accessorialId);
            IEnumerable<Accessorial> originNonCommercialFromApi = quote.Quote.accessorials.originalNonCommercial.OrderBy(x => x.accessorialId);

            originNonCommercialFromDB.Should().BeEquivalentTo(originNonCommercialFromApi, "Original Non Commercial Accessorial are different");

            IEnumerable<Accessorial> originAccessorialFromDB = _quoteService.GetOriginalAccessorials().OrderBy(x => x.accessorialId);
            IEnumerable<Accessorial> originAccessorialFromApi = quote.Quote.accessorials.originAccessorials.OrderBy(x => x.accessorialId);

            originAccessorialFromDB.Should().BeEquivalentTo(originAccessorialFromApi, "Original Non Commercial Accessorial are different");

            IEnumerable<Accessorial> destinationAccessorialFromDB = _quoteService.GetDestinationAccessorials().OrderBy(x => x.accessorialId);
            IEnumerable<Accessorial> destinationAccessorialFromApi = quote.Quote.accessorials.destinationAccessorials.OrderBy(x => x.accessorialId);

            destinationAccessorialFromDB.Should().BeEquivalentTo(destinationAccessorialFromApi, "Original Non Commercial Accessorial are different");

            IEnumerable<Accessorial> destinationSiteAccessorialFromDB = _quoteService.GetDestinationSiteAccessorials().OrderBy(x => x.accessorialId);
            IEnumerable<Accessorial> destinationSiteAccessorialFromApi = quote.Quote.accessorials.destinationSite.OrderBy(x => x.accessorialId);

            destinationSiteAccessorialFromDB.Should().BeEquivalentTo(destinationSiteAccessorialFromApi, "Original Non Commercial Accessorial are different");

            IEnumerable<Accessorial> destinationNonCommercialAccessorialFromDB = _quoteService.GetDestinationNonCommercialAccessorials().OrderBy(x => x.accessorialId);
            IEnumerable<Accessorial> destinationNonCommercialAccessorialFromApi = quote.Quote.accessorials.destinationNonCommercial.OrderBy(x => x.accessorialId);

            destinationNonCommercialAccessorialFromDB.Should().BeEquivalentTo(destinationNonCommercialAccessorialFromApi, "Original Non Commercial Accessorial are different");

            IEnumerable<Accessorial>nonCommercialAccessorialFromDB = _quoteService.GetNonCommercialAccessorials().OrderBy(x => x.accessorialId);
            IEnumerable<Accessorial> nonCommercialAccessorialFromApi = quote.Quote.accessorials.nonSpecificAccessorials.OrderBy(x => x.accessorialId);

            nonCommercialAccessorialFromDB.Should().BeEquivalentTo(nonCommercialAccessorialFromApi, "Original Non Commercial Accessorial are different");

        }

        [Test]
        public void GetQuoteDataPackageTypes()
        {
            TokenApi tokenApi = new TokenApi();

            String token = tokenApi.GetToken("kate.test21@gmail.com", "123456789").Token;

            GetQuoteDataApi getQuoteData = new GetQuoteDataApi(token);

            List<GeneralType>packageTypesFromApi = getQuoteData.Request().Quote.packageTypes;
            List<GeneralType>packageTypesFromDB = _quoteService.GetPackageType();

            packageTypesFromDB.Should().BeEquivalentTo(packageTypesFromApi, "Package types are different");
        }

        [Test]
        public void GetQuoteDataHazardPackingTypes()
        {
            TokenApi tokenApi = new TokenApi();

            String token = tokenApi.GetToken("kate.test21@gmail.com", "123456789").Token;

            GetQuoteDataApi getQuoteData = new GetQuoteDataApi(token);

            List<GeneralType> hazardPackingTypesFromApi = getQuoteData.Request().Quote.hazardPackingTypes;
            List<GeneralType> hazardPackingTypessFromDB = _quoteService.GetHazardPackingTypes();

            hazardPackingTypessFromDB.Should().BeEquivalentTo(hazardPackingTypesFromApi, "Hazard Packing Types are different");
        }

        [Test]
        public void GetQuoteDataDisabledDate()
        {
            TokenApi tokenApi = new TokenApi();

            String token = tokenApi.GetToken("kate.test21@gmail.com", "123456789").Token;

            GetQuoteDataApi getQuoteData = new GetQuoteDataApi(token);

            List<DisabledDate> disablesDateFromApi = getQuoteData.Request().Quote.disabledDates;
            List<DisabledDate> disablesDateFromDB = _quoteService.GetDisabledDates();

            disablesDateFromDB.Should().BeEquivalentTo(disablesDateFromApi, "Disabled Date are different");

        }

        [Test]
        public void GetQuoteDateFreightClass()
        {
            TokenApi tokenApi = new TokenApi();

            String token = tokenApi.GetToken("kate.test21@gmail.com", "123456789").Token;

            GetQuoteDataApi getQuoteData = new GetQuoteDataApi(token);

            List<GeneralType> freightClassesFromApi = getQuoteData.Request().Quote.freightClasses;
            List<GeneralType> freightClassesFromDB = _quoteService.GetFreightClass();

            freightClassesFromDB.Should().BeEquivalentTo(freightClassesFromApi, "Freight Classes are different");
        }

        [Test]
        public void GetSpecialInstructionDefaultText()
        {
            TokenApi tokenApi = new TokenApi();

            String token = tokenApi.GetToken("kate.test21@gmail.com", "123456789").Token;

            GetQuoteDataApi getQuoteData = new GetQuoteDataApi(token);

            String textApi = getQuoteData.Request().Quote.specialInstructionDefaultText;

            String textDB = _quoteService.GetCustomerInfo("kate.test21@gmail.com").SpecialInstructionDefaultText;

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(textDB, textApi)); 
        }

        [Test]
        public void GetIsRequiredNmfcCode()
        {
            TokenApi tokenApi = new TokenApi();

            String token = tokenApi.GetToken("kate.test21@gmail.com", "123456789").Token;

            GetQuoteDataApi getQuoteData = new GetQuoteDataApi(token);

            Boolean IsNmfcApi = getQuoteData.Request().Quote.isRequiredNmfcCode;

            Boolean IsNmfDb = _quoteService.GetCustomerInfo("kate.test21@gmail.com").IsRequiredNmfcCode;

            AssertsAccumulator.Accumulate(() => Assert.AreEqual(IsNmfDb, IsNmfcApi));
        }

    }
}
