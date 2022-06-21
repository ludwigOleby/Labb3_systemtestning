using System;
using System.Collections.Generic;

namespace Labb3_systemtestning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator { calculations = new List<string>() };
            c1.userMenu();
        }


    }
}
