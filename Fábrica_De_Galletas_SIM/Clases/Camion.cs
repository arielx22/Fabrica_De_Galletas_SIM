using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fábrica_De_Galletas_SIM.Clases
{
    public class Camion
    {
        public Camion() { }
        public int id {  get; set; }
        public int tamañoCamion { get; set; }
        public double cantidadActual {  get; set; }
        public string estado { get; set; }

    }
}
