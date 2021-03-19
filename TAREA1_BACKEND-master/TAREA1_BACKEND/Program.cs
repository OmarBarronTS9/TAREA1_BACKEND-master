using System;
using System.Linq;
using TAREA1_BACKEND.Northwind;

namespace TAREA1_BACKEND
{
    class Program
    {
        //SELECT ProductName, UnitPrice, UnitsInStock FROM Products
        //WHERE CategoryID = '4'

        public static void Product()
        {
            new ProductSC().SelectProduct(4);
        }
        static void Main(string[] args)
        {
            Product();
        }
    }
} 
