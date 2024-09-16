using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    //creacion de la clase abstracta
    public abstract class Vehiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int AñoDeFabricacion { get; set; }
        //variable del precio del alquiler del vehículo
        public double ValorAlquiler { get; set; }
        //variable de tipo Estado para gestionar la disponibilidad del vehiculo
        public Estado estado { get; set; }


        //creacion del metodo abstracto que nos permite mostrar la informacion del véhículo
        public abstract void VerInformacion();

    }
}
