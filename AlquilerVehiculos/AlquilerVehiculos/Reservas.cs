using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    
    public class Reservas : IGestionReservas
    {
        ControlGestion cgestion = new ControlGestion();

        public void ConsultarHistorial()
        {
            if (cgestion.vehiculos==null)
            {
                Console.WriteLine("No se registran vehiculos");
            }
            else
            {
                Console.WriteLine("Ingrese la placa del vehiculo que desea devolver: ");
                var marca = Console.ReadLine();
                Console.WriteLine("Ingrese la placa del vehiculo que desea devolver: ");
                var modelo = Console.ReadLine();
                Vehiculo objvehiculo = cgestion.BuscarVehiculo(marca, modelo);
                if (objvehiculo==null)
                {
                    Console.WriteLine("No existe el auto que busca intente nuevamente");
                }
                else
                {
                    if (cgestion.historialreservas.ContainsKey(objvehiculo))
                    {
                        Console.WriteLine($"Historial de reservas para el vehículo {objvehiculo.Marca}, {objvehiculo.Modelo}:");
                        foreach (var reserva in cgestion.historialreservas[objvehiculo])
                        { 
                            Console.WriteLine(reserva);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"No hay reservas registradas para el vehículo {objvehiculo.Marca}, {objvehiculo.Modelo}:");
                    }
                }
            }
        }

        public void Devolver()
        {
            if (cgestion.vehiculos==null)
            {
                Console.WriteLine("No hay vehiculos registrados");
            }
            else
            {
                Console.WriteLine("Ingrese la placa del vehiculo que desea devolver: ");
                var marca = Console.ReadLine();
                Console.WriteLine("Ingrese la placa del vehiculo que desea devolver: ");
                var modelo = Console.ReadLine();
                Vehiculo objvehiculo = cgestion.BuscarVehiculo(marca, modelo);
                if (objvehiculo.estado!=Estado.Alquilado) 
                {
                    Console.WriteLine("El vehiculo que desea devolver no se encuentra alquilado");
                
                } else 
                {
                    Console.WriteLine("Ingrese la cantidad de dias que lo alquilo: ");
                    int cantdias = int.Parse(Console.ReadLine());
                    double pagototal = cantdias*objvehiculo.ValorAlquiler;
                    Console.WriteLine($"El valor a pagar por {objvehiculo.Marca} es {pagototal}");
                    objvehiculo.estado=Estado.Disponible;
                }

            }
                
            
        }

        public void Reservar()
        {
            if (cgestion.vehiculos==null)
            {
                Console.WriteLine("No hay vehiculos registrados");
            }
            else
            {
                Console.WriteLine("Ingrese la marca del vehiculo que desea reservar: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo del vehiculo que desea reservar: ");
                string modelo = Console.ReadLine();
                Vehiculo objvehiculo = cgestion.BuscarVehiculo(marca, modelo);
                if (objvehiculo!=null)
                {
                    if (objvehiculo.estado==Estado.Disponible)
                    {
                        Console.WriteLine("Ingrese su nombre: ");
                        string cliente=Console.ReadLine();

                        objvehiculo.estado=Estado.Alquilado;
                        if (cgestion.historialreservas.ContainsKey(objvehiculo))
                        {
                            // Agregamos un nuevo registro de reserva
                            cgestion.historialreservas[objvehiculo].Add($" Ha sido reservado por {cliente}");
                        }
                        else
                        {
                            cgestion.historialreservas.Add(objvehiculo, new List<string> { $" Ha sido reservado por {cliente}" });
                        }
                        Console.WriteLine("Ha alquilado el vehiculo con exito");
                    }
                    else
                    {
                        Console.WriteLine("el vehiculo que busca no se encuentra disponible");
                    }
                }
                else
                {
                    Console.WriteLine("el vehiculo que busca no existe");
                }

            }
        }
    }
}
