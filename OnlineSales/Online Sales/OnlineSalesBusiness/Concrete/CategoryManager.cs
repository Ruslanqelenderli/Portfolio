using OnlineSalesBusiness.Abstract;
using OnlineSalesDatas.Abstract;
using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesBusiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Create(Category model)
        {
            categoryRepository.Create(model);
        }

        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return categoryRepository.GetById(id);
        }

        public Category GetByIdWithProduct(int CategoryId)
        {
            return categoryRepository.GetByIdWithProducts(CategoryId);
        }

        public void Remove(Category model)
        {
            categoryRepository.Remove(model);
        }

        public void RemoveFromCategory(int categoryId, int productId)
        {
            categoryRepository.RemoveFromCategory(categoryId, productId);
        }

        public void Update(Category model)
        {
            categoryRepository.Update(model);
        }
    }
}
