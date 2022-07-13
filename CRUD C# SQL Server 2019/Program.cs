using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parte2.Model;


namespace Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ****************************************************************
            //  Todos los metodos funcionan, sólo descomentar el que desea probar
            //  ****************************************************************


            //inserta vehículo completo, cambie los parámetros con comillas y luego ejecute el "obtener" para verificar si se agregó a la BD

            Vehiculo carro = new Vehiculo();
            //carro.idAuto = 1005;
            carro.Placa = "HSBC";
            carro.Marca = "Mack";
            carro.Combustible = "Diesel";
            carro.Precio = 20000;
            //CRUD.Insertar(carro);                                     //aquí inserta objeto completo conlos parámetros anteriores
            
            //CRUD.Insertar("PlacaNueva", "Chino", "Electrico", 88888); //inserta por parámetros

            //CRUD.Eliminar(1003);                                      //este método elimina por ID, revise primero la BD con el método Obtener
            //CRUD.Eliminar(carro);                                     // éste elimina elemento completo instanciado en este program "carro", active el id comentado para que la eliminacion surja efecto y cambie los valores con "" según estén en la BD

            CRUD.Obtener();                                             //nos muestra todos los vehículos de la BD

            //CRUD.Modificar("PlacaNueva","PlacaRetocada") ;            //Modifica o edita algún elemento de la BD por placa! 
        }


    }
}
