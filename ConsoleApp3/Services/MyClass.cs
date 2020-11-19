using ConsoleApp3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Services
{
    internal class MyClass : IMyClass
    {
        public MyClass()
        {
        }

        public bool MyMethod()
        {
            Console.WriteLine("MyClass");

            return true;
        }
    }
}