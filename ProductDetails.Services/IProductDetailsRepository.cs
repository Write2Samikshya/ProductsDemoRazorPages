using System;
using System.Collections.Generic;
using ProductDetails.Models;

namespace ProductDetails.Services
{
    public interface IProductDetailsRepository
    {
        IEnumerable<ProductDetail> GetProductDetails();


    }
}
