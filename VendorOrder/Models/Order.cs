using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date;

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
    }
  }
}