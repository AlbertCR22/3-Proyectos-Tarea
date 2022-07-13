using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    class Pizzeria
    {
        public String producto1 { get; set;}
        public String producto2 { get; set;}
        public String producto3  { get; set;}
        public String producto4 { get; set;}

        public void vender()
        {

        }

    }

    class PizzeriaItaliana
    {
        public String producto1 = ("Pizza italiana");
        public String producto2 = ("Empanadas italiana");
    }

    class PizzeriaArgentina
    {
        public String producto1 = ("Pizza Argentina");
        public String producto2 = ("Empanadas Argentina ");
    }


    class Pizza : venta
    {
        public void vender()
        {
            Console.WriteLine(" Venta de XX pizza ");
        }
    }

    class Empanada : venta
    {

        public void vender()
        {
            Console.WriteLine(" Venta de YY pizza ");
        }
    }

    class venta 
    {
        public void vender(string pais)
        {
            if (pais == "Argentina") 
            {
                Console.WriteLine(" Venta de productos argentinos ");
            }
            if (pais == "Italia")
            {
                Console.WriteLine(" Venta de productos italianos ");
            }

        }
    }

}
