using System;
using System.Collections.Generic;
using System.Text;
using OnlineSalesEntity.Entities;

namespace OnlineSalesBusiness.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        Cart GetById(string userId);
    }
}
