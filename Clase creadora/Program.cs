using System;

namespace repaso4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Banco bancoActual = Creadora.CrearBanco(3);
            //bancoActual.comprarDolares();

            Console.WriteLine("");
            Console.WriteLine("");

            pizzeriaItalina comprando = new pizzeriaItalina();
            comprando.venderPizza();

            Pizzeria prueba1 = Creadora.CrearProducto(2);
            prueba1.venderEmpanada();

            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
