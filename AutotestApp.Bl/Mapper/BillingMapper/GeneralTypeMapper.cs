using AutotestApp.Bl.Model.GetQuoteData;
using AutotestApp.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Mapper
{
    public static class GeneralTypeMapper
    {
        public static GeneralType MapPackageToGeneralType(PackageTypeModel packageType)
        {
            GeneralType type = new GeneralType();
            type.code = packageType.Code;
            type.description = packageType.Description;
            return type;
        }

        public static List<GeneralType> MapPackageToGeneralTypes(List<PackageTypeModel> packageTypes)
        {
            List<GeneralType> result = new List<GeneralType>();
            packageTypes.ForEach(x => result.Add(MapPackageToGeneralType(x)));
            return result;
        }

        public static GeneralType MapFreightClassToGeneralType(FreightClassModel freightClass)
        {
            GeneralType type = new GeneralType();
            type.code = freightClass.Code;
            type.description = freightClass.Description;
            return type;
        }

        public static List<GeneralType> MapFreightClassesToGeneralTypes(List<FreightClassModel> freightClasses)
        {
            List<GeneralType> result = new List<GeneralType>();
            freightClasses.ForEach(x => result.Add(MapFreightClassToGeneralType(x)));
            return result;
        }
    }
}

