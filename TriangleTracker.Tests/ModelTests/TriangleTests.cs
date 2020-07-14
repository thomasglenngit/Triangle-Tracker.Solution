using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;
// using Triangle;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    
    [TestMethod]
    public void IsTriangle_ThreeSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Equilateral", testTriangle.IsTriangle(5, 5, 5)); 
    }  
  }
}