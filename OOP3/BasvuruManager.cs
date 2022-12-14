using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(ICrediManager crediManager, ILoggerService loggerService) 
        {
            crediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List< ICrediManager> credis)
        {
            foreach (var credi in credis)
            {
                credi.Hesapla();
            }
        }
    }
}
