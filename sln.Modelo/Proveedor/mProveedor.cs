using slm.Entidad.Proveedor;
using slm.Modelo.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Modelo.Proveedor
{
    public class mProveedor
    {

        public List<eProveedor> Listar()
        {
            List<eProveedor> lstProveedor = new List<eProveedor>();

            try{
                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    
                    lstProveedor = dbContext.Proveedor.Select(x=> new eProveedor
                    {
                        Id = x.Id,
                        Codigo = x.Codigo,
                        Nombre= x.Nombre,
                        Celular= x.Celular,
                        Correo= x.Correo,
                        Descripcion= x.Descripcion,
                        Estado= x.Estado
                    }).ToList();

                }                
            }
            catch (Exception ex){
                string ess = ex.Message;

                lstProveedor = new List<eProveedor>();
            }

            return lstProveedor;
        }
        public int Crear(eProveedor eProveedor)
        {
            int intResultado = 0;
           
            try
            {

                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    DataModel.Proveedor newProveedor = new DataModel.Proveedor();
                    newProveedor.Codigo = eProveedor.Codigo.Trim();
                    newProveedor.Nombre = eProveedor.Nombre.Trim();
                    newProveedor.Descripcion = eProveedor.Descripcion.Trim();
                    newProveedor.Correo = eProveedor.Correo.Trim();
                    newProveedor.Celular = eProveedor.Celular;

                    dbContext.Proveedor.Add(newProveedor);
                    dbContext.SaveChanges();
                    intResultado = newProveedor.Id;
                } 
             }
            catch (Exception ex){
              
                intResultado = 0;
            }
            return intResultado;
        }

        public int Actualizar(eProveedor eProveedor)
        {
            int intResultado = 0;

            try
            {
                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    DataModel.Proveedor editProveedor = new DataModel.Proveedor();

                    editProveedor.Codigo = eProveedor.Codigo.Trim();
                    editProveedor.Nombre = eProveedor.Nombre.Trim();
                    editProveedor.Descripcion = eProveedor.Descripcion.Trim();
                    editProveedor.Correo = eProveedor.Correo.Trim();
                    editProveedor.Celular = eProveedor.Celular;
                    editProveedor.Id= eProveedor.Id;
                    dbContext.Proveedor.AddOrUpdate(editProveedor);
                    dbContext.SaveChanges();
                    intResultado = editProveedor.Id;
                }
            }
            catch (Exception ex)
            {
                intResultado = 0;
            }
            return intResultado;
        }
        
        public bool Eliminar() 
        {
            bool blResultado = false;

            try{

            }
            catch (Exception ex) {
                
            }

            return blResultado;
        }
    }
}
