using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{

    //  \n simbolo de salto de linea
    class clase2avion
    {
        //atributos
        string tipo = "Aereo";
        int llantas = 6;
        int asientos = 80;

        //string color = "blanca";
        //string modalidad = "manual";
        //constructor

        //metodo
        public void metodo1Declase2(string valor)
        {
            Console.WriteLine("\n");
            Console.WriteLine("  Elegiste : "+ valor);
            Console.WriteLine("  tipo " + tipo);
            Console.WriteLine("  llantas " + llantas);
            Console.WriteLine("  asientos " + asientos);

            //Console.WriteLine("  color " + color);
            //Console.WriteLine("  modalidad " + modalidad);
            //Console.WriteLine("\n");

        }
    }
}
