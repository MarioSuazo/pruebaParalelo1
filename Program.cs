using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace prueba1
{
    internal partial class Vehiculo
    {
        static Vehiculo v1 = new Vehiculo("Hundai", "M 08395", "Verna", "Plateado", 11.8, 32, 5);
        static Vehiculo v2 = new Vehiculo("Jeep", "NYC AB2609", "Wrangler", "Negro", 17.5, 45.98, 9);
        static Vehiculo v3 = new Vehiculo("Ford", "AG 957 MS", "Mustang", "Verde", 16, 33.33, 16);
        static int distancia;
        static double galones, rend, tanque, nivT;
        public static void Main(string[] args)
        {
            v1.datosV();
            Console.Write("Ingrese la Distancia a Recorrer (km): ");
            distancia = Convert.ToInt32(Console.ReadLine());
            rend = v1.rendimiento;
            tanque = v1.capTanque;
            nivT = v1.nivTanque;
            conducir(distancia);


            v2.datosV();
            Console.Write("Ingrese la Distancia a Recorrer (km): ");
            distancia = Convert.ToInt32(Console.ReadLine());
            rend = v2.rendimiento;
            tanque = v2.capTanque;
            nivT = v2.nivTanque;
            conducir(distancia);


            v3.datosV();
            Console.Write("Ingrese la Distancia a Recorrer (km): ");
            distancia = Convert.ToInt32(Console.ReadLine());
            rend = v3.rendimiento;
            tanque = v3.capTanque;
            nivT = v3.nivTanque;
            conducir(distancia);
        }

        static void rellenarTanque(double galones)
        {
            if (galones > tanque)
            {
                Console.WriteLine($"Sin espacio.\nCapacidad del tanque: {tanque}.\n");
            }
            else
            {
                Console.WriteLine("Rellenando Tanque.\n");
                nivT += galones;
                Console.WriteLine($"Nuevo Nivel de Tanque: {nivT}.");
            }
        }
        
        static double gasNecesario;

        static bool puedeConducir(int distancia)
        {
            bool drive;
            gasNecesario = distancia / rend;
            if (gasNecesario < tanque)
            {
                if (gasNecesario < nivT)
                {
                    //Sí se puede viajar.
                    drive = true;
                }
                else
                {
                    //No se puede viajar.
                    drive = false;
                }
            }
            else
            {
                //No se puede viajar.
                drive = false;
            }

            return drive;
        }

        static void conducir(int distancia)
        {
            if (puedeConducir(distancia))
            {
                Console.WriteLine("\tArrancando.");
                nivT -= gasNecesario;
                Console.WriteLine($"Nivel del Tanque PostViaje: {nivT}.\n");
            }
            else
            {
                //No se puede arrancar, Ó.

                if (gasNecesario < tanque)
                {
                    if (gasNecesario > nivT)
                    {
                        Console.WriteLine("¡Combustible Insuficiente!");
                        Console.Write("Digite los Galones a Rellenar: ");
                        galones = Convert.ToDouble(Console.ReadLine());
                        rellenarTanque(galones);
                        Console.WriteLine($"Necesario: '{gasNecesario}', Tanque: '{tanque}', Nivel: '{nivT}'");

                        if (gasNecesario > nivT)
                        {
                            Console.WriteLine($"No se puede arrancar.\nSe necesita más combustible del disponible.");
                        }
                        else
                        {
                            Console.WriteLine("\tArrancando después de Rellenar.");
                            nivT -= gasNecesario;
                            Console.WriteLine($"Nivel del Tanque PostViaje: {nivT}\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\tArrancando.");
                        nivT -= gasNecesario;
                        Console.WriteLine($"Nivel del Tanque PostViaje: {nivT}\n");
                    }
                }
                else
                {
                    Console.WriteLine($"No se puede arrancar.\nSe necesita más combustible del equipable.\nNecesario: {gasNecesario}");
                }
            }
        }
    }
}
