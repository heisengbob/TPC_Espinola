using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public int Cant { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public float Costo { get; set; }
    }
}
