using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.ProductCategory;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        public ProductCategorySearchModel SearchModel; 
        public List<ProductCategoryViewModel> productCategories;
        private readonly IProductCategoryApplication _productCategoryApplication;

        public IndexModel( IProductCategoryApplication productCategoryApplication)
        {
            
            _productCategoryApplication = productCategoryApplication;
        }

        public void OnGet(ProductCategorySearchModel searchModel)
        {
            productCategories = _productCategoryApplication.Search(searchModel);
        }
    }
}
