using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Models
{
  public class Items
  {
    public string Name { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public int Price { get; set; }

    private static List<Items> _instances = new List<Items> { };

    public Items(string name)
    {
      Name = name;
      _instances.Add(this);
    }

    public Items(string name, int width, int height, int length, int weight)
    {

      Name = name;
      Width = width;
      Height = height;
      Length = length;
      Weight = weight;
      _instances.Add(this);
      // Price = price;
    }

    //  public void Name()
    // }
    // width 5 height 5 length 5
    public void VolumeCalc()
    {
      Volume = Width * Height * Length;
    }

    public void CostToShip()
    {
      Price = ((Volume * 5) + (Weight * 3));
    }

    public static List<Items> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

