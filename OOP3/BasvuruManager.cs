using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        private IEnumerable<object> loggerServices;

        //Method injection
        public object KrediManager { get; private set; }

        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            //Başvuru bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            foreach (var LoggerService in loggerServices)
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
