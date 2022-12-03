using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slm.Entidad.Categoria;
using slm.Entidad.Marca;
using slm.Entidad.Producto;
using slm.Entidad.Proveedor;
using slm.Logica.Producto;

namespace slm.GestionAlmacen.Producto
{
    public partial class frmEditar : Form
    {


        #region Entidades
        lProducto lProducto = new lProducto();
        public eProducto eProducto = new eProducto();
        public string lblProveedor = "";
        #endregion

        #region Modelo DT
        public DataTable dtMarca;
        public DataTable dtCategoria;
        public DataTable dtProductoFiltrado;
        public DataRow dr;
        #endregion

        #region Metodos From
        public frmEditar()
        {
            InitializeComponent();
        }
        private void tsbEditarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar el producto?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!ValidateCamposVacios())
                        throw new Exception("Todos los campos deben estar llenos");

                    eProducto eProductoModiciado = new eProducto();
                    eMarca eMarca = new eMarca();
                    eCategoria eCategoria = new eCategoria();

                    eProductoModiciado.IdMarca = int.Parse(cboMarca.SelectedValue.ToString());
                    eMarca.Nombre = cboMarca.Text;
                    eProductoModiciado.Marca = eMarca;
                    eProductoModiciado.IdCategoria = int.Parse(cboCategoria.SelectedValue.ToString());
                    eCategoria.Nombre = cboCategoria.Text;
                    eProductoModiciado.Categoria = eCategoria;
                    eProductoModiciado.Codigo = txtCodigo.Text;
                    eProductoModiciado.Nombre = txtNombre.Text;
                    eProductoModiciado.Precio = nudPrecio.Value;
                    eProductoModiciado.Stock = nudStock.Value;
                    eProductoModiciado.Id = Convert.ToInt32(lblValId.Text);
                    eProductoModiciado.FechaCreacion = eProducto.FechaCreacion;
                    eProductoModiciado.FechaStock = eProducto.FechaStock;
                    if (eProductoModiciado.Stock != eProducto.Stock)
                        eProductoModiciado.FechaStock = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                    var rsultado = lProducto.Actualizar(eProductoModiciado);
                    if (rsultado == 0)
                        throw new Exception("No se pudo modificar el producto");

                    eProductoModiciado.Id = rsultado;
                    MessageBox.Show("producto modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModificarDT(eProductoModiciado);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error -> " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmEditar_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarCampos();
        }
        #endregion

        #region Metodos Nuevos
        private void ModificarDT(eProducto producto)
        {
            dr = dtProductoFiltrado.Rows.Find(producto.Id);
            dr["Id"] = producto.Id;
            dr["IdMarca"] = producto.IdMarca;
            dr["IdProveedor"] = Convert.ToInt32(lblProveedor);
            dr["NombreMarca"] = producto.Marca.Nombre;
            dr["IdCategoria"] = producto.IdCategoria;
            dr["NombreCategoria"] = producto.Categoria.Nombre;
            dr["Codigo"] = producto.Codigo;
            dr["Nombre"] = producto.Nombre;
            dr["Precio"] = producto.Precio;
            dr["Stock"] = producto.Stock;
            dr["FechaCreacion"] = producto.FechaCreacion.ToString("dd/MM/yyyy");
            dr["FechaStock"] = producto.FechaStock.ToString("dd/MM/yyyy");
        }
        private void LlenarDT(eProducto producto)
        {
          
        }
        private bool ValidateCamposVacios()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void CargarCombo()
        {
            cboCategoria.DataSource = dtCategoria;
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "Id";
            cboCategoria.SelectedValue = eProducto.IdCategoria;

            var dtMarcaFiltrada = dtMarca.Select("IdProveedor = " + lblProveedor);
            if (dtMarcaFiltrada.Count() > 0)
            {
                cboMarca.DataSource = dtMarcaFiltrada.CopyToDataTable();
                cboMarca.DisplayMember = "Nombre";
                cboMarca.ValueMember = "Id";
                cboMarca.SelectedValue= eProducto.IdMarca;
            }


        }
        private void CargarCampos()
        {
            lblValId.Text = eProducto.Id.ToString();
            txtCodigo.Text = eProducto.Codigo;
            txtNombre.Text = eProducto.Nombre;
            nudPrecio.Value = eProducto.Precio;
            nudStock.Value = eProducto.Stock;

        }
        #endregion

       
    }
}
