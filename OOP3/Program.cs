using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacelerde o interfacei implemente eden classın referans numarasını tutabiliyor.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
         
            IKrediManager tasitKrediManager = new TasıtKrediManager();
        
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabesLoggerService();
            ILoggerService fileLoogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKedisiManager(),new List<ILoggerService> {new DatabesLoggerService(),new SmsLoggerService() });
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> {new SmsLoggerService(), new FileLoggerService() });// new DatabaseLoggerService olarak yazılabilir

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
