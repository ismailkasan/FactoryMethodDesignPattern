using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesign.AbstractClass
{
    /// <summary>
    /// Opel platformunun clasını soyutlanmış ArabaMarkasi clasından türetiyorum.
    /// Ve ArabaMarkasi klasındaki abstract olarak tanımlanmış methodu override ederek, methodun body sini dolduruyorum
    /// </summary>
    class Opel : ArabaMarkasi
    {
        /// <summary>
        /// ArabaMarkasi clasından iplemente edilen ve override edilen method
        /// </summary>
        public override void MarkaAdi()
        {
            Console.WriteLine("Bu araba Abstarctan Oluşturuldu ve Markası Opel dir.");
        }

    }
}
