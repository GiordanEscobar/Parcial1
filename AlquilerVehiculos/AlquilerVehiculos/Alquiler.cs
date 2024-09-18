using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                            Console.WriteLine("**SECCION ADMINISTRADOR\n" +
                                "1. Agregar nuevos vehiculos\n" +
                                "2. Actualizar vehiculos\n" +
                                "3. Eliminar vehiculos\n" +
                                "9. Volver al menu anterior\n");
                            opcion=int.Parse(Console.ReadLine());
                            switch (opcion)
                            {

                                case 1:
                                    Console.WriteLine("Ingrese la placa del vehiculo: ");
                                    var marca = Console.ReadLine();
                                    Console.WriteLine("Ingrese el modelo del vehiculo: ");
                                    var modelo = Console.ReadLine();
                                    Console.WriteLine("Ingrese el año de fabricación del vehiculo: ");
                                    int aniofabricacion = int.Parse(Console.ReadLine());
                                    Console.WriteLine("**Que tipo de vehiculo se esta registrando\n" +
                                        "1. Automovil\n" +
                                        "2. Camion\n" +
                                        "3. Motocicleta\n" +
                                        "9. Volver al menu anterior\n");
                                    opcion=int.Parse(Console.ReadLine());
                                    switch (opcion) 
                                    {
                                        case 1:
                                            Automovil automovil = new Automovil(marca,modelo, aniofabricacion);
                                            break;
                                        case 2:
                                            Motocicleta motocicleta = new Motocicleta(marca, modelo, aniofabricacion);
                                            break;
                                        case 3:
                                            Camion camion = new Camion(marca, modelo, aniofabricacion);
                                            break;
                                        case 9:
                                            Console.WriteLine("volviendo al menu anterior");
                                            break;
                                    }
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
                        Reservas reservas = new Reservas();
                        ControlGestion cgestion = new ControlGestion();
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
                                    reservas.Reservar();
                                    break;
                                case 2:
                                    reservas.Devolver();
                                    break;
                                case 3:
                                    cgestion.ListaVehiculos();
                                    break;
                                case 4:
                                    Console.WriteLine("Ingrese el estado que desea consultar 0.Disponible 1.Alquilado 2.Mantenimiento");
                                    int respuesta = int.Parse(Console.ReadLine());
                                    Estado estado;
                                    if (respuesta==0)
                                    {
                                        estado=Estado.Disponible;
                                        cgestion.ListarSegunEstado(estado);
                                    }
                                    else if (respuesta==1)
                                    {
                                        estado= Estado.Alquilado;
                                        cgestion.ListarSegunEstado(estado);
                                    }
                                    else if (respuesta==2)
                                    {
                                        estado= Estado.Mantenimiento;
                                        cgestion.ListarSegunEstado(estado);
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Opcion no valida");
                                    }
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
                    case 0:
                        Console.WriteLine("Saliendo, gracias por usar el programa");
                        break;
                    default:
                    break;
                }
            }while (opcion!=0);
        }
    }
}
