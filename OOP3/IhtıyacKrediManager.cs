using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtıyacKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}
