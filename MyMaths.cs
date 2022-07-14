using System;

namespace Mylibrary
{
    public class MyMaths
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine($"{a} + {b} = {(a + b)}");
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {(a - b)}");
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {(a * b)}");
        }

        public static void Divide(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {(a / b)}");
        }

     
    }
}
