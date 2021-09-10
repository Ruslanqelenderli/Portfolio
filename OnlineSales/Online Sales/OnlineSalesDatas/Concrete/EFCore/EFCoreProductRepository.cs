using Microsoft.EntityFrameworkCore;
using OnlineSalesDatas.Abstract;
using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSalesDatas.Concrete.EFCore
{
    public class EFCoreProductRepository : EFCoreGenericRepository<Product, OnlineSalesDb>, IProductRepository
    {
        

        public List<Category> GetAllCategory()
        {
            using(var context=new OnlineSalesDb())
            {
                return context.Categories.ToList();
            }
        }

      

        public int GetCounByCategory(string name)
        {
            using (var context = new OnlineSalesDb())
            {
                var products = context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products.Include(x => x.ProductCategories)
                                 .ThenInclude(x => x.Category)
                                 .Where(x => x.ProductCategories.Any(x => x.Category.Url == name));
                }
                return products.Count();
            }
        }

        public List<Product> GetProductByCategory(string name, int page, int pageSize)
        {
            using (var context = new OnlineSalesDb())
            {
                var products = context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products.Include(x => x.ProductCategories)
                                 .ThenInclude(x => x.Category)
                                 .Where(x => x.ProductCategories.Any(x => x.Category.Url == name));
                }
                return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public Product GetProductDetails(int id)
        {
            using (var context = new OnlineSalesDb())
            {
                return context.Products.Where(x => x.ProductId == id)
                                        .Include(x => x.ProductCategories)
                                        .ThenInclude(x => x.Category).FirstOrDefault();
            }
        }

        public List<Product> SearchByNameAndDescription(string word)
        {
            using (var context = new OnlineSalesDb())
            {
                var products = context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(word))
                {
                    products = products.Where(x => x.Name.Contains(word) || x.Description.Contains(word)).AsQueryable();
                }
                return products.ToList();
            }
        }

        public Product SelectedCategories(int id)
        {
            using (var context=new OnlineSalesDb())
            {
                var product = context.Products.Where(x => x.ProductId == id)
                                            .Include(x => x.ProductCategories)
                                            .ThenInclude(x => x.Category).FirstOrDefault();
                return product;
            }
            
        }

        public void Update(Product model, int[] categoryIds)
        {
            using (var context=new OnlineSalesDb())
            {
                var product = context.Products.Include(x => x.ProductCategories).FirstOrDefault(x => x.ProductId == model.ProductId);
                product.Name = model.Name;
                product.Price = model.Price;
                product.ImageUrl = model.ImageUrl;
                product.Description = model.Description;
                product.IsApproved = false;
                product.ProductCategories = categoryIds.Select(x => new ProductCategory
                {
                    CategoryId = x,
                    ProductId = product.ProductId
                }).ToList();
                context.SaveChanges();
            }
        }

        public void UpdateCategoryOfProduct(int productId, int[] categoryId)
        {
            using (var context=new OnlineSalesDb())
            {
                var product = context.Products.FirstOrDefault(x => x.ProductId == productId);
                product.ProductCategories = categoryId.Select(x => new ProductCategory
                {
                    ProductId = productId,
                    CategoryId = x
                }).ToList();
                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
