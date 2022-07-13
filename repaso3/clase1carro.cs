using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    class clase1carro
    {

        //atributos
        int llantas = 4;
        string color = ("rojo");
        public int pasajeros = 4;
        string gasolina = ("diesel");
        string marca = ("toyota");
        
        //constructor

        //metodo
        public void metodo1DeClase1(string valor) 
        { 

            Console.WriteLine("\n");
            Console.WriteLine("  Elegiste : " + valor );
            Console.WriteLine("  marca :" + marca);
            Console.WriteLine("  pasajeros : " + pasajeros);
            Console.WriteLine("  gasolina :" + gasolina);
            Console.WriteLine("  llantas :" + llantas);
            Console.WriteLine("  color :" + color);
            Console.WriteLine("\n");
        }

    }
}
