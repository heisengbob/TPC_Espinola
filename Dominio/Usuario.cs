using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public string User { get; set; }
        public string Descripcion { get; set; }
        public List<Permiso> Permisos { get; set; }
    }
}
