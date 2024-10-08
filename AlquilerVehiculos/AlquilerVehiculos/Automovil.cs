﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    public class Automovil : Vehiculo
    {
        
        //constructor de la clase con sus respectivos argumentos que hereda de vehiculo
        public Automovil(String marca, String modelo, int añofabricacion) : base(marca, modelo, añofabricacion) {
            ValorAlquiler = 20000;
        }

        //sobreescribimos en el metodo para ver la informacion y le llevamos la info del vehiculo actual
        public override void VerInfo()
        {
            Console.WriteLine($"El automovil {Marca}{Modelo}{AñoDeFabricacion} está: {estado}");
        }

    }
}
