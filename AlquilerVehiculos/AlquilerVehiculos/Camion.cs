using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    internal class Camion : Vehiculo
    {
        
        public Camion(String marca, String modelo, int añofabricacion) : base(marca, modelo, añofabricacion) {
            ValorAlquiler = 30000; 
        }

        //sobreescribimos en el metodo para ver la informacion y le llevamos la info del vehiculo actual
        public override void VerInfo()
        {
            Console.WriteLine($"El camion {Marca}{Modelo}{AñoDeFabricacion} está: {estado}");
        }
    }
}
