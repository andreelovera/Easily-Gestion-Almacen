using slm.Entidad.Categoria;
using slm.Entidad.Producto;
using slm.Logica.Categoria;
using slm.Logica.Producto;
using slm.Logica.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slm.GestionAlmacen.Categoria
{
    public partial class frmAgregar : Form
    {

        #region Entidades
        lCategoria lCategoria = new lCategoria();
        #endregion

        #region Modelo DT
        public DataTable dtCategoria;
        public DataRow dr;
        #endregion
        public frmAgregar()
        {
            InitializeComponent();
        }

        #region Metodos Nuevos
        private void LlenarDT(eCategoria categoria)
        {
            dr = dtCategoria.NewRow();
            dr["Id"] = categoria.Id;
            dr["Codigo"] = categoria.Codigo;
            dr["Nombre"] = categoria.Nombre;
            dtCategoria.Rows.Add(dr);
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

        private void tsbAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea registrar una nueva categoria?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (!ValidateCamposVacios())
                        throw new Exception("Todos los campos deben estar llenos");//MessageBox.Show("Todos los campos deben estar llenos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    eCategoria eCategoria = new eCategoria();
                    eCategoria.Codigo = txtCodigo.Text.Trim();
                    eCategoria.Nombre = txtNombre.Text.Trim();


                    var rsultado = lCategoria.Crear(eCategoria);
                    if (rsultado == 0)
                        throw new Exception("No se pudo registrar la categoria");

                    eCategoria.Id = rsultado;
                    MessageBox.Show("categoria registrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDT(eCategoria);
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
