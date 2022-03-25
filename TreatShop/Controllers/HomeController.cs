using Microsoft.AspNetCore.Mvc;
using TreatShop.Models;
using System.Linq;

namespace TreatShop.Controllers
{
    public class HomeController : Controller
    {
      private readonly TreatShopContext _db;
      public HomeController(TreatShopContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewData["flavors"] = _db.Flavors.ToList();
        ViewData["treats"] = _db.Treats.ToList();
        return View();
      }
    }
}