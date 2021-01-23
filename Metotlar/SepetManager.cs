using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	class SepetManager
	{
		//naming convention - isimlendirme kuralı 
		//syntax 
		public void Ekle(Urun urun)
		{

			Console.WriteLine("Sepete Eklendi : " +urun.Adi);
		}
		//yanlış kullanım yeni değişken geldiğinde Dry'a uygun değil
		public void Ekle2(string urunAdi,string aciklama, double fiyat) 
		{
			Console.WriteLine("Sepete Eklendi : " + urunAdi);
		}

	}
}
