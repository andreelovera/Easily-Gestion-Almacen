using slm.Entidad.Marca;
using slm.Entidad.Producto;
using slm.Modelo.Marca;
using slm.Modelo.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Logica.Marca
{
    public class lMarca
    {
        mMarca mMarca = new mMarca();

        public List<eMarca> Listar()
        {
            return mMarca.Listar();
        }
        public int Crear(eMarca eMarca)
        {
            return mMarca.Crear(eMarca);
        }

    }
}
