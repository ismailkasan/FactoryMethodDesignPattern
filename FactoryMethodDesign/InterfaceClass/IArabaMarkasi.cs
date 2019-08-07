using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesign.InterfaceClass
{
    /// <summary>
    /// iplemente edilecek base class interface kelimesi ile belirtilir
    /// </summary>
    interface IArabaMarkasi
    {
        /// <summary>
        /// Platform methodu IArabaMarkasi interfacesinden kalıtılan clastta gövdesi oluşturulacağı için gövdesi burada doldurulmaz.
        /// </summary>
        void ArabaMarkasi();
    }
}
