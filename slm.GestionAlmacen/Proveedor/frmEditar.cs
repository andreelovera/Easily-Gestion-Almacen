using slm.Entidad.Proveedor;
using slm.Logica.Proveedor;
using System;
using System.Data;
using System.Windows.Forms;

namespace slm.GestionAlmacen.Proveedor
{
    public partial class frmEditar : Form
    {
        #region Entidades
        lProveedor lProveedor = new lProveedor();
        public eProveedor modificaProveedor = new eProveedor();
        #endregion

        #region Modelo DT
        public DataTable dtProveedores;
        public DataRow dr;
        #endregion

        #region Metodos Form
        public frmEditar()
        {
            InitializeComponent();
        }
        private void frmEditar_Load(object sender, EventArgs e)
        {
            lblValId.Text = modificaProveedor.Id.ToString().Trim();
            txtCodigo.Text = modificaProveedor.Codigo.Trim();
            txtNombre.Text = modificaProveedor.Nombre.Trim();
            txtDescripcion.Text = modificaProveedor.Descripcion.Trim();
            txtCorreo.Text = modificaProveedor.Correo.Trim();
            txtCelular.Text = modificaProveedor.Celular.ToString().Trim();
        }
        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea modificar el proveedor?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!ValidateCamposVacios())
                        throw new Exception("Todos los campos deben estar llenos");  //MessageBox.Show("Todos los campos deben estar llenos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    eProveedor eProveedor = new eProveedor();
                    eProveedor.Codigo = txtCodigo.Text.Trim();
                    eProveedor.Nombre = txtNombre.Text.Trim();
                    eProveedor.Descripcion = txtDescripcion.Text.Trim();
                    eProveedor.Correo = txtCorreo.Text.Trim();
                    eProveedor.Celular = Convert.ToInt32(txtCelular.Text.Trim());
                    eProveedor.Id = Convert.ToInt32(lblValId.Text.Trim());

                    var rsultado = lProveedor.Actualizar(eProveedor);
                    if (rsultado == 0)
                        throw new Exception("No se pudo modificar el proveedor");

                    eProveedor.Id = rsultado;
                    MessageBox.Show("Proveedor modificado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModificarDT(eProveedor);
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
        private void ModificarDT(eProveedor eProveedor)
        {
            dr = dtProveedores.Rows.Find(eProveedor.Id);
            dr["Id"] = eProveedor.Id;
            dr["Codigo"] = eProveedor.Codigo;
            dr["Nombre"] = eProveedor.Nombre;
            dr["Descripcion"] = eProveedor.Descripcion;
            dr["Correo"] = eProveedor.Correo;
            dr["Celular"] = eProveedor.Celular;
        }
        #endregion



    }
}
