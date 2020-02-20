using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsAndCategories.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;

        public HomeController(HomeContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Product> AllProducts = dbContext.Products.ToList();
            ViewBag.Products = AllProducts;
            return View();
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            List<Category> AllCategories = dbContext.Categories.ToList();
            ViewBag.Categories = AllCategories;
            return View();
        }

        [HttpPost("addproduct")]
        public IActionResult AddProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                List<Product> AllProducts = dbContext.Products.ToList();
                ViewBag.Products = AllProducts;
                return View("Index");
            }
            
        }

        [HttpPost("addcategory")]
        public IActionResult AddCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                dbContext.Categories.Add(newCategory);
                dbContext.SaveChanges();
                return RedirectToAction("Categories");
            }
            else
            {
                List<Category> AllCategories = dbContext.Categories.ToList();
                ViewBag.Categories = AllCategories;
                return View("categories");
            }
        }

        [HttpGet("product/{productId}")]
        public IActionResult ProductPage(int productId)
        {
            Product dbProduct = dbContext.Products.Include
            (p=> p.Categories).ThenInclude(a => a.Category).FirstOrDefault
            (p => p.ProductId == productId);

            List<Category> NotOnProd = dbContext.Categories.Include
            (c => c.Products).Where(c => c.Products.All 
            (a => a.ProductId != productId)).ToList();

            ViewBag.Product = dbProduct;
            ViewBag.OnProd = dbProduct.Categories.ToList();
            ViewBag.NotOnProd = NotOnProd;
            return View("productpage");
        }
        [HttpPost("addcategorytoprod")]
        public IActionResult CategoryToProd(Association newAssoc, int prodId)
        {
            newAssoc.ProductId = prodId;
            dbContext.Associations.Add(newAssoc);
            dbContext.SaveChanges();
            return Redirect($"/product/{prodId}");
        }

        [HttpGet("category/{categoryId}")]
        public IActionResult ShowCategory(int categoryId)
        {
            Category dbCategory = dbContext.Categories.Include(c => c.Products).ThenInclude(a => a.Product).FirstOrDefault(c => c.CategoryId == categoryId);
            List<Product> NotOnCat = dbContext.Products.Include
            (p => p.Categories).Where(p => p.Categories.All
            (a => a.CategoryId != categoryId)).ToList();
            ViewBag.NotOnCat = NotOnCat;
            ViewBag.Category = dbCategory;
            ViewBag.Products = dbCategory.Products.ToList();

            return View();
        }

        [HttpPost("addprodtocategory")]
        public IActionResult ProdToCategory(Association newAssoc, int categoryId)
        {
            newAssoc.CategoryId = categoryId;
            dbContext.Associations.Add(newAssoc);
            dbContext.SaveChanges();
            return Redirect($"/category/{categoryId}");
        }
    }
}
