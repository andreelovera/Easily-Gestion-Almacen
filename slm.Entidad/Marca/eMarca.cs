using slm.Entidad.Producto;
using slm.Entidad.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace slm.Entidad.Marca
{
    public class eMarca
    {
        public int Id { get; set; }
        public int IdProveedor { get; set; }
        public string Codigo { get; set;}
        public string Nombre { get; set;}
        public bool Estado { get; set;}

        public virtual eProveedor Provedor { get; set; }
        public virtual List<eProducto> Productos { get; set; }
    }
}
