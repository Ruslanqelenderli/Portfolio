using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesData.Abstract
{
    interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T model);
        void Remove(T model);
        void Update(T model);
        
    }
}
