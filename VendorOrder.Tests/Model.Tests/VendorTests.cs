using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnName_String()
    {
      //Arrange
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, "test");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      //Arrange
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, "test");

      //Act
      string updatedName = "Becky's Cafe";
      newVendor.Name = updatedName;
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnDescription_String()
    {
      string description = "Cafe";
      Vendor newVendor = new Vendor("test", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Cafe";
      Vendor newVendor = new Vendor("test", description);
      string updatedDescription = "Gas Station";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      //Arrange
      List<Vendor> newList = new List<Vendor> { };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendor_VendorList()
    {
      //Arrange
      string name1 = "Suzie's Cafe";
      string name2 = "Becky's Cafe";
      Vendor newVendor1 = new Vendor(name1, "test");
      Vendor newVendor2 = new Vendor(name2, "test");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorReturnsWithId_Int()
    {
      //Arrange
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, "test");

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name1 ="Suzie's Cafe";
      string name2 ="Becky's Cafe";
      Vendor newVendor1 = new Vendor(name1, "test");
      Vendor newVendor2 = new Vendor(name2, "test");

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_ConnectOrderToVendor_OrderList()
    {
      //Arrange
      string title = "Suzie's Cafes Order";
      Order newOrder = new Order(title, "test", 1, "test");
      List<Order> newList =new List<Order> {newOrder};
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, "test");
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}