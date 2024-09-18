using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    //creamos la interfaz para gestionar las reservas
    public interface IGestionReservas
    {
        //se usa para reservar un vehiculo
        void Reservar();

        //se usa para devolver un vehiculo que estaba alquilado y le cambia el estado a disponible
        void Devolver();

        //se usa para consultar la lista que contiene el historial de reservas de un vehiculo
        void ConsultarHistorial();

    }
}
