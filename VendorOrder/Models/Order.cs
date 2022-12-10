using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price;

    public Order(string title, string description, int price)
    {
      Title = title;
      Description = description;
    }
  }
}