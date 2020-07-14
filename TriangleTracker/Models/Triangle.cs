namespace TriangleTracker
{
  public class Triangle 
  {
    public string IsTriangle(int side1, int side2, int side3)
    {
      // string result = "Equilateral";
      if(side1 == side2 && side2 == side3 && side1 == side3)
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