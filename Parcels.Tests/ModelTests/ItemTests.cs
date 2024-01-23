using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Items.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Items newItem = new Items("name");
      Assert.AreEqual(typeof(Items), newItem.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string Name = "Mark";
      Items newItem = new Items(Name);
      string result = newItem.Name;
      Assert.AreEqual(Name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      string name = "Mark";
      Items newItem = new Items(name);
      string updatedName = "Tony";
      newItem.Name = updatedName;
      string result = newItem.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetWidth_ReturnsWidth_Int()
    {
      int width = 5;
      Items newItem = new Items("jim",width, 5, 5, 5);
      int result = newItem.Width;
      Assert.AreEqual(width, result);
    }

    [TestMethod]
    public void SetWidth_SetWidth_Int()
    {
      int width = 5;
      Items newItem = new Items("jim",width, 5, 5, 5);
      int updatedWidth = 7;
      newItem.Width = updatedWidth;
      int result = newItem.Width;
      Assert.AreEqual(updatedWidth, result);
    }

    [TestMethod]
    public void GetHeight_ReturnsHeight_Int()
    {
      int height = 4;
      Items newItem = new Items("jim",5, height, 5, 5);
      int result = newItem.Height;
      Assert.AreEqual(height, result);
    }

    [TestMethod]
    public void SetHeight_SetHeight_Int()
    {
      int height = 4;
      Items newItem = new Items("jim",5, height, 5, 5);
      int updatedHeight = 7;
      newItem.Height = updatedHeight;
      int result = newItem.Height;
      Assert.AreEqual(updatedHeight, result);
    }

    [TestMethod]
    public void GetLength_ReturnsLength_Int()
    {
      int length = 4;
      Items newItem = new Items("jim",5, 5, length, 5);
      int result = newItem.Length;
      Assert.AreEqual(length, result);
    }

    [TestMethod]
    public void SetLength_SetLength_Int()
    {
      int length = 4;
      Items newItem = new Items("jim",5, 5, length, 5);
      int updatedLength = 8;
      newItem.Length = updatedLength;
      int result = newItem.Length;
      Assert.AreEqual(updatedLength, result);
    }

    [TestMethod]
    public void GetWeight_ReturnsWeight_Int()
    {
      
      int weight = 10;

      Items newItem = new Items("jim",5, 5, 5, weight);

      int result = newItem.Weight;
      Assert.AreEqual(weight, result);
    }

    [TestMethod]
    public void SetWeight_SetWeight_Int()
    {
     
      int weight = 10;
      Items newItem = new Items("jim",5, 5, 5, weight);
      int updatedWeight = 15;
      newItem.Weight = updatedWeight;
      int result = newItem.Weight;
      Assert.AreEqual(updatedWeight, result);
    }

    [TestMethod]
    public void Volume_SetVolume_Int()
    {
    
      int width = 5;
      int height = 5;
      int length = 5;
    

      Items newItem = new Items("Jim", width, height, length, 0);

      newItem.VolumeCalc();
      Assert.AreEqual(newItem.Volume, 125);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Items> newList = new List<Items> { };
      List<Items> result = Items.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemsList()
    {
      //Arrange
      string name1 = "Jim";
      string name2 = "Tim";
      Items newItem1 = new Items(name1);
      Items newItem2 = new Items(name2);
      List<Items> newList = new List<Items> { newItem1, newItem2 };

      //Act
      List<Items> result = Items.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
