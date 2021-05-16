using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductDetails.Models;
using ProductDetails.Services;

namespace ProductsDemoRazorPages.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductDetailsRepository _productDetailsRepository;

        public IEnumerable<ProductDetail> Productproperty { get; set; }
        public IndexModel(IProductDetailsRepository productDetailsRepository)
        {
            this._productDetailsRepository = productDetailsRepository;
        }
        public void OnGet()
        {
            Productproperty = _productDetailsRepository.GetProductDetails();
        }
    }
}
