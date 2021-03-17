using ShopApp.BLL.AutoMapper;
using ShopApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.Interfaces
{
    public abstract class BaseService
    {
        protected IUnitOfWork db;
        protected Mapper mapper;

        public BaseService(IUnitOfWork uwo)
        {
            db = uwo;
            mapper = Mapper.Instance;
        }
    }
}
