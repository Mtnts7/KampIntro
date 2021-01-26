using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //şablon görevi görür-interface-
    //void hesapla bir interface,interface derki birisi bu interfacesi kullanırsa,
    //kullanan bu interface'i içermek zorunda
    //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlari için kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
        
    }
}
