using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesign.AbstractClass
{
    /// <summary>
    /// Soyutlanacak base class abstrat kelimesi ile belirtilir
    /// </summary>
   abstract class ArabaMarkasi
    {
        /// <summary>
        /// Platform methodu abstract kelimesi ile işaretlenerek Oyun clasından kalıtılan
        /// classta bu method override edilmek zorunda. Oyuzden gövdesi burada doldurulmaz.
        /// </summary>
        public abstract void MarkaAdi();
    }
}
