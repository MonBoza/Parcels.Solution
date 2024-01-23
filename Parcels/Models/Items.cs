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


// Looking at your code, it seems like you're storing Items objects and you might want to access these items later on. If you need to frequently find an item by its name or another unique attribute, a dictionary could be more efficient. For example, if you wanted to quickly find the Items object for "Jim's Parcel", a dictionary with the name as the key would be super handy.

// However, if the order of items matters, or if you don't need to access items by a specific key, then sticking with a list is totally fine. It’s simpler and does the job well if you're mostly just adding to the collection and iterating over it.

// Using a List:
// Simple and Straightforward: Lists are great when you just need to keep a collection of items and don't need to access them via a specific key. You're just adding your items, maybe iterating over them, or accessing them by index.

// Ordering: A list maintains the order of items as they are added. If the order in which your Items are added matters, a list is a good choice.

// Duplicates: Lists allow duplicates. If your application might have identical items with different attributes, a list can handle that easily.

// Using a Dictionary:
// Fast Lookups: If you need to access items by a specific key (like an ID or a name), dictionaries are much faster than lists. They use a key-value pair for storing data, which makes finding an item super quick.

// Uniqueness: The keys in a dictionary must be unique. This is great if you need to ensure there are no duplicates based on a certain attribute.

// No Ordering: Dictionaries don't maintain the order of items. If you add items to a dictionary, you can't expect them to be in the same order when you retrieve them.
