using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__20
{
    static class Math
    {
        static public double Plus(double a, double b)
        {
            return a + b;
        }
        static public double Minus(double a, double b)
        {
            return a - b;
        }
        static public double Division(double a, double b)
        {
            return a / b;
        }
        static public double Multiplication(double a, double b)
        {
            return a * b;
        }
        static public int Pow(int a, int b)
        {
            return b > 1 ? a * Pow(a, b - 1) : a;
        }
        static public int Remainder(int a, int b)
        {
            return a % b;
        }
    }
}
