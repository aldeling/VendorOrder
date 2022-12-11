using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;

namespace VendorOrder.Test
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatedInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1, "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Suzie's Cafe";
      Order newOrder = new Order(title, "test", 1, "test");

      //Act
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Suzie's Cafe";
      Order newOrder = new Order(title, "test", 1, "test");

      //Act
      string updatedTitle = "Becky's Cafe";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Ten Cookies";
      Order newOrder = new Order("test", description, 1, "test");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Ten Cookies";
      Order newOrder = new Order("test", description, 1, "test");
      string updatedDescription = "Five Cakes";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 10;
      Order newOrder = new Order("test", "test", price, "test");
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      int price = 10;
      Order newOrder = new Order("test", "test", price, "test");
      int updatedPrice = 20;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "12/10/2022";
      Order newOrder = new Order("test", "test", 1, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    {
      string date = "12/10/2022";
      Order newOrder = new Order("test", "test", 1, date);
      string updatedDate = "12/20/2022";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      //Arrange
      List<Order> newList = new List<Order> { };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}