using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtıyacKrediManager = new IhtıyacKrediManager();            
            IKrediManager tasitKredisiManager = new TasitKredisiManager(); 
            IKrediManager konutKredisiManager = new KonutKredisiManager();
            //KonutKredisiManager konutKredisiManager = new KonutKredisiManager();  yerine bu da yazılabilir
            //IKrediManager esnafKredisiManager = new EsnafKredisiManager();

            ILoggerService databaseloggerService = new DataBaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtıyacKrediManager, tasitKredisiManager};
           //basvuruManager.KrediOnBilgilendirmeYap(krediler);

        }
    }
}
