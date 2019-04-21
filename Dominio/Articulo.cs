using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public TipoArticulo Tipo { get; set; }
        public List<Proveedor> Proveedores { get; set; }
    }
}
