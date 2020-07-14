using System;

namespace TriangleTracker.Models
{
  public class Triangle
  {
    public static void Main()
    {
      Console.WriteLine("Enter a value for side one.");
      string strSide1 = Console.ReadLine();
      int side1 = int.Parse(strSide1);

      Console.WriteLine("Enter a value for side two.");
      string strSide2 = Console.ReadLine();
      int side2 = int.Parse(strSide2);

      Console.WriteLine("Enter a value for side three.");
      string strSide3 = Console.ReadLine();
      int side3 = int.Parse(strSide3);

      Triangle TriangleEquilateral = new Triangle();
      Console.WriteLine(TriangleEquilateral.IsTriangle(side1, side2, side3));

    }

    public string IsTriangle(int side1, int side2, int side3)
    {
      // string result = "Equilateral";
      if (side1 == side2 && side2 == side3 && side1 == side3)
      {
        return "Equilateral";
      }
      else
      {
        return "test";
      }
    }
  }
}