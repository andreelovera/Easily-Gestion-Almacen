using slm.Entidad.Categoria;
using slm.Entidad.Marca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Entidad.Producto
{
    public class eProducto
    {
        public int Id { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaStock { get; set; }
        public bool Estado { get; set; }

        public virtual eMarca Marca { get; set; }
        public virtual eCategoria Categoria { get; set; }

    }
}
