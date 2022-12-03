using slm.Entidad.Categoria;
using slm.Entidad.Marca;
using slm.Entidad.Producto;
using slm.Entidad.Proveedor;
using slm.Logica.Producto;
using slm.Logica.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slm.GestionAlmacen.Producto
{
    public partial class frmAgregar : Form
    {
        #region Entidades
        lProducto lProducto = new lProducto();
        public string lblProveedor = "";
        #endregion

        #region Modelo DT
        public DataTable dtMarca;
        public DataTable dtCategoria;
        public DataTable dtProductoFiltrado;
        public DataRow dr;
        #endregion

        #region Metodos Form
        public frmAgregar()
        {
            InitializeComponent();
        }
        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void tsbAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea registrar un nuevo producto?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!ValidateCamposVacios())
                        throw new Exception("Todos los campos deben estar llenos");

                    eProducto eProducto = new eProducto();
                    eMarca eMarca = new eMarca();
                    eCategoria eCategoria = new eCategoria();

                    eProducto.IdMarca = int.Parse(cboMarca.SelectedValue.ToString());
                    eMarca.Nombre = cboMarca.Text;
                    eProducto.Marca = eMarca;
                    eProducto.IdCategoria = int.Parse(cboCategoria.SelectedValue.ToString());
                    eCategoria.Nombre = cboCategoria.Text;
                    eProducto.Categoria = eCategoria;
                    eProducto.Codigo = txtCodigo.Text;
                    eProducto.Nombre = txtNombre.Text;
                    eProducto.Precio = nudPrecio.Value;
                    eProducto.Stock = nudStock.Value;

                    var rsultado = lProducto.Crear(eProducto);
                    if (rsultado == 0)
                        throw new Exception("No se pudo registrar el producto");

                    eProducto.Id = rsultado;
                    MessageBox.Show("producto registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDT(eProducto);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error -> " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos Nuevos
        private void LlenarDT(eProducto producto)
        {
            dr = dtProductoFiltrado.NewRow();
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
            dr["FechaCreacion"] = DateTime.Now.ToString("dd/MM/yyyy");
            dr["FechaStock"] = DateTime.Now.ToString("dd/MM/yyyy");
            dtProductoFiltrado.Rows.Add(dr);
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

            var dtMarcaFiltrada = dtMarca.Select("IdProveedor = " + lblProveedor);
            if (dtMarcaFiltrada.Count() > 0)
            {
                cboMarca.DataSource = dtMarcaFiltrada.CopyToDataTable();
                cboMarca.DisplayMember = "Nombre";
                cboMarca.ValueMember = "Id";
            }

        }
        #endregion
    }
}
