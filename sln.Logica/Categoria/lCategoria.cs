using slm.Entidad.Categoria;
using slm.Entidad.Marca;
using slm.Entidad.Producto;
using slm.Modelo.Categoria;
using slm.Modelo.Marca;
using slm.Modelo.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Logica.Categoria
{
    public class lCategoria
    {
        mCategoria mCategoria = new mCategoria();
        public List<eCategoria> Listar()
        {
            return mCategoria.Listar();
        }

        public int Crear(eCategoria eCategoria)
        {
            return mCategoria.Crear(eCategoria);
        }

    }
}
