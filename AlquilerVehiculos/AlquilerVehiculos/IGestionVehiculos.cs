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

        //se usa para eliminar un vehiculo de la lista de vehiculos, se hace booleano para verificar

    }
}
