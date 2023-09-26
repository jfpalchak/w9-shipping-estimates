using System;
// USING DIRECTIVE

namespace ShippingEstimates.Models
{
  public class Parcel
  {
    public float Length { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public float Weight { get; set; }

    public Parcel(float length, float width, float height, float weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public float Volume()
    {
      return Length * Width * Height;
    }

    public float CostToShip()
    {
      float volume = this.Volume();
      float dimWeight = volume / 139;

      if (dimWeight < Weight)
      {
        dimWeight = Weight;
      }

      return (dimWeight * 1.89f) + 10;
    }
  }
}