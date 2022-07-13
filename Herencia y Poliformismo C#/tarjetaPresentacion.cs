using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    class tarjetaPresentacion
    {
        //atributos
        //public double altura { get; set; }
        //public int edad { get; set; }
        //public int peso { get; set; }


        //public string nombre1 { get; set; }
        //public int altura { get; set; }
        //public int edad { get; set; }
        //public int peso { get; set; }


        //metodo
        public void tarjetaPersonal_1(string nombre)
        {

            int altura = 1;
            int edad = 2;
            int peso = 3;
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine("      Tarjeta Personal 1 ");
            Console.WriteLine("Nombre : " + nombre);
            Console.WriteLine("Altura : " + altura);
            Console.WriteLine("Edad : " + edad);
            Console.WriteLine("Peso : " + peso);
            Console.WriteLine("/////////////////////////////");
        }

        public void tarjetaPersonal_2(string nombre, int altura, int edad, int peso)
        { 
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine("      Tarjeta Personal 2 ");
            Console.WriteLine("Nombre : " + nombre);
            Console.WriteLine("Altura : " + altura);
            Console.WriteLine("Edad : " + edad);
            Console.WriteLine("Peso : " + peso);
            Console.WriteLine("/////////////////////////////");
        }
    }
}
