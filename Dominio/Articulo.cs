using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public TipoArticulo Tipo { get; set; }
        public float Precio { get; set; }
        public float Costo { get; set; }
        public float IVA { get; set; }
        public int StockMin { get; set; }
        public Stock Stock { get; set; }
        public List<Proveedor> Proveedores { get; set; }
    }
}
