using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculos
{
    //creacion de la clase principal

    public class Alquiler
    {
        public static void Main(string[] args)
        {
            Console.Write("****ALQUILER****");
            int opcion = 0;
            do
            {
                Console.WriteLine("Quien desea acceder\t" +
                                  "1. Administrador\t" +
                                  "2. Cliente\t");

                opcion=int.Parse(Console.ReadLine());


                switch (opcion) { 
                
                }
            }while (opcion!=0);
        }
    }
}
