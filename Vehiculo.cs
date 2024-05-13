using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1
{
    internal partial class Vehiculo
    {
        public string marca { get; set; }

        public string placa { get; set; }

        public string modelo { get; set; }

        public string color { get; set; }
        //capacidad del tanque en galones.
        public double capTanque { get; set; }

        public double nivTanque { get; set; }
        //km/galón.
        public double rendimiento { get; set; }

        public Vehiculo(string marca, string placa, string modelo, string color, double capTanque, double rendimiento, double nivTanque = 0)
        {
            this.marca = marca;
            this.placa = placa;
            this.modelo = modelo;
            this.color = color;
            this.capTanque = capTanque;
            this.nivTanque = nivTanque;
            this.rendimiento = rendimiento;
        }

        public void datosV()
        {
           Console.WriteLine($"El Vehiculo Marca: *{marca}*, Placa: *{placa}*, Modelo: *{modelo}*, Color: *{color}*," +
               $"\nCapacidad del Tanque: *{capTanque}*, Rendimiento (km/): *{rendimiento}*, Nivel del Tanque: *{nivTanque}*");
        }

        /* 
         1 pt crear las dos clases
         1 pt crear las 7 variables / 6 parametros y 1 = 0.
         1 pt metodo "puede conducir"
         1 pt rellenar 
        */
    }
}
