using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso4
{
    public abstract class Pizzeria
    {
        public abstract void venderPizza();
        public abstract void venderEmpanada();
       
    }
    class pizzeriaItalina : Pizzeria
    {
        public override void venderPizza()
        {
            Console.WriteLine("vendiendo pizza Napolitana-Italiana");
        }
        public override void venderEmpanada()
        {
            Console.WriteLine("vendiendo empanada Capresse-Italiana");
        }
    }
    class pizzeriaArgentina : Pizzeria
    {
        public override void venderPizza()
        {
            Console.WriteLine("vendiendo pizza Cancha-Argentina");
        }
            public override void venderEmpanada()
        {
            Console.WriteLine("vendiendo empanada de Carne-Argentina");
        }
    }

    public class Creadora
    {
        public const int pA = 1;
        public const int pI = 2;

        public static Pizzeria CrearProducto(int TipoBanco) 
        {
            switch (TipoBanco)
            {
                case pA:
                    return new pizzeriaArgentina();
                case pI:
                    return new pizzeriaItalina();
                default:
                    return null;

            }
        }
    }


}
