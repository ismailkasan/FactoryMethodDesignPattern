﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesign.InterfaceClass
{
    /// <summary>
    /// Bmw  clasını  IArabaMarkasi interfacesinden türetiyorum.
    /// Ve IArabaMarkasi clasındaki methodun bodysini dolduruyorum
    /// </summary>
    class Bmw : IArabaMarkasi
    {

        /// <summary>
        /// IArabaMarkasi clasından iplemente edilen ve gövdesi doldurulan method
        /// </summary>
        public void ArabaMarkasi()
        {
            Console.WriteLine("Bu Marka İnterfaceden Oluşturuldu ve Bmw dir.");
        }
    }
}
