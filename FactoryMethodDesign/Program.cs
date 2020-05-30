using FactoryMethodDesign.AbstractClass;
using System;

namespace FactoryMethodDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AbstractanArabaOlustur();

            InterfacednArabaOlustur();
            Console.Read();
        }

        /// <summary>
        /// Abstarc classstan oluşturduğumuz arabalar
        /// </summary>
        public static void  AbstractanArabaOlustur()
        {
            Creator creator = new Creator();
            ArabaMarkasi bmw = creator.FactoryMethod(Markalar.Bmw);
            ArabaMarkasi opel = creator.FactoryMethod(Markalar.Opel);
            ArabaMarkasi mercedes = creator.FactoryMethod(Markalar.Mercedes);


            bmw.MarkaAdi();
            opel.MarkaAdi();
            mercedes.MarkaAdi();

        }

        /// <summary>
        /// İnterfaceden oluşturduğumuz arabalar
        /// </summary>
        public static void InterfacednArabaOlustur()
        {
           InterfaceClass.Creator creator = new InterfaceClass.Creator();
            InterfaceClass.IArabaMarkasi bmw = creator.FactoryMethod(Markalar.Bmw);
            InterfaceClass.IArabaMarkasi opel = creator.FactoryMethod(Markalar.Opel);
            InterfaceClass.IArabaMarkasi mercedes = creator.FactoryMethod(Markalar.Mercedes);

            bmw.ArabaMarkasi();
            opel.ArabaMarkasi();
            mercedes.ArabaMarkasi();

        }
    }
}
