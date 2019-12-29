using System;

namespace lambdaIzraz
{
    delegate double Circle(double r); //P=r*r*PI//
    class Program
    {
        static void Main(string[] args)
        {
            Circle Operation = (double r) =>
              {
                  double PI = 3.14;
                  double result = r * r * PI;
                  return result;
              };
            Console.WriteLine("Result is: {0}", Operation(2));
        }
     
    }
}
