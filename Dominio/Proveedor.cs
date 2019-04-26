using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Proveedor
    {
        public int ID { get; set; }
        public string RazonSocial { get; set; }
        public List<Marca> Marcas { get; set; }
    }
}
