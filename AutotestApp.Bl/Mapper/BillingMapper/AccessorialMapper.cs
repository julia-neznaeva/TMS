using AutotestApp.Bl.Model.GetQuoteData;
using AutotestApp.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Mapper.BillingMapper
{
    public static class AccessorialMapper
    {
        public static Accessorial MapToAccessorial(AccessorialModel accessorialModel)
        {
            Accessorial accessorial = new Accessorial();
            accessorial.accessorialId = accessorialModel.AccessorialId;
            accessorial.code = accessorialModel.Code;
            accessorial.destinationCode = accessorialModel.DestinationCode;
            accessorial.isOnlyForCanada = accessorialModel.IsOnlyForCanada;
            accessorial.isOnlyForUSA = accessorialModel.IsOnlyForUSA;
            accessorial.name = accessorialModel.Name;
            return accessorial;
        }

        public static List<Accessorial> MapToAccessorials(List<AccessorialModel> accessorialModels)
        {
            List<Accessorial> result = new List<Accessorial>();
            accessorialModels.ForEach(x => result.Add(MapToAccessorial(x)));
            return result;

        }
    }
}
