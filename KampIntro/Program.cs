using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety - tip güvenliği -string
			//Do not repeat yourself 
			//değer tutucu,alias - kategorietkiket
			
			string kategoriEtiketi = "Kategori";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmısMı = true;
			double dolarDun = 7.35;
			double dolarBugun = 7.45;

			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalış butonu");
			}
			else if (dolarDun<dolarBugun)
			{
				Console.WriteLine("Artış butonu");
			}
			else
			{
				Console.WriteLine("Değişmedi butonu");
			}


			if (sistemeGirisYapmısMı == true)
			{
				Console.WriteLine("Kullanıcı ayarları butonu");
			}
			else
			{
				Console.WriteLine("Giriş yap butonu");
			}


			Console.WriteLine(kategoriEtiketi);
		}
	}
}
