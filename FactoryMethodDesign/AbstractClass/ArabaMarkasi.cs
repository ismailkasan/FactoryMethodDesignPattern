using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesign.AbstractClass
{
    /// <summary>
    /// Soyutlanacak base class abstract kelimesi ile belirtilir
    /// </summary>
   abstract class ArabaMarkasi
    {
        /// <summary>
        /// classta bu method override edilmek zorunda. Oyuzden gövdesi burada doldurulmaz.
        /// </summary>
        public abstract void MarkaAdi();
    }
}
