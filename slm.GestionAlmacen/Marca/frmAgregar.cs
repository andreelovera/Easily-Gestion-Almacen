using slm.Entidad.Categoria;
using slm.Entidad.Marca;
using slm.Logica.Categoria;
using slm.Logica.Marca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slm.GestionAlmacen.Marca
{
    public partial class frmAgregar : Form
    {

        #region Entidades
        lMarca lMarca = new lMarca();
        #endregion

        #region Modelo DT
        public DataTable dtMarca;
        public DataRow dr;
        public string idProveedor = "";
        #endregion

        #region Metodos Nuevos
        private void LlenarDT(eMarca marca)
        {
            dr = dtMarca.NewRow();
            dr["Id"] = marca.Id;
            dr["Codigo"] = marca.Codigo;
            dr["IdProveedor"] = marca.IdProveedor;
            dr["Nombre"] = marca.Nombre;
            dtMarca.Rows.Add(dr);
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
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void tsbAgregarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea registrar una nueva marca?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!ValidateCamposVacios())
                        throw new Exception("Todos los campos deben estar llenos");//MessageBox.Show("Todos los campos deben estar llenos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    eMarca eMarca = new eMarca();
                    eMarca.Codigo = txtCodigo.Text.Trim();
                    eMarca.IdProveedor = Convert.ToInt32(idProveedor);
                    eMarca.Nombre = txtNombre.Text.Trim();


                    var rsultado = lMarca.Crear(eMarca);
                    if (rsultado == 0)
                        throw new Exception("No se pudo registrar la marca");

                    eMarca.Id = rsultado;
                    MessageBox.Show("marca registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDT(eMarca);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error -> " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
