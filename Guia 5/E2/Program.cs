using System;
using System.Collections.Generic;
using System.Linq;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermercado super = new Supermercado();
            Console.WriteLine("Las ganancias son: "+ super.ganancias());
        }
    }
}
