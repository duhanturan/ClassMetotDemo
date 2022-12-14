using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ıhtıyacKrediManager = new IhtıyacKrediManager();           
            ICrediManager tasıtkredimanager = new TasıtKrediManager();         
            ICrediManager konutKrediManager = new KonutKrediManager();
            ICrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLogger = new DataBaseLoggerService();
            ILoggerService filebaseLogger = new FileBaseLoggerService();
            ILoggerService smsLogger = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,smsLogger);

            List<ICrediManager> credis = new List<ICrediManager>() {ıhtıyacKrediManager, tasıtkredimanager};
            //basvuruManager.KrediOnBilgilendirmesiYap(credis);


        }
    }
}
