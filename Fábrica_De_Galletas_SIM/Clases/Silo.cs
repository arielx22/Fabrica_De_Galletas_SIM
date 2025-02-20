using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fábrica_De_Galletas_SIM.Clases
{
    public class Silo
    {
        public Silo(int numero, double tamaño) { 
            this.numero = numero;
            this.tamaño = tamaño; 
        }
        public int numero {  get; set; }
        public double cantidad { get; set; }
        public double tamaño { get; set; }
        public string estado { get; set; }

        public void determinarEstado()
        {
            switch (this.cantidad)
            {
                case 0:
                    this.estado = "Vacio";
                    break;
                case 24:
                    this.estado = "Lleno";
                    break;
                default:
                    this.estado = "No Vacio";
                    break;
            }
        }
    }
}
