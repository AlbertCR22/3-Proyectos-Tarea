using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{

    abstract class carros
    {
        public int cantLlantas = 4;
        public void encender(int torque)
        {
            Console.WriteLine("");
            Console.WriteLine(" El auto está encendido y tiene : " + cantLlantas+" llantas y "+torque +" de torque" );
        }
        public abstract void getAño(int año);
    }
    //class toyotaPickUp:carros
    //{
    //    //atributos
    //    //public int cantLlantas = 4;
    //    //constructor
    //    //metodo
    //    public override void getAño(int año)
    //    {
    //        Console.WriteLine(" Año del pick up es : 2020");
    //    }

    //}

    class usoDomestico : carros
    {
        //atributos
        public int torque = 150;
        //constructor
        //metodo

        //Console.WriteLine(" El auto está encendido y tiene : ");
        //Console.WriteLine(" " + cantLlantas + " llantas");
        //Console.WriteLine(" " + torque + " lbs pie de torque");

        public override void getAño(int año)
        {
            Console.WriteLine(" El año del pick up es " + año);
        }
    }

    class usoPesado : carros
    {
        //atributos
        public int torque = 450;
        //constructor
        //metodo
        //public void encender()
        //{
        //    //Console.WriteLine(" El auto está encendido y tiene : ");
        //    Console.WriteLine( " " + cantLlantas + " llantas");
        //    Console.WriteLine(" " + torque + " lbs pie de torque");
        //}
        public override void getAño(int año)
        {
            Console.WriteLine(" El año del pick up es " + año);
        }
    }

    class cabinaSencilla : carros
    {
        //atributos
        public int cantPasajeros = 2;
        //constructor
        //metodo

        public override void getAño(int año)
        {
            Console.WriteLine(" El año del pick up es " + año);
        }
    }

    class extraCabina: carros
    {
        //atributos
        public int cantPasajeros = 4;
        //constructor
        //metodo
        //public void encender()
        //{
        //    //Console.WriteLine(" Llantas : " + cantLlantas);
        //    //Console.WriteLine(" Pasajeros : " + cantPasajeros);
        //    //Console.WriteLine(" Lbs pie de torque : " + torque);
        //}
        public override void getAño(int año)
        {
            Console.WriteLine(" El año del pick up es "+ año);
        }

    }
}
