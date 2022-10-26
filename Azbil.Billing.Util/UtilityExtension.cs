using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Azbil.Billing.Util
{
    public class UtilityExtension
    {
        public static TTarget MapModel<TTarget, TSource>(TSource dataModel)
         where TTarget : class
         where TSource : class
        {
            var config = new MapperConfiguration(map => { map.CreateMap<TSource, TTarget>(); });

            var mapper = config.CreateMapper();

            return mapper.Map<TTarget>(dataModel);
        }

        public static TTarget MapModel<TTarget, TSource, TTarget2, TSource2>(TSource dataModel)
         where TTarget : class
         where TSource : class
        {
            var config = new MapperConfiguration(map =>
            {
                map.CreateMap<TSource, TTarget>();
                map.CreateMap<TSource2, TTarget2>();
            });

            var mapper = config.CreateMapper();

            return mapper.Map<TTarget>(dataModel);
        }

        public static TDestination MapModel<TSource, TDestination>(TSource dataModel, TDestination dataModel2)
         where TSource : class
         where TDestination : class
        {
            var config = new MapperConfiguration(map => { map.CreateMap<TSource, TDestination>(); });

            var mapper = config.CreateMapper();

            return mapper.Map<TSource, TDestination>(dataModel, dataModel2);
        }

        public static List<TTarget> MapModel<TTarget, TSource>(List<TSource> dataModel)
        {
            var config = new MapperConfiguration(map => {
                map.CreateMap<TSource, TTarget>();
            });

            var mapper = config.CreateMapper();

            return mapper.Map<List<TSource>, List<TTarget>>(dataModel);
        }
    }
}
