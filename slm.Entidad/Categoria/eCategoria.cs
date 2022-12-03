using slm.Entidad.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Entidad.Categoria
{
    public class eCategoria
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public virtual eProducto Producto { get; set; }
    }
}
