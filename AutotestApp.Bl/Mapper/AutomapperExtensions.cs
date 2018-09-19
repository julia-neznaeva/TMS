using AutoMapper;
using System;

namespace AutotestApp.Bl.Mapper
{
    public static class AutomapperExtensions
    {
        public static TDestination MapFromMultiple<TDestination>(this IMapper mapper, params Object[] sources)
        {
            if (sources == null || sources.Length == 0)
            {
                throw new InvalidOperationException("Empty source list");
            }

            TDestination result = (TDestination)mapper.Map(sources[0], sources[0].GetType(), typeof(TDestination));

            for (Int32 i = 1; i < sources.Length; i++)
            {
                mapper.Map(sources[0], result, sources[0].GetType(), typeof(TDestination));
            }

            return result;
        }
    }
}
