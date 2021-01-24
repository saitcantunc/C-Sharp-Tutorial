using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediBaseManager // Interface kuralları içerir ve onu bağlayan classlar onları kendilerine göre içermek zorundalar. Ve genelde operasyonel işlemler için kullanılırlar.
    {
        void Hesapla();
        void BiseyYap();
    } // İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
}
