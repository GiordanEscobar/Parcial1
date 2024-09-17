using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public class Reservas : IGestionReservas
    {
        public bool CancelarReserva(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public List<string> ConsultarHistorial(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public void Devolver(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public void Reservar(Vehiculo vehiculo, DateTime fechainicio, int cantdias)
        {
            throw new NotImplementedException();
        }
    }
}
