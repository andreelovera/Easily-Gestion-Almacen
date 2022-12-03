using slm.Entidad.Proveedor;
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

namespace slm.GestionAlmacen.Proveedor
{
    public partial class frmAgregar : Form
    {
        #region Entidades
        lProveedor lProveedor = new lProveedor();
        #endregion

        #region Modelo DT
        public DataTable dtProveedores;
        public DataRow dr;
        #endregion

        #region Metodos Form
        public frmAgregar()
        {
            InitializeComponent();
        }
        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea registrar un nuevo proveedor?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!ValidateCamposVacios())
                        throw new Exception("Todos los campos deben estar llenos");//MessageBox.Show("Todos los campos deben estar llenos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    eProveedor eProveedor = new eProveedor();
                    eProveedor.Codigo = txtCodigo.Text.Trim();
                    eProveedor.Nombre = txtNombre.Text.Trim();
                    eProveedor.Descripcion = txtDescripcion.Text.Trim();
                    eProveedor.Correo = txtCorreo.Text.Trim();
                    eProveedor.Celular = Convert.ToInt32(txtCelular.Text.Trim());

                    var rsultado = lProveedor.Crear(eProveedor);
                    if (rsultado == 0)
                        throw new Exception("No se pudo registrar el proveedor");

                    eProveedor.Id = rsultado;
                    MessageBox.Show("Proveedor registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDT(eProveedor);
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error -> " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Metodos Nuevos
        private void LlenarDT(eProveedor eProveedor)
        {
            dr = dtProveedores.NewRow();
            dr["Id"] = eProveedor.Id;
            dr["Codigo"] = eProveedor.Codigo;
            dr["Nombre"] = eProveedor.Nombre;
            dr["Descripcion"] = eProveedor.Descripcion;
            dr["Correo"] = eProveedor.Correo;
            dr["Celular"] = eProveedor.Celular;
            dtProveedores.Rows.Add(dr);
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
        #endregion


    }
}
