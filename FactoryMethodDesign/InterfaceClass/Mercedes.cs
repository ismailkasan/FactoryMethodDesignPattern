using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesign.InterfaceClass
{
    /// <summary>
    /// Mercedes clasını  IArabaMarkasi interfacesinden türetiyorum.
    /// Ve IArabaMarkasi clasındaki methodun bodysini dolduruyorum
    /// </summary>
    class Mercedes : IArabaMarkasi
    {

        /// <summary>
        /// IArabaMarkasi clasından iplemente edilen ve gövdesi doldurulan method
        /// </summary>
        public void ArabaMarkasi()
        {
            Console.WriteLine("Bu Marka İnterfaceden Oluşturuldu ve Mercedestir dir.");
        }
    }
}
