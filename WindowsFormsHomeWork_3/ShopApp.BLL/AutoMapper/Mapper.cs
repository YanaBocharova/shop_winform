using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.AutoMapper
{
    public class Mapper
    {
        private static Mapper _instance;

        public IMapper _mapper;
        public static Mapper Instance => 
            _instance ?? (_instance = new Mapper());
        public Mapper()
        {
            var mapCnfg = new MapperConfiguration(cnfg =>
              {
                  cnfg.AddProfile(new MappingProfile());

              });
            _mapper = mapCnfg.CreateMapper();
        }
        public TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }
    }
}
