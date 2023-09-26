// USING DIRECTIVE

namespace ShippingEstimates.Models
{
  public class Parcel
  {
    public int Length { get; set; }

    public Parcel(int length)
    {
      Length = length;
    }
  }
}