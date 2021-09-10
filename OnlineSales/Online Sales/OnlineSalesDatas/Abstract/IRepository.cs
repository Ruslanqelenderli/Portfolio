using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesDatas.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Create(T model);
        void Update(T model);
        void Remove(T model);
        T GetById(int id);
    }
}
