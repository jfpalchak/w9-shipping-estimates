using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingEstimates.Models;
using System;

namespace ShippingEstimates.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel(5);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    [TestMethod]
    public void GetLength_ReturnsValueOfLength_Int()
    {
      // arrange
      int length = 5;
      //act
      Parcel newParcel = new Parcel(length);
      int result = newParcel.Length;
      //assert
      Assert.AreEqual(length, result);
    }

    [TestMethod]
    public void GetWidth_ReturnsValueOfWidth_Int()
    {
      int width = 6;
      
      Parcel newParcel = new Parcel(5, width);
      int result = newParcel.Width;

      Assert.AreEqual(width, result);
    }
  }
}