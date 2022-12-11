﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitInStocks = 3;
            product1.UnitPrice = 500;

            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Kalem", UnitPrice = 10, UnitInStocks = 5 } ;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
            


        }
    }
}
