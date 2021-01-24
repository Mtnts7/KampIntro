using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager//ProcutService de olabilir
    {

        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }


        //void devam ettirilemez yazılır bitirilir, intte ise devam edilebilir return edildiği için
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}

    }
}
