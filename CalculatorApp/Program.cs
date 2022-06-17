using System;
using System.Linq;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Plus(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a + b;
        }
        public double Multi(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double S_Triangle(double a, double h)
        {
            return 0.5d * a * h;
        }

        public double S_Circle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public double Average(double[] array)
        {
            double sum = array.Sum();
                        
            return sum / array.Length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
    }
}
