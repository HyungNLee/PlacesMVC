using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View();
    }
    [HttpGet("/places/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/places")]
    public ActionResult Create()
    {
      Place userLocation = new Place(Request.Form["new-name"], Request.Form["new-length"], Request.Form["new-image"]);
      List<Place> allPlaces = Place.GetAll();
      return View("Index", allPlaces);
    }
    // [HttpGet("/places/find")]
    // public ActionResult Find()
    // {
    //   return View("FindLocation");
    // }
    [HttpGet("/places/find/{id}")]
    public ActionResult Details(int id)
    {
      Place place = Place.Find(id);
      return View("FindLocation", place);
    }
  }
}
