using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesBusiness.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        Category GetByIdWithProduct(int CategoryId);
        void RemoveFromCategory(int categoryId, int productId);

        
    }
}
