using AutoMapper;

namespace AutotestApp.Bl.Mapper
{
    public class AutomapperFactory
    {
        private static IConfigurationProvider Configuration;
        private static IMapper Mapper;

        public static IMapper CreateMapper()
        {
            if (Mapper == null)
            {
                Mapper = new AutoMapper.Mapper(Configuration);
            }

            return Mapper;
        }

        public static void Initialize()
        {
            Configuration = new MapperConfiguration(cfg => {
                //cfg.CreateMap<>(); For contact

                //cfg.CreateMap<Address, BillingAddress>()
                //    .ForMember(b => b.Contact, opts => opts.MapFrom(a => a.Contact));
            });
        }
    }
}
