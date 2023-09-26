using Microsoft.AspNetCore.Mvc;
using ShippingEstimates.Models;

namespace ShippingEstimates.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpPost("/parcels")]
    public ActionResult Create(float length, float width, float height, float weight)
    {
      Parcel package = new Parcel(length, width, height, weight);

      return View("../Home/Index", package);
    }
  }
}