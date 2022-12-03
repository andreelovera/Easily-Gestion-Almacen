using slm.Entidad.Proveedor;
using slm.GestionAlmacen.Producto;
using slm.Logica.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slm.GestionAlmacen.Proveedor
{
    public partial class frmListar : Form
    {
        #region Entidades
        lProveedor lProveedor = new lProveedor();
        #endregion

        #region Modelo DT
        DataTable dtProveedores = new DataTable();
        DataTable dtProveedoresVacio = new DataTable();
        DataColumn dcProveedor;
        DataColumn[] keys;
        DataRow dr;
        #endregion

        #region Metodos Form
        public frmListar()
        {
            InitializeComponent();
        }
        private void frmListaProveedor_Load(object sender, EventArgs e)
        {
            CrearTable(); //Creando table
            LLenarTabla(lProveedor.Lista()); //Llenado table
            dgvListaProveedor.DataSource = dtProveedores;
        }
        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Text.Length > 0)
            {
                var filtro = "Codigo like '%" + txtBuscarProveedor.Text + "%' or Nombre like '%" + txtBuscarProveedor.Text + "%' ";
                var query = dtProveedores.Select(filtro);


                if (query.Count() > 0)
                {
                    dgvListaProveedor.DataSource = query.CopyToDataTable(); ;
                }
                else
                {
                    dtProveedoresVacio.Rows.Clear();
                    dgvListaProveedor.DataSource = dtProveedoresVacio;
                }
            }
            else
            {
                dgvListaProveedor.DataSource = dtProveedores;
            }
        }
        private void tsbAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.dtProveedores = dtProveedores;
            frmAgregar.ShowDialog();
            dgvListaProveedor.DataSource = frmAgregar.dtProveedores;
            txtBuscarProveedor.Text = string.Empty;

        }
        private void tsbEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvListaProveedor.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro a modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmEditar frmEditar = new frmEditar();
            frmEditar.modificaProveedor = CargarProveedorAmodificar();
            frmEditar.dtProveedores = dtProveedores;
            frmEditar.ShowDialog();
            dgvListaProveedor.DataSource = frmEditar.dtProveedores;
            txtBuscarProveedor.Text = string.Empty;



        }
        private void dgvListaProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto.frmListar frmListarProducto = new Producto.frmListar();
            frmListarProducto.tssNombreProveedor.Text = dgvListaProveedor.CurrentRow.Cells["Nombre"].Value.ToString().Trim().ToUpper();
            frmListarProducto.lblIdProveedor.Text = dgvListaProveedor.CurrentRow.Cells["Id"].Value.ToString().Trim().ToUpper();
            this.Visible = false;
            frmListarProducto.ShowDialog();
            this.Visible = true; ;
        }
        #endregion

        #region Metodos Nuevos
        private void CrearTable()
        {
            keys = new DataColumn[1];
            dtProveedores = new DataTable();

            dcProveedor = new DataColumn();
            dcProveedor.DataType = typeof(int);
            dcProveedor.AllowDBNull = false;
            dcProveedor.ColumnName = "Id";
            dtProveedores.Columns.Add(dcProveedor);
            keys[0] = dcProveedor;
            dtProveedores.PrimaryKey = keys;

            dcProveedor = new DataColumn();
            dcProveedor.DataType = typeof(string);
            dcProveedor.AllowDBNull = false;
            dcProveedor.ColumnName = "Codigo";
            dtProveedores.Columns.Add(dcProveedor);

            dcProveedor = new DataColumn();
            dcProveedor.DataType = typeof(string);
            dcProveedor.AllowDBNull = false;
            dcProveedor.ColumnName = "Nombre";
            dtProveedores.Columns.Add(dcProveedor);

            dcProveedor = new DataColumn();
            dcProveedor.DataType = typeof(string);
            dcProveedor.AllowDBNull = false;
            
            dcProveedor.ColumnName = "Descripcion";
            dtProveedores.Columns.Add(dcProveedor);

            dcProveedor = new DataColumn();
            dcProveedor.DataType = typeof(string);
            dcProveedor.AllowDBNull = false;
            dcProveedor.ColumnName = "Correo";
            dtProveedores.Columns.Add(dcProveedor);

            dcProveedor = new DataColumn();
            dcProveedor.DataType = typeof(string);
            dcProveedor.AllowDBNull = false;
            dcProveedor.ColumnName = "Celular";
            dtProveedores.Columns.Add(dcProveedor);


            dtProveedoresVacio = dtProveedores.Clone();
        }
        private void LLenarTabla(List<eProveedor> lstProveedores)
        {   
            foreach (var proveedor in lstProveedores)
            {
                dr = dtProveedores.NewRow();
                dr["Id"] = proveedor.Id;
                dr["Codigo"] = proveedor.Codigo;
                dr["Nombre"] = proveedor.Nombre;
                dr["Descripcion"] = proveedor.Descripcion;
                dr["Correo"] = proveedor.Correo;
                dr["Celular"] = proveedor.Celular;

                dtProveedores.Rows.Add(dr);
            }
        }
        private eProveedor CargarProveedorAmodificar()
        {
            eProveedor modificaProveedor = new eProveedor();
            modificaProveedor.Id = Convert.ToInt32(dgvListaProveedor.CurrentRow.Cells["Id"].Value.ToString());
            modificaProveedor.Codigo = dgvListaProveedor.CurrentRow.Cells["Codigo"].Value.ToString();
            modificaProveedor.Nombre = dgvListaProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
            modificaProveedor.Descripcion = dgvListaProveedor.CurrentRow.Cells["Descripcion"].Value.ToString();
            modificaProveedor.Correo = dgvListaProveedor.CurrentRow.Cells["Correo"].Value.ToString();
            modificaProveedor.Celular = Convert.ToInt32(dgvListaProveedor.CurrentRow.Cells["Celular"].Value.ToString());

            return modificaProveedor;
        }


        #endregion


    }
}
