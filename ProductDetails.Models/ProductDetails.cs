using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDetails.Models
{
   public  class ProductDetail
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public int Product_Price { get; set; }
        public int Product_Discount { get; set; }

        public string ProductDetailPhotopath { get; set; }

        public ProductCategories? ProductCategories { get; set; }



    }
}
