using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    class clase3barco
    {
        //atributos
        public string color { get; set; }
        public int peso { get; set; }
        public int cantPersonas { get; set; }
        public string nombre { get; set; }

        //constructor
        public clase3barco(string Color, int Peso, int CantPersonas, string Nombre)
        {
            color = Color;
            peso = Peso;
            cantPersonas = CantPersonas;
            nombre = Nombre;
        }
        //metodos
        public void darNombre()
        {
            Console.WriteLine(" Este barco se llama : " + nombre);
            Console.WriteLine(" Este barco pesa : " + peso+" kg ");
            Console.WriteLine(" Este barco soporta : " + cantPersonas+" personas ");
            Console.WriteLine(" Este barco es de color : " + color);

        }

    }
}
