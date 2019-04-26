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
        public float Costo { get; set; }
        public List<SalidaDeArticulos> ArtVendidos;
        public float ImporteTotal { get; set; }
        public float IVATotal { get; set; }
    }
}
