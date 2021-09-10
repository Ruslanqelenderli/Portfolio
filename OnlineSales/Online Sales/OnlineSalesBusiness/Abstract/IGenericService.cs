using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesBusiness.Abstract
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Remove(T model);
        void Update(T model);
        void Create(T model);
    }
}
