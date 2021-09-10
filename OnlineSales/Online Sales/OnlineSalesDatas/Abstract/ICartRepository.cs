using OnlineSalesEntity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSalesData.Abstract
{
    public interface ICartRepository
    {
        void InitializeCart(string userId);
        Cart GetById(string userId);
    }
}
