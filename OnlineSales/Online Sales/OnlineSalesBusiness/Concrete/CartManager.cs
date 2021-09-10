using OnlineSalesBusiness.Abstract;
using OnlineSalesData.Abstract;
using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesBusiness.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository cartRepository;
        public CartManager(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public Cart GetById(string userId)
        {
            return cartRepository.GetById(userId);
        }

        public void InitializeCart(string userId)
        {
            cartRepository.InitializeCart(userId);
        }
    }
}
