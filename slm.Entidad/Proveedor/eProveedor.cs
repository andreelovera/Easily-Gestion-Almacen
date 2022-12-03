﻿using slm.Entidad.Marca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slm.Entidad.Proveedor
{
    public class eProveedor
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public int Celular { get; set; }
        public bool Estado { get; set; }

        public virtual List<eMarca> Marcas { get; set; }
    }
}
