using ShopApp.BLL.DTO;
using ShopApp.BLL.Interfaces;
using ShopApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.BLL.Services
{
        
public class ShopsService : BaseService, IShopsService
{
    public ShopsService(IUnitOfWork uwo) : base(uwo) { }

    public void Dispose() => db.Dispose();

    public ShopDTO GetShop(int id)
    {
            var shop = db.ShopsRepository.Get(id);
            return mapper.Map<ShopDTO>(shop);
    }

    public IEnumerable<ShopDTO> GetShops()
    {
            var shops = db.ShopsRepository.GetAll();
            return mapper.Map<IEnumerable<ShopDTO>>(shops);
    }
}
}
