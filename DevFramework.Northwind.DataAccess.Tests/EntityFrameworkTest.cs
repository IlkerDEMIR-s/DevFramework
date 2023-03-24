using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.Northwind.DataAccess.Tests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]public void Get_all_returns_all_products()
        {
            EfProductDal EfproductDal = new EfProductDal();
            var result = EfproductDal.GetList();
            Assert.AreEqual(77, result.Count);
        }
    }


}
