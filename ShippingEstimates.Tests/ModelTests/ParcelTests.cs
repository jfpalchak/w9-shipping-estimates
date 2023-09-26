using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingEstimates.Models;
using System;

namespace ShippingEstimates.Tests
{
  [TestClass]
  public class ParcelTests
  {
    // CONSTRUCTOR
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel(5, 5, 5, 10);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    // GETTER METHODS
    [TestMethod]
    public void GetLength_ReturnsValueOfLength_Int()
    {
      int length = 5;
      
      Parcel newParcel = new Parcel(length, 1, 1, 10);
      int result = newParcel.Length;
      
      Assert.AreEqual(length, result);
    }

    [TestMethod]
    public void GetWidth_ReturnsValueOfWidth_Int()
    {
      int width = 6;
      
      Parcel newParcel = new Parcel(5, width, 1, 10);
      int result = newParcel.Width;

      Assert.AreEqual(width, result);
    }

    [TestMethod]
    public void GetHeight_ReturnsValueOfHeight_Int()
    {
      int height = 10;

      Parcel newParcel = new Parcel(5, 6, height, 10);
      int result = newParcel.Height;

      Assert.AreEqual(height, result);
    }

    [TestMethod]
    public void GetWeight_ReturnsValueOfWeight_Int()
    {
      int weight = 10;

      Parcel newParcel = new Parcel(5, 6, 10, 10);
      int result = newParcel.Weight;

      Assert.AreEqual(weight, result);
    }
  }
}