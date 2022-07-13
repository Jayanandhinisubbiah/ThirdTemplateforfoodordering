using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ThirdTemplateforfoodordering.Models;

namespace ThirdTemplateforfoodordering.Controllers
{
    public class AdminController : Controller
    {
        private readonly FoodContext fd;
        public AdminController(FoodContext fd)
        {
            this.fd = fd;
        }
        //public IActionResult Index()
        //{
        //    return View(fd.Products.ToList());
        //}
        //public IActionResult AddProduct()
        //{
        //    //var result = new SelectList(from i in db.Suppliers
        //    //                            select i.Sid).ToList();
        //    //ViewBag.Sid = result;
        //   //var result=new SelectList(from i in )
        //    return View();
        //}
    }
}
