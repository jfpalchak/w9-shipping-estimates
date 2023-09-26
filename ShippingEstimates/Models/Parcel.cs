using System.ComponentModel.DataAnnotations;
// USING DIRECTIVE

namespace ShippingEstimates.Models
{
  public class Parcel
  {
    [Required(ErrorMessage = "Length is required.")]
    public float Length { get; set; }
    [Required(ErrorMessage = "Width is required.")]
    public float Width { get; set; }
    [Required(ErrorMessage = "Height is required.")]
    public float Height { get; set; }
    [Required(ErrorMessage = "Weight is required.")]
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