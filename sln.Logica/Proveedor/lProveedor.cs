using slm.Entidad.Proveedor;
using slm.Modelo.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Logica.Proveedor
{
    public class lProveedor
    {
        mProveedor mProveedor = new mProveedor();
        public List<eProveedor> Lista()
        {
            return  mProveedor.Listar();
        }
        public int Crear(eProveedor eProveedor)
        {
            return mProveedor.Crear(eProveedor);
        }
        public int Actualizar(eProveedor eProveedor)
        {
            return mProveedor.Actualizar(eProveedor);
        }
    }
}
