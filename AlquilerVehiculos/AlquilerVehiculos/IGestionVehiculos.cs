using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    //creamos la interfaz que nos ayudara a gestionar las acciones que podemos hacer con un vehiculo
    public interface IGestionVehiculos
    {
        //se debe añaadir como parametro vehiculo para saber cuál en específico se va a agregar
        void RegistrarVehiculo(Vehiculo vehiculo);

        //se usa para buscar vehiculos por marca y modelo
        Vehiculo BuscarVehiculo(String marca, String modelo);

        //se usa para eliminar un vehiculo de la lista de vehiculos, se hace booleano para verificar
        void EliminarVehiculo(Vehiculo vehiculo);
        //creamos dos metodos uno para listar todos los vehiculos y otro segun su estado

        void ListarSegunEstado(Estado estado);
        void ListaVehiculos();

        //se usa para actualizar los estados de los vehiculos
        void ActualizarEstado(String marca, String modelo);


    }
}
