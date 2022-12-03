using slm.Entidad.Marca;
using slm.Entidad.Producto;
using slm.Entidad.Proveedor;
using slm.Modelo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Modelo.Marca
{
    public class mMarca
    {
        public List<eMarca> Listar()
        {
            List<eMarca> eMarcas = new List<eMarca>();
            try
            {
                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    eMarcas = dbContext.Marca.Select(m => new eMarca
                    {
                        Id = m.Id,
                        Codigo = m.Codigo,
                        IdProveedor = m.IdProveedor,
                        Nombre = m.Nombre

                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                eMarcas = null;
            }
            return eMarcas;
        }
        public int Crear(eMarca eMarca)
        {
            int intResultado = 0;

            try
            {

                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    DataModel.Marca newMarca = new DataModel.Marca();

                    newMarca.IdProveedor = eMarca.IdProveedor;
                    newMarca.Codigo = eMarca.Codigo;
                    newMarca.Nombre = eMarca.Nombre;
                    

                    dbContext.Marca.Add(newMarca);
                    dbContext.SaveChanges();
                    intResultado = newMarca.Id;
                }
            }
            catch (Exception ex)
            {

                intResultado = 0;
            }
            return intResultado;
        }
    }
}
