using ShopApp.BLL.DTO;
using ShopApp.BLL.Interfaces;
using ShopApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BLL.Services
{
    public class CategoriesService : BaseService, ICategoriesService
    {
        public CategoriesService(IUnitOfWork uwo) : base(uwo) { }
        public void Dispose() => db.Dispose();

        public IEnumerable<CategoryDTO> GetCategories()
        {
            var categories = db.CategoriesRepository.GetAll();

            return mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public CategoryDTO GetCategory(int id)
        {
            var cat = db.CategoriesRepository.Get(id);

            return mapper.Map<CategoryDTO>(cat);
        }
    }
}
