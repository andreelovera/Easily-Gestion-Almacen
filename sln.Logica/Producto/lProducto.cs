using slm.Entidad.Producto;
using slm.Modelo.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Logica.Producto
{
    public class lProducto
    {
        mProducto mProducto = new mProducto();

        public List<eProducto> Listar()
        {
            return mProducto.Listar();
        }

        public int Crear(eProducto eProducto)
        {
            return mProducto.Crear(eProducto);
        }

        public int  Actualizar(eProducto eProducto)
        {
            return mProducto.Actualizar(eProducto);
        }
    }
}
