﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Interfaces
{
    public interface IRepository<TValue,TKey>
        where TValue:class
        where TKey:struct
    {
        TValue Get(TKey id);

        IEnumerable<TValue> GetAll();
        IEnumerable<TValue> GetAll(Func<TValue, bool> predicate);

        void Create(TValue item);
        void Update(TValue item);
        void Delete(TKey item);

    }
}
