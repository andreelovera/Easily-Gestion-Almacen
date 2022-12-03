using slm.Entidad.Producto;
using System;
using System.Collections.Generic;
using slm.Modelo.DataModel;
using System.Linq;
using slm.Entidad.Marca;
using slm.Entidad.Categoria;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using slm.Entidad.Proveedor;
using System.Data.Entity.Migrations;

namespace slm.Modelo.Producto
{
    public class mProducto
    {
        public List<eProducto> Listar()
        {
            List<eProducto> lstProductos = new List<eProducto>();

            try
            {
                using (var dbContext = new DataModel.GESTION_ALMACENEntities())
                {

                    lstProductos = (from p in dbContext.Producto join m in dbContext.Marca on p.IdMarca equals m.Id join c in dbContext.Categoria on p.IdCategoria equals c.Id orderby p.Id descending
                               select new eProducto
                               {
                                   Id = p.Id,
                                   IdMarca = p.IdMarca,
                                   Marca = new eMarca {
                                       Id = p.IdMarca,
                                       IdProveedor = m.IdProveedor,
                                       Codigo = m.Codigo,
                                       Nombre = m.Nombre
                                   },
                                   IdCategoria = p.IdCategoria,
                                   Categoria = new eCategoria {
                                       Id = c.Id,
                                       Codigo = c.Codigo,
                                       Nombre = c.Nombre
                                   },
                                   Codigo = p.Codigo,
                                   Nombre = p.Nombre,
                                   Precio = p.Precio,
                                   Stock = p.Stock,
                                   FechaCreacion = p.FechaStock,
                                   FechaStock = p.FechaStock
                               }).ToList();
                }
            }
            catch (Exception ex)
            {
                var a = ex.Source;
                lstProductos = null;
            }
            return lstProductos;
        }

        public int Crear(eProducto eProducto)
        {
            int intResultado = 0;

            try
            {

                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    DataModel.Producto newProducto = new DataModel.Producto();

                    newProducto.IdMarca = eProducto.IdMarca;
                    newProducto.IdCategoria = eProducto.IdCategoria;
                    newProducto.Codigo = eProducto.Codigo;
                    newProducto.Nombre = eProducto.Nombre;
                    newProducto.Precio  = eProducto.Precio;
                    newProducto.Stock= eProducto.Stock;
                    newProducto.FechaStock = DateTime.Now;
                    newProducto.FechaCreacion = DateTime.Now;

                    dbContext.Producto.Add(newProducto);
                    dbContext.SaveChanges();
                    intResultado = newProducto.Id;
                }
            }
            catch (Exception ex)
            {

                intResultado = 0;
            }
            return intResultado;
        }

        public int Actualizar(eProducto eProducto)
        {
            int intResultado = 0;

            try
            {

                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    DataModel.Producto newProducto = new DataModel.Producto();

                    newProducto.IdMarca = eProducto.IdMarca;
                    newProducto.IdCategoria = eProducto.IdCategoria;
                    newProducto.Codigo = eProducto.Codigo;
                    newProducto.Nombre = eProducto.Nombre;
                    newProducto.Precio = eProducto.Precio;
                    newProducto.Stock = eProducto.Stock;
                    newProducto.Id = eProducto.Id;
                    newProducto.FechaStock = eProducto.FechaStock;
                    newProducto.FechaCreacion = eProducto.FechaCreacion;

                    dbContext.Producto.AddOrUpdate(newProducto);
                    dbContext.SaveChanges();
                    intResultado = newProducto.Id;
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
