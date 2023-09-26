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
    public void GetLength_ReturnsValueOfLength_Float()
    {
      float length = 5;
      
      Parcel newParcel = new Parcel(length, 1, 1, 10);
      float result = newParcel.Length;
      
      Assert.AreEqual(length, result);
    }

    [TestMethod]
    public void GetWidth_ReturnsValueOfWidth_Float()
    {
      float width = 6;
      
      Parcel newParcel = new Parcel(5, width, 1, 10);
      float result = newParcel.Width;

      Assert.AreEqual(width, result);
    }

    [TestMethod]
    public void GetHeight_ReturnsValueOfHeight_Float()
    {
      float height = 10;

      Parcel newParcel = new Parcel(5, 6, height, 10);
      float result = newParcel.Height;

      Assert.AreEqual(height, result);
    }

    [TestMethod]
    public void GetWeight_ReturnsValueOfWeight_Float()
    {
      float weight = 10;

      Parcel newParcel = new Parcel(5, 6, 10, 10);
      float result = newParcel.Weight;

      Assert.AreEqual(weight, result);
    }

    // VOLUME METHOD
    [TestMethod]
    public void Volume_ReturnsTheProductOfParcelDimensions_Float()
    {
      float length = 5;
      float width = 3;
      float height = 4;
      float volume = length * width * height;

      Parcel newParcel = new Parcel(length, width, height, 10);
      float result = newParcel.Volume();

      Assert.AreEqual(volume, result);
    }

    // COST TO SHIP METHOD
    [TestMethod]
    public void CostToShip_ReturnsCostToShipParcel_Float()
    {
      Parcel newParcel = new Parcel(5, 3, 4, 10);

      float result = newParcel.CostToShip();

      Assert.IsTrue(result > 0);
    }

    public void CostToShip_CalculatesCostUsingGreatestValueBetweenWeightAndDimensionalWeight_Float()
    {
      
      Parcel parcelOne = new Parcel(5, 3, 3, 0.43165466f);
      Parcel parcelTwo = new Parcel(5, 3, 4, 0.3333f);

      float costOne = parcelOne.CostToShip();
      float costTwo = parcelTwo.CostToShip();

      Assert.AreEqual(costOne, costTwo);
    }
  }
}