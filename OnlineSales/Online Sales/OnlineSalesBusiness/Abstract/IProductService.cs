using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesBusiness.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        Product GetProductDetails(int id);
        List<Product> GetProductByCategory(string name, int page, int pageSize);
        List<Product> SearchByNameAndDescription(string word);
        int GetCountByCategory(string name);
        List<Category> GetAllCategory();
        void UpdateCategoryOfProduct(int productId, int[] categoryId);
        Product SelectedCategories(int id);
        void Update(Product model, int[] categoryIds);
    }
}
