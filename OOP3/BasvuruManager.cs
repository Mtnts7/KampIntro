using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        //parametreye ne gönderirisem o xkredimanagerin hesaplası çalışır.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //method injection
        {
            //Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }


    }
}
