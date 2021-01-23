using System;

namespace Donguler
{
	class Program
	{
		static void Main(string[] args)
		{
			//array - dizi
			string[] kurslar = new string[] {"Yazılım Geliştimr Kampı","programcılar için giriş","java" };

			for (int i = 0; i <kurslar.Length; i++)//i+=2 same  //kurslar.lenght = dizideki eleman sayısı
			{
				Console.WriteLine(kurslar[i]);
			}


			Console.WriteLine("**************");
			//foreach döngüsü
			foreach (string kurs in kurslar)
			{
				Console.WriteLine(kurs);
			}


			Console.WriteLine("------------------");
			//for döngüsü
			for (int i = 1; i <= 10; i=i+2)//i+=2 same
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Haftasonu");
		}
	}
}
