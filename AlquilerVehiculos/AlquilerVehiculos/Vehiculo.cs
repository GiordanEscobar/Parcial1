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
        public String? Marca { get; set; }
        public String? Modelo { get; set; }
        public int AñoDeFabricacion { get; set; }
        //variable del precio del alquiler del vehículo
        public double ValorAlquiler { get; set; }
        //variable de tipo Estado para gestionar la disponibilidad del vehiculo
        public Estado estado { get; set; }
         
        public Vehiculo(String marca, String modelo, int añofabricacion, double valoralquiler)
        {
            Marca= marca;
            Modelo= modelo;
            AñoDeFabricacion = añofabricacion;
            ValorAlquiler= valoralquiler;
            //se inicia en disponible por defecto
            this.estado = Estado.Disponible;
        }

        //creacion del metodo abstracto que nos permite ver la informacion del véhículo
        public abstract void VerInfo();

    }
}
