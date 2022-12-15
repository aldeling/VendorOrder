using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnName_String()
    {
      //Arrange
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name);

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
      Vendor newVendor = new Vendor(name);

      //Act
      string updatedName = "Becky's Cafe";
      newVendor.Name = updatedName;
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(updatedName, result);
    }
  }
}