using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; }
  

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}