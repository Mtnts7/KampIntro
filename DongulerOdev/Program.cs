using System;

namespace DongulerOdev
{
	class Program
	{
		static void Main(string[] args)
		{
			Product product1 = new Product();
			product1.ProductId = 1;
			product1.ProductName = "Kupa";
			product1.ProductPrice = 60;
			product1.ProductDescription = "Altın Yaldızlı Kupa";
			product1.ProductBrand = "Karaca";

			Product product2 = new Product();
			product2.ProductId = 2;
			product2.ProductName = "Kazak";
			product2.ProductPrice = 100;
			product2.ProductDescription = "Yılbaşı Kazağı";
			product2.ProductBrand = "Zara";

			Product product3 = new Product();
			product3.ProductId = 3;
			product3.ProductName = "Kalem";
			product3.ProductPrice = 25;
			product3.ProductDescription = "Uçlu Kalem";
			product3.ProductBrand = "Faber Castell";


			Product[] products = new Product[] { product1, product2, product3 };

			//foreach döngüsü
			foreach (Product product in products)
			{
				Console.WriteLine(product.ProductId + " : " + product.ProductName + " : " + product.ProductBrand + " : " + product.ProductPrice + " : " + product.ProductDescription);
			}
			Console.WriteLine("******************************************");

			//for döngüsü
			for (int i = 0; i < products.Length; i++)
			{
				Console.WriteLine(products[i].ProductId + " : " + products[i].ProductName + " : " + products[i].ProductBrand + " : " + products[i].ProductPrice + " : " + products[i].ProductDescription);
			}

			Console.WriteLine("*******************************************");
			//while döngüsü

			int j = 0;

			while (j<products.Length)
			{
				Console.WriteLine(products[j].ProductId + " : " + products[j].ProductName + " : " + products[j].ProductBrand + " : " + products[j].ProductPrice + " : " + products[j].ProductDescription);
				j++;
			}
			
		}
	}

	class Product 
	{
		public int ProductId { get; set; }
		public int ProductPrice { get; set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public string ProductBrand { get; set; }

	}

}
