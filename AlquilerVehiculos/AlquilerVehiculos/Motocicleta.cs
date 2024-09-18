using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public class Motocicleta : Vehiculo
    {
        
        public Motocicleta(String marca, String modelo, int añofabricacion) : base(marca, modelo, añofabricacion) {
            ValorAlquiler = 15000;
        }

        //sobreescribimos en el metodo para ver la informacion y le llevamos la info del vehiculo actual
        public override void VerInfo()
        {
            Console.WriteLine($"La motocicleta {Marca}{Modelo}{AñoDeFabricacion} está: {estado}");
        }
    }
}
