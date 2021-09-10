using OnlineSalesBusiness.Abstract;
using OnlineSalesDatas.Abstract;
using OnlineSalesEntity.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesBusiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            this.productRepository = productRepository;  
        }

        

        public void Create(Product model)
        {
            productRepository.Create(model);
        }

        public List<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public List<Category> GetAllCategory()
        {
           return  productRepository.GetAllCategory();
        }

        public Product GetById(int id)
        {
            return productRepository.GetById(id);
        }

        public int GetCountByCategory(string name)
        {
            return productRepository.GetCounByCategory(name);
        }

        public List<Product> GetProductByCategory(string name, int page, int pageSize)
        {
            return productRepository.GetProductByCategory(name,page,pageSize);
        }

        public Product GetProductDetails(int id)
        {
            return productRepository.GetProductDetails(id);
        }

        public void Remove(Product model)
        {
            productRepository.Remove(model);
        }

        public List<Product> SearchByNameAndDescription(string word)
        {
            return productRepository.SearchByNameAndDescription(word);
        }

        public Product SelectedCategories(int id)
        {
            return productRepository.SelectedCategories(id);
        }

        public void Update(Product model)
        {
            productRepository.Update(model);
        }

        public void Update(Product model, int[] categoryIds)
        {
            productRepository.Update(model, categoryIds);
        }

        public void UpdateCategoryOfProduct(int productId, int[] categoryId)
        {
            productRepository.UpdateCategoryOfProduct(productId, categoryId);
        }
    }
}
