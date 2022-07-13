using Parte2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2
{
    public class CRUD
    {
     

        public static void Insertar(Vehiculo carro) // Insertar vehículo
        {
            try
            {

                using (TiendaAutosEntities db = new TiendaAutosEntities())
                {
                    if (db.Vehiculoes.Any((x => x.Placa == carro.Placa)))
                    {
                        Console.WriteLine("No se puede agregar este vehiculo porque esta placa ya existe.");
                    }
                    else
                    {
                        db.Vehiculoes.Add(carro);
                        db.SaveChanges();
                        Console.WriteLine("El vehiculo placa {0} ha sido agregado a la BD.", carro.Placa);
                    }

                }
            }
            catch (Exception e)
            {



                Console.WriteLine("No se pudo insertar el registro. Error: {0}", e.Message);
            }
            Console.ReadLine();
        }
        public static void Insertar(string placa, string marca, string combustible, int precio)
        {

            try
            {
                using (TiendaAutosEntities db = new TiendaAutosEntities())
                {
                    if (db.Vehiculoes.Any(x => x.Placa == placa))
                    {
                        Console.WriteLine("No se puede agregar vehiculo, la placa ya existe");
                    }
                    else
                    {
                        Vehiculo carro = new Vehiculo();
                        carro.Placa = placa;
                        carro.Marca = marca;
                        carro.Combustible = combustible;
                        carro.Precio = precio;



                        db.Vehiculoes.Add(carro);
                        db.SaveChanges();
                        Console.WriteLine("El vehiculo placa {0} ha sido agregado a la BD.", carro.Placa);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El vehiculo no se puede agregar. Error: {0}", e.Message);
            }

            //try
            //{
            //    using (TiendaAutosEntities db = new TiendaAutosEntities())
            //    {
            //        if (db.Vehiculoes.Where(d => d.Placa == placa).First() != null)
            //        {
            //            Console.WriteLine(" No se pudo agregar, ya existe en la BD");
            //        }
            //        else
            //        {
            //            Vehiculo carro = new Vehiculo();
            //            carro.Placa = placa;
            //            carro.Marca = marca;
            //            carro.Combustible = combustible;
            //            carro.Precio = precio;
            //            db.Vehiculoes.Add(carro);
            //            db.SaveChanges();
            //            Console.WriteLine(" El vehículo placa {0} ha sido agregado la BD ", carro.Placa);
            //        }


            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(" No se pudo insertar el registro. Error {0}", e.Message);
            //}



        }
        public static void Eliminar(Vehiculo carro)//Elimina objeto 
        {
            try
            {
                using (TiendaAutosEntities db = new TiendaAutosEntities())
                {
                    db.Vehiculoes.Remove(carro);
                    db.SaveChanges();
                    Console.WriteLine("El vehiculo ha sido eliminado del sistema.");
                }
            }
            catch (Exception e)
            {



                Console.WriteLine("No se pudo eliminar. ERROR: {0}", e.Message);
            }
        }
        public static void Eliminar(int ID) //Elimina objeto por ID
        {
            using (TiendaAutosEntities db = new TiendaAutosEntities())
            {
                Vehiculo carroParaEliminar = db.Vehiculoes.Find(ID);
                db.Vehiculoes.Remove(carroParaEliminar);
                db.SaveChanges();
                Console.WriteLine("El vehiculo ha sido eliminado del sistema.");
            }




        }
        public static void Modificar(string PlacaActual, string PlacaNueva) //Actualiza
        {
            try
            {
                using (TiendaAutosEntities db = new TiendaAutosEntities())
                {
                    if (db.Vehiculoes.Any(x => x.Placa == PlacaActual))
                    {
                        Vehiculo carro = db.Vehiculoes.Where(d => d.Placa == PlacaActual).First();
                        carro.Placa = PlacaNueva;
                        db.Entry(carro).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        Console.WriteLine("El vehiculo ID{0} ha modificado su placa a: {1}", carro.idAuto, carro.Placa);
                    }
                    else
                    {
                        Console.WriteLine("Placa no encontrada, no se puede modificar.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo Modificar. ERROR: {0}", e.Message);
            }
        }
        public static void Obtener() 
        {
            Console.WriteLine("  ");
            Console.WriteLine(" Vehículos almacenados en BD : ");
            Console.WriteLine("  ");


            try
            {
                using (TiendaAutosEntities db = new TiendaAutosEntities())
                {
                    var lista = db.Vehiculoes;



                    foreach (var carro in lista)
                    {
                        Console.WriteLine("El vehiculo ID : {0} con la placa : {1} es de combustible tipo : {2} y su precio es de : ${3}", carro.idAuto, carro.Placa, carro.Combustible, carro.Precio);
                    }


                    Console.WriteLine("  ");
                    Console.WriteLine(" oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo ");
                    Console.WriteLine("  ");
                    Console.ReadLine();
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo obtener la lista de vehiculos. Error {0}:", e.Message);
            }
           

        }


    }
}
