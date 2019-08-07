using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesign.AbstractClass
{
    /// <summary>
    /// Creator clasımız objelerin oluşturulmasından sorumlu obje
    /// </summary>
    class Creator
    {
        /// <summary>
        /// ArabaMarkasi tipinde obje oluşturan factory method 
        /// </summary>
        /// <param name="oyunTipi"></param>
        /// <returns></returns>
        public ArabaMarkasi FactoryMethod(Markalar arabaMarkasi)
        {
            ArabaMarkasi araba = null;
            switch (arabaMarkasi)
            {
                case Markalar.Bmw:
                    araba = new Bmw();
                    break;
                case Markalar.Opel:
                    araba = new Opel();
                    break;
                case Markalar.Mercedes:
                    araba = new Mercedes();
                    break;
                default:
                    break;
            }
            return araba;
        }
    }
}
