using ShopApp.DAL.EF;
using ShopApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Interfaces
{
    public abstract class BaseRepository<TValue,TKey> :
        IRepository<TValue, TKey>
        where TValue:class
        where TKey:struct
    {

        protected ShopContext context;
        protected DbSet<TValue> table;
        public BaseRepository(ShopContext context)
        {
            this.context = context;
            table = context.Set<TValue>();
        }
        public virtual void Create(TValue item)
        {
            table.Add(item);
            context.SaveChanges();
        }

        public virtual void Delete(TKey item)
        {
            var itm = Get(item);
            table.Remove(itm);
            context.SaveChanges();

        }

        public virtual TValue Get(TKey id)
        {
            return table.FirstOrDefault(new Func<TValue, bool>(itm => (itm as BaseEntity<TKey>).Id.Equals(id)));
            
        }

        public virtual IEnumerable<TValue> GetAll()
        {
            return table.ToList();
        }

        public virtual IEnumerable<TValue> GetAll(Func<TValue, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public  abstract void Update(TValue item);
       
    }
}
