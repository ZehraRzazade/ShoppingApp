using ShoppingApp.Models.Concret;

using ShoppingApp.Service.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
       
        CategoryService categoryService = new CategoryService();
        ProductService productService = new ProductService();
     
       
        [HttpGet]
        public ActionResult Category() { 


            List<Category> categoryList = categoryService.GetAll();
            return View(categoryList);
            //return PartialView("CategoryModel",categoryList);
        }
        [HttpGet]
        public  ActionResult Index(int categoryId) {
           List<Product> products= productService.GetAllByCategoryId(categoryId);
            return View(products);
        }
    }
}