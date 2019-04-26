using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Permiso
    {
        /*La idea es tener el sistema dividido en partes especificas(cada una con un permiso para verla),
        Y que haya una herramienta para el administrador con la que pueda dar o quitar permisos a los usuarios creados.*/
        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
