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
                    Console.WriteLine("Quien desea acceder\n" +
                                      "1. Administrador\n" +
                                      "2. Cliente\n"+
                                      "0. salir");
                    opcion = int.Parse(Console.ReadLine());


                    switch (opcion) { 
                        case 1:
                            do
                            {
                            //hago una instancia de la clase controlGestion
                            ControlGestion controlGestion = new ControlGestion();   
                                Console.WriteLine("**SECCION ADMINISTRADOR\n" +
                                    "1. Agregar nuevos vehiculos\n" +
                                    "2. Actualizar vehiculos\n" +
                                    "3. Eliminar vehiculos\n" +
                                    "9. Volver al menu anterior\n");
                                opcion=int.Parse(Console.ReadLine());
                                switch (opcion)
                                {
                                    case 1:
                                    //hacemos el submenu oara el tipo de vehiculo
                                        Console.WriteLine("**NUEVO VEHICULO\n" +
                                            "1. Automovil\n" +
                                            "2. Camion\n" +
                                            "3. Motocicleta\n" +
                                            "9. Volver al menu anterior\n");
                                        opcion=int.Parse(Console.ReadLine());
                                    if (opcion == 9) break;
                                    Console.WriteLine("Ingrese la marca del vehículo:");
                                    string marca = Console.ReadLine();

                                    Console.WriteLine("Ingrese el modelo del vehículo:");
                                    string modelo = Console.ReadLine();

                                    Console.WriteLine("Ingrese el año de fabricación:");
                                    int añoFabricacion = int.Parse(Console.ReadLine());

                                    Vehiculo nuevoVehiculo = null;
                                    switch (opcion) 
                                        {

                                            case 1:
                                            nuevoVehiculo = new Automovil(marca,modelo,añoFabricacion);
                                            break;

                                            case 2:
                                            nuevoVehiculo = new Camion(marca, modelo, añoFabricacion);
                                            break;

                                            case 3:
                                            nuevoVehiculo = new Motocicleta(marca, modelo, añoFabricacion);
                                            break;

                                        default:
                                            Console.WriteLine("Opcion no valida");

                                            break;
                                        }
                                    if (nuevoVehiculo != null)
                                    {
                                        controlGestion.RegistrarVehiculo(nuevoVehiculo);
                                    }
                                    break;
                                    case 2:
                                        Console.WriteLine("Ingrese la Marca para actualizar:");
                                        String actualizarMarca = Console.ReadLine();

                                        Console.WriteLine("Ingrese el modelo para actualizar:");
                                        String actualizarModelo = Console.ReadLine();

                                        controlGestion.ActualizarEstado(actualizarMarca,actualizarModelo);
                                    break;

                                    case 3:
                                        Console.WriteLine("Ingrese la marca para eliminar:");
                                        String eliminarMarca = Console.ReadLine();

                                        Console.WriteLine("Ingrese el modelo para eliminar:");
                                        String eliminarModelo = Console.ReadLine();

                                        Vehiculo eliminarVehiculo = controlGestion.BuscarVehiculo(eliminarMarca, eliminarModelo);
                                        if(eliminarVehiculo != null)
                                        {
                                            controlGestion.EliminarVehiculo(eliminarVehiculo);
                                        }
                                    break;
                                    case 9:
                                        Console.WriteLine("volviendo al menu anterior");
                                        break;
                                    default:
                                        Console.WriteLine("opcion no valida, vuelva a intentarlo");
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
