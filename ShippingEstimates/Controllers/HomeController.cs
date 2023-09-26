using Microsoft.AspNetCore.Mvc;
using ShippingEstimates.Models;

namespace ShippingEstimates.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}