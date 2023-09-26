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

    [HttpPost("/parcels")]
    public ActionResult Create(float length, float width, float height, float weight)
    {
      Parcel package = new Parcel(length, width, height, weight);

      return View("Index", package);
    }
  }
}