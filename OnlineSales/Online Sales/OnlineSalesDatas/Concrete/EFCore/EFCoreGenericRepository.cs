using Microsoft.EntityFrameworkCore;
using OnlineSalesDatas.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSalesDatas.Concrete.EFCore
{
    public class EFCoreGenericRepository<TModel, TContext> : IRepository<TModel>
        where TModel : class
        where TContext : DbContext, new()
    {
        public void Create(TModel model)
        {
            using(var context=new TContext())
            {
                context.Set<TModel>().Add(model);
                context.SaveChanges();
            };
        }

        public List<TModel> GetAll()
        {
            using (var context = new TContext())
            {
                
                return context.Set<TModel>().ToList();
            };
        }

        public TModel GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TModel>().Find(id);
            };
        }

        public void Remove(TModel model)
        {
            using (var context = new TContext())
            {
                context.Set<TModel>().Remove(model);
                context.SaveChanges();
            };
        }

        public void Update(TModel model)
        {
            using (var context = new TContext())
            {
                context.Entry(model).State = EntityState.Modified;
                context.SaveChanges();
            };
        }
    }
}
