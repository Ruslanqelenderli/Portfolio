using Microsoft.EntityFrameworkCore;
using OnlineSalesDatas.Abstract;
using OnlineSalesDatas.Concrete.EFCore;
using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSalesData.Concrete.EFCore
{
    public class EFCoreCategoryRepository : EFCoreGenericRepository<Category, OnlineSalesDb>, ICategoryRepository
    {
        public Category GetByIdWithProducts(int CategoryId)
        {
            using (var context =new OnlineSalesDb())
            {
                var category = context.Categories.Where(x => x.CategoryId == CategoryId)
                                                .Include(x => x.ProductCategories)
                                                .ThenInclude(x => x.Product).FirstOrDefault();
                return category;
            }
            
        }

        public void RemoveFromCategory(int categoryId, int productId)
        {
            using(var context=new OnlineSalesDb())
            {
                var cmd = "Delete from ProductCategory where ProductId=@p0 and CategoryId=@p1";
                context.Database.ExecuteSqlRaw(cmd, productId, categoryId);
            }
        }
    }
}
