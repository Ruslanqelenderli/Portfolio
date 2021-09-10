using Microsoft.EntityFrameworkCore;
using OnlineSalesData.Abstract;
using OnlineSalesDatas.Concrete.EFCore;
using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSalesData.Concrete.EFCore
{
    public class EFCoreCartRepository : ICartRepository
    {
        public Cart GetById(string userId)
        {
            using (var context = new OnlineSalesDb())
            {
                return context.Carts.Include(x => x.CartItems)
                                    .ThenInclude(x => x.Product)
                                    .FirstOrDefault(x => x.UserId == userId);
            }
        }

        public void InitializeCart(string userId)
        {
            using (var context=new OnlineSalesDb())
            {
                var cart = new Cart();
                cart.UserId = userId;
                context.Carts.Add(cart);
            }
            
        }
    }
}
