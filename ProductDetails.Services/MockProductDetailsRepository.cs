using ProductDetails.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDetails.Services
{
    public class MockProductDetailsRepository : IProductDetailsRepository
    {
        private  readonly List<ProductDetail>  _ProductdetailsLists;

            public MockProductDetailsRepository()
        {
            _ProductdetailsLists = new List<ProductDetail>()
            {
                new ProductDetail(){Product_ID=11,Product_Name="Camera",Product_Price=1100,
                    ProductCategories=ProductCategories.ShoppingGoods,Product_Discount=10},

                 new ProductDetail(){Product_ID=11,Product_Name="Lights",Product_Price=1200,
                    ProductCategories=ProductCategories.SpecialtyGoods,Product_Discount=20}

            };
        }

        public IEnumerable<ProductDetail> GetProductDetails()
        {
            return _ProductdetailsLists; 
        }
    }
}
