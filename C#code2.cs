using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethodInt(int x, int y)
    {
      return x + y;
    }

    static double PlusMethodDouble(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethodInt(10, 5);
      double myNum2 = PlusMethodDouble(4.8, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }
}
