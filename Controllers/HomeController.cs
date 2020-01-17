using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using unitofwork.Models;
using unitofwork.DTO;
using unitofwork.UOW;

namespace unitofwork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _uow;
        public HomeController(ILogger<HomeController> logger
        , IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Welcome";
            dynamic mymodel = new ExpandoObject();
            mymodel.User = _uow.User.GetUsers();
            mymodel.Product = _uow.Product.GetProducts();
            return View(mymodel);
        }
public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserProduct up)
        {
            User u = new User { UserName = up.UserName };
           Product p = new Product { ProductName = up.ProductName,User=u};


            _uow.User.AddUser(u);
            _uow.Product.AddProduct(p);
            _uow.Complete();
            _uow.Dispose();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public string Deleteuser(int userid)
        {
            _uow.User.DeleteUser(userid);
            _uow.Complete();
            _uow.Dispose();
            return "1";
        }



        [HttpPost]
        public string Deleteproduct(int productid)
        {
            _uow.Product.DeleteProduct(productid);
            _uow.Complete();
            _uow.Dispose();
            return "1";
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
