using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesDatas.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetProductDetails(int id);
        List<Product> GetProductByCategory(string name,int page,int pageSize);
        int GetCounByCategory(string name);
        List<Product> SearchByNameAndDescription(string word);
        List<Category> GetAllCategory();
        void UpdateCategoryOfProduct(int productId, int[] categoryId);
        Product SelectedCategories(int id);
        void Update(Product model,int[] categoryIds);

    }
}
