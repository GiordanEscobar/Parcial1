using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    //creacion de la clase principal

    public class Alquiler
    {
        public static void Main(string[] args)
        {
            Console.Write("****ALQUILER****");
            int opcion = 0;
            do
            {
                Console.WriteLine("Quien desea acceder\t" +
                                  "1. Administrador\t" +
                                  "2. Cliente\t");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion) { 
                    case 1:
                        do
                        {
                            Console.WriteLine("**SECCION ADMINISTRADOR\t" +
                                "1. Agregar nuevos vehiculos\t" +
                                "2. Actualizar vehiculos\t" +
                                "3. Eliminar vehiculos\t" +
                                "9. Volver al menu anterior\t");
                            opcion=int.Parse(Console.ReadLine());
                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("agregar");
                                break;
                                case 2:
                                    Console.WriteLine("actualizar vehiculo");
                                break;
                                case 3:
                                    Console.WriteLine("eliminar vehiculo");
                                    break;
                                case 9:
                                    Console.WriteLine("volviendo al menu anterior");
                                    break;
                                default:
                                    Console.WriteLine("opcion no valida");
                                    break;
                            }
                        } while (opcion!=9);

                    break;
                    case 2:
                        do
                        {
                            Console.WriteLine("**SECCION CLIENTE\t" +
                                "1. Reservar vehiculo\t" +
                                "2. Devolver vehiculo\t" +
                                "3. Lista de vechículos\t"+
                                "4. Lista de vehículos segun el estado en que se encuentran\t"+
                                "9. Volver al menu anterior\t");
                            opcion=int.Parse(Console.ReadLine());
                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("reservar");
                                    break;
                                case 2:
                                    Console.WriteLine("devolver vehiculo");
                                    break;
                                case 3:
                                    Console.WriteLine("Lista de vehiculos");
                                    break;
                                case 4:
                                    Console.WriteLine("Lista segun el estado");
                                    break;
                                case 9:
                                    Console.WriteLine("volviendo al menu anterior");
                                    break;
                                default:
                                    Console.WriteLine("opcion no valida");
                                    break;
                            }
                        } while (opcion!=9);
                        break;
                    default:
                    break;
                }
            }while (opcion!=0);
        }
    }
}
