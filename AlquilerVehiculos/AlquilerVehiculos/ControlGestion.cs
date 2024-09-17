using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public class ControlGestion : IGestionVehiculos
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
        public void ListaVehiculos(Vehiculo vehiculo)
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
        //se usa para listar segun estados 
        public void ListarSegunEstado (Estado estado)
        {
            //hacemos una lista pra los vehiculos que deseamos ver segun su estado
            List <Vehiculo> filtrados = new List<Vehiculo>();
            //ahora recorremos la lista de los vehiculos que teniamos y agregamos a la lista anterior solo los que necesitamos ver
            for (int i = 0; i < vehiculos.Count; i++)
            {
                //traigo el vehiculo actual de la lista
                Vehiculo vehiculo = vehiculos[i];
                //verifico si el estado coincide con el que estoy buscando
                if (vehiculo.estado == estado)
                {
                    //agrego el vehiculo a la lista de los que filtre
                    filtrados.Add(vehiculo);
                }
                
            }
            //aqui vamos a montrar ya los vehiculos que filtramos o un mensaje no hay vehiculos en el estado pedido
            if (filtrados.Count == 0)
            {
                Console.WriteLine($"Actualmente no hay vehiculos en el estado {estado}.");
            }
            else
            {
                Console.WriteLine($"vehiculos en estado {estado}");
                //recorremos la lista de filtrados
                for (int i = 0; i < filtrados.Count; i++)
                {
                    Vehiculo vehiculo = filtrados[i];
                    //y vemos la informacion de cada uno de los filtradors con el metodo verinfo
                    vehiculo.VerInfo();
                }
            }
        }

        //eliminamos un vehiculo
        public void EliminarVehiculo (Vehiculo vehiculo)
        {
            vehiculos.Remove(vehiculo);
            //eliminamos también su historial en la reserva
            historialreservas.Remove(vehiculo);
            Console.WriteLine($"{vehiculo.GetType().Name} ha sido eliminado");
        }

        public Vehiculo BuscarVehiculo(string marca, string modelo)
        {
            //usamos un ciclo for para para recorrer la lista de vehiculos
            for (int i = 0; i < vehiculos.Count; i++)
            {
                //traemos el vehiculo actual
                Vehiculo vehiculo = vehiculos[i];
                //comparamos la marca y el modelo ingornando las mayusculas que el usuario o cliente pueda poner con .ToLower
                if (vehiculo.Marca.ToLower()==marca.ToLower() && vehiculo.Modelo.ToLower()==modelo.ToLower())
                {
                    //si se encuentra el vehiculo mostrar la informacion y devolverlo
                    Console.WriteLine($"El vehiculo que buscó es: {vehiculo.Marca} {vehiculo.Modelo} del año {vehiculo.AñoDeFabricacion} - Se encuentra: {vehiculo.estado}");
                    return vehiculo;
                }
                //en caso que no se encuentr el vehiculo se ve un mensaje y retorna un valor null
                Console.WriteLine("No se encontró el vehiculo");
                return null;
            }
        }

        public void ActualizarEstado(string marca, string modelo)
        {
            throw new NotImplementedException();
        }
    }
}
