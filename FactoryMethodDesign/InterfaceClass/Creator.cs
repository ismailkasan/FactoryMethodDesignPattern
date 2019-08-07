using FactoryMethodDesign.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesign.InterfaceClass
{
    class Creator
    {
        public IArabaMarkasi FactoryMethod(Markalar arabaMarkasi)
        {
            IArabaMarkasi araba = null;
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
