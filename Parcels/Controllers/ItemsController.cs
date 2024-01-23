using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Items> allItems = Items.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    
    [HttpPost("/items")]
    public ActionResult Create(string name, int weight, int width, int height, int length)
    {
      Items myItem = new Items(name, weight, width, height, length);
      myItem.VolumeCalc();
      myItem.CostToShip();
      return RedirectToAction("Index");
    }
  }
}