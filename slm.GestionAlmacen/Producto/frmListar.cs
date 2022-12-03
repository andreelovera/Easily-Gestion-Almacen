using slm.Entidad.Categoria;
using slm.Entidad.Marca;
using slm.Entidad.Producto;
using slm.Entidad.Proveedor;
using slm.Logica.Categoria;
using slm.Logica.Marca;
using slm.Logica.Producto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace slm.GestionAlmacen.Producto
{
    public partial class frmListar : Form
    {
        #region Entidades
        lProducto lProducto = new lProducto();
        lMarca lMarca = new lMarca();
        lCategoria lCategoria = new lCategoria();
        #endregion

        #region Modelo DT
        DataTable dtProducto = new DataTable();
        DataTable dtProductoFiltrado = new DataTable();
        DataTable dtProductoVacia = new DataTable();
        DataTable dtMarca = new DataTable();
        DataColumn dcMarca;
        DataTable dtCategoria = new DataTable();
        DataColumn dcCategoria;
        DataColumn dcProducto;
        DataColumn[] keys;
        DataRow dr;
        #endregion

        #region Metodos Form
        public frmListar()
        {
            InitializeComponent();
        }
        private void frmListar_Load(object sender, EventArgs e)
        {
            CrearTable();
            LLenarTabla(lProducto.Listar());
            LlenarMarca(lMarca.Listar());
            LLenarCategoria(lCategoria.Listar());
            CargarGridView();
        }
        private void txtFiltroProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroProducto.Text.Length > 0)
            {
                var filtro = "NombreMarca like '%" + txtFiltroProducto.Text + "%'" +
                    "or NombreCategoria like '%" + txtFiltroProducto.Text + "%' " +
                    "or Codigo like '%" + txtFiltroProducto.Text + "%' " +
                    "or Nombre like '%" + txtFiltroProducto.Text + "%' " +
                    "or Precio like '%" + txtFiltroProducto.Text + "%' " +
                    "or Stock like '%" + txtFiltroProducto.Text + "%' ";
                var query = dtProductoFiltrado.Select(filtro);


                if (query.Count() > 0)
                {
                    dgvProducto.DataSource = query.CopyToDataTable(); ;
                }
                else
                {
                    dtProductoVacia.Rows.Clear();
                    dgvProducto.DataSource = dtProductoVacia;
                }
            }
            else
            {
                dgvProducto.DataSource = dtProductoFiltrado;
            }
        }
        private void tsbAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto.frmAgregar frmAgregar = new Producto.frmAgregar();
            frmAgregar.dtCategoria = dtCategoria;
            frmAgregar.dtMarca = dtMarca;
            frmAgregar.lblProveedor = lblIdProveedor.Text;
            frmAgregar.dtProductoFiltrado = dtProductoFiltrado;
            frmAgregar.ShowDialog();
            dtProductoFiltrado = frmAgregar.dtProductoFiltrado;
            dgvProducto.DataSource = dtProductoFiltrado;
            txtFiltroProducto.Text = string.Empty;

        }
        private void tsbEditarProdicto_Click(object sender, EventArgs e)
        {
            if (dgvProducto.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro a modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Producto.frmEditar frmEditar = new Producto.frmEditar();
            frmEditar.dtCategoria = dtCategoria;
            frmEditar.dtMarca = dtMarca;
            frmEditar.eProducto = CargarProductoAmodificar();
            frmEditar.lblProveedor = lblIdProveedor.Text;
            frmEditar.dtProductoFiltrado = dtProductoFiltrado;
            frmEditar.ShowDialog();
            dtProductoFiltrado = frmEditar.dtProductoFiltrado;
            dgvProducto.DataSource = dtProductoFiltrado;
            txtFiltroProducto.Text = string.Empty;
        }
        #endregion

        #region Metodos Nuevos
        private void CargarGridView()
        {
            var query = dtProducto.Select("IdProveedor = " + lblIdProveedor.Text);

            if (query.Count() > 0)
            {
                dtProductoFiltrado  = query.CopyToDataTable();
                keys = new DataColumn[1];
                keys[0] = dtProductoFiltrado.Columns["Id"];
                dtProductoFiltrado.PrimaryKey = keys;
                dgvProducto.DataSource = dtProductoFiltrado;
            }
            else
            {
                dtProductoVacia.Rows.Clear();
                dtProductoFiltrado.Rows.Clear();
                dgvProducto.DataSource = dtProductoVacia;
                //dtProductoFiltrado = dtProductoVacia;
            }
        }
        private void CrearTable()
        {
            #region Tabla dtProducto
            keys = new DataColumn[1];
            dtProducto = new DataTable();

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(int);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "Id";
            dtProducto.Columns.Add(dcProducto);
            keys[0] = dcProducto;
            dtProducto.PrimaryKey = keys;

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(int);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "IdMarca";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(int);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "IdProveedor";
            dtProducto.Columns.Add(dcProducto);


            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(string);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "NombreMarca";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(int);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "IdCategoria";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(string);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "NombreCategoria";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(string);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "Codigo";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(string);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "Nombre";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(string);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "Precio";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(string);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "Stock";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(string);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "FechaCreacion";
            dtProducto.Columns.Add(dcProducto);

            dcProducto = new DataColumn();
            dcProducto.DataType = typeof(string);
            dcProducto.AllowDBNull = false;
            dcProducto.ColumnName = "FechaStock";
            dtProducto.Columns.Add(dcProducto);

            dtProductoVacia = dtProducto.Clone();
            dtProductoFiltrado = dtProducto;
            #endregion

            #region dtMarca
            keys = new DataColumn[1];
            dtMarca = new DataTable();

            dcMarca = new DataColumn();
            dcMarca.DataType = typeof(string);
            dcMarca.AllowDBNull = false;
            dcMarca.ColumnName = "Id";
            dtMarca.Columns.Add(dcMarca);
            keys[0] = dcMarca;
            dtMarca.PrimaryKey = keys;

            dcMarca = new DataColumn();
            dcMarca.DataType = typeof(string);
            dcMarca.AllowDBNull = false;
            dcMarca.ColumnName = "IdProveedor";
            dtMarca.Columns.Add(dcMarca);

            dcMarca = new DataColumn();
            dcMarca.DataType = typeof(string);
            dcMarca.AllowDBNull = false;
            dcMarca.ColumnName = "Codigo";
            dtMarca.Columns.Add(dcMarca);

            dcMarca = new DataColumn();
            dcMarca.DataType = typeof(string);
            dcMarca.AllowDBNull = false;
            dcMarca.ColumnName = "Nombre";
            dtMarca.Columns.Add(dcMarca);
            #endregion

            #region dtCategoria
            dtCategoria = new DataTable();
            keys = new DataColumn[1];

            dcCategoria = new DataColumn();
            dcCategoria.DataType = typeof(int);
            dcCategoria.AllowDBNull = false;
            dcCategoria.ColumnName = "Id";
            dtCategoria.Columns.Add(dcCategoria);
            keys[0] = dcCategoria;

            dtCategoria.PrimaryKey = keys;

            dcCategoria = new DataColumn();
            dcCategoria.DataType = typeof(string);
            dcCategoria.AllowDBNull = false;
            dcCategoria.ColumnName = "Codigo";
            dtCategoria.Columns.Add(dcCategoria);

            dcCategoria = new DataColumn();
            dcCategoria.DataType = typeof(string);
            dcCategoria.AllowDBNull = false;
            dcCategoria.ColumnName = "Nombre";
            dtCategoria.Columns.Add(dcCategoria);

            #endregion

        }
        private void LLenarTabla(List<eProducto> lstProducto)
        {
            foreach (var producto in lstProducto)
            {

                dr = dtProducto.NewRow();
                dr["Id"] = producto.Id;
                dr["IdMarca"] = producto.IdMarca;
                dr["IdProveedor"] = producto.Marca.IdProveedor;
                dr["NombreMarca"] = producto.Marca.Nombre;
                dr["IdCategoria"] = producto.IdCategoria;
                dr["NombreCategoria"] = producto.Categoria.Nombre;
                dr["Codigo"] = producto.Codigo;
                dr["Nombre"] = producto.Nombre;
                dr["Precio"] = producto.Precio;
                dr["Stock"] = producto.Stock;
                dr["FechaCreacion"] = Convert.ToDateTime(producto.FechaCreacion).ToString("dd/MM/yyyy");
                dr["FechaStock"] = Convert.ToDateTime(producto.FechaStock).ToString("dd/MM/yyyy");

                dtProducto.Rows.Add(dr);
            }
        }
        private void LlenarMarca(List<eMarca> lstMarca)
        {
            foreach (var marca in lstMarca)
            {

                dr = dtMarca.NewRow();
                dr["Id"] = marca.Id;
                dr["Codigo"] = marca.Codigo;
                dr["IdProveedor"] = marca.IdProveedor;
                dr["Nombre"] = marca.Nombre;

                dtMarca.Rows.Add(dr);
            }
        }
        private void LLenarCategoria(List<eCategoria> lstCategoria)
        {
            foreach (var categoria in lstCategoria)
            {
                dr = dtCategoria.NewRow();
                dr["Id"] = categoria.Id;
                dr["Codigo"] = categoria.Codigo;
                dr["Nombre"] = categoria.Nombre;

                dtCategoria.Rows.Add(dr);
            }
        }
        private eProducto CargarProductoAmodificar()
        {
           
            eProducto modificaProveedor = new eProducto();
            modificaProveedor.Id = Convert.ToInt32(dgvProducto.CurrentRow.Cells["Id"].Value.ToString());
            modificaProveedor.IdMarca =Convert.ToInt32(dgvProducto.CurrentRow.Cells["IdMarca"].Value.ToString());
            modificaProveedor.IdCategoria = Convert.ToInt32(dgvProducto.CurrentRow.Cells["IdCategoria"].Value.ToString());
            modificaProveedor.Codigo = dgvProducto.CurrentRow.Cells["Codigo"].Value.ToString();
            modificaProveedor.Nombre = dgvProducto.CurrentRow.Cells["Nombre"].Value.ToString();
            modificaProveedor.Precio = Convert.ToDecimal(dgvProducto.CurrentRow.Cells["Precio"].Value.ToString());
            modificaProveedor.Stock = Convert.ToDecimal(dgvProducto.CurrentRow.Cells["Stock"].Value.ToString());
            modificaProveedor.FechaCreacion = Convert.ToDateTime(dgvProducto.CurrentRow.Cells["FechaCreacion"].Value.ToString());
            modificaProveedor.FechaStock = Convert.ToDateTime(dgvProducto.CurrentRow.Cells["FechaStock"].Value.ToString());

            return modificaProveedor;
        }

        #endregion

        private void tsbMarca_Click(object sender, EventArgs e)
        {
            Marca.frmAgregar frmAgregar = new Marca.frmAgregar();
            frmAgregar.dtMarca = dtMarca;
            frmAgregar.idProveedor = lblIdProveedor.Text;
            frmAgregar.ShowDialog();
            dtMarca = frmAgregar.dtMarca;

            
           
        }

        private void tsbCategoria_Click(object sender, EventArgs e)
        {
            Categoria.frmAgregar frmAgregar = new Categoria.frmAgregar();
            frmAgregar.dtCategoria = dtCategoria;
            frmAgregar.ShowDialog();
            dtCategoria = frmAgregar.dtCategoria;           
        }
    }
}

