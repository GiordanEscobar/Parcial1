using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public class ControlGestion : IGestionReservas, IGestionVehiculos
    {
        //creamos una lista y un dictionary que nos ayudara a tener la informacion de las reservas ya que son pares clave - valor
        public List <Vehiculo> vehiculos = new List<Vehiculo>();
        public Dictionary<Vehiculo, List<String>> historialreservas = new Dictionary<Vehiculo, List<string>>();

        //registramos un nuevo vehiculo
        public void RegistrarVehiculo (Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
            //se inicia el historial para las reservas del vehiculo
            historialreservas[vehiculo] = new List<string>();
            Console.WriteLine($"{vehiculo.GetType().Name} agregado correctamente.");
        }
        
        //listamos todos los vehiculos del sistema
        public void ListaVehiculos (Vehiculo vehiculo)
        {
            if (vehiculos.Count ==0) //verificamos si la lista esta vacia
            {
                Console.WriteLine("Aun no se registran vehiculos"); // si esta vacia enviamos un mensaje,asi evitamos lsitar algo que no tiene valores
                return;
            }

            //recorremos la lista con el bucle foreach
            else
            {
                Console.WriteLine("Lista de todos los vehiculos:");
                vehiculos.ForEach(vehiculo => vehiculo.VerInfo());
            }
        }
        public void ListarSegunEstado ()


        //eliminamos un vehiculo
        public void EliminarVehiculo (Vehiculo vehiculo)
        {
            vehiculos.Remove(vehiculo);
            //eliminamos también su historial en la reserva
            historialreservas.Remove(vehiculo);
            Console.WriteLine($"{vehiculo.GetType().Name} ha sido eliminado");
        }
    }
}
