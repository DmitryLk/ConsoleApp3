using ConsoleApp3.Services;
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mc = new MyClass();

            mc.MyMethod();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}