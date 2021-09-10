using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesDatas.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category GetByIdWithProducts(int CategoryId);

        void RemoveFromCategory(int categoryId,int  productId);
    }
}
