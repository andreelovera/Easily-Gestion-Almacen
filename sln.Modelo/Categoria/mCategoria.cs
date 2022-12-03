using slm.Entidad.Categoria;
using slm.Entidad.Marca;
using slm.Modelo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Modelo.Categoria
{
    public class mCategoria
    {
        public List<eCategoria> Listar(){

            List<eCategoria> eMarcas = new List<eCategoria>();
            try
            {
                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    eMarcas = dbContext.Categoria.Select(x => new eCategoria
                    {
                        Id = x.Id,
                        Codigo = x.Codigo,
                        Nombre = x.Nombre

                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                eMarcas = null;
            }
            return eMarcas;
        }
        public int Crear(eCategoria eCategoria)
        {
            int intResultado = 0;

            try
            {

                using (var dbContext = new GESTION_ALMACENEntities())
                {
                    DataModel.Categoria newCategoria = new DataModel.Categoria();

                    newCategoria.Nombre = eCategoria.Nombre;
                    newCategoria.Codigo = eCategoria.Codigo;

                    dbContext.Categoria.Add(newCategoria);
                    dbContext.SaveChanges();
                    intResultado = newCategoria.Id;
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
