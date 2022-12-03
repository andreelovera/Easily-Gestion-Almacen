namespace slm.GestionAlmacen.Proveedor
{
    partial class frmListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListar));
            this.tsListaProveedor = new System.Windows.Forms.ToolStrip();
            this.tsbAgregarProveedor = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarProveedor = new System.Windows.Forms.ToolStripButton();
            this.gbListaProveedor = new System.Windows.Forms.GroupBox();
            this.dgvListaProveedor = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarProveedor = new System.Windows.Forms.GroupBox();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.tsListaProveedor.SuspendLayout();
            this.gbListaProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedor)).BeginInit();
            this.gbBuscarProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsListaProveedor
            // 
            this.tsListaProveedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsListaProveedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregarProveedor,
            this.tsbEditarProveedor});
            this.tsListaProveedor.Location = new System.Drawing.Point(0, 0);
            this.tsListaProveedor.Name = "tsListaProveedor";
            this.tsListaProveedor.Size = new System.Drawing.Size(455, 27);
            this.tsListaProveedor.TabIndex = 4;
            this.tsListaProveedor.Text = "toolStrip1";
            // 
            // tsbAgregarProveedor
            // 
            this.tsbAgregarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregarProveedor.Image")));
            this.tsbAgregarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarProveedor.Name = "tsbAgregarProveedor";
            this.tsbAgregarProveedor.Size = new System.Drawing.Size(29, 24);
            this.tsbAgregarProveedor.Text = "Agregar Proveedor";
            this.tsbAgregarProveedor.Click += new System.EventHandler(this.tsbAgregarProveedor_Click);
            // 
            // tsbEditarProveedor
            // 
            this.tsbEditarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditarProveedor.Image")));
            this.tsbEditarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarProveedor.Name = "tsbEditarProveedor";
            this.tsbEditarProveedor.Size = new System.Drawing.Size(29, 24);
            this.tsbEditarProveedor.Text = "Editar Proveedor";
            this.tsbEditarProveedor.Click += new System.EventHandler(this.tsbEditarProveedor_Click);
            // 
            // gbListaProveedor
            // 
            this.gbListaProveedor.Controls.Add(this.dgvListaProveedor);
            this.gbListaProveedor.Location = new System.Drawing.Point(12, 103);
            this.gbListaProveedor.Name = "gbListaProveedor";
            this.gbListaProveedor.Size = new System.Drawing.Size(437, 181);
            this.gbListaProveedor.TabIndex = 3;
            this.gbListaProveedor.TabStop = false;
            this.gbListaProveedor.Text = "Seleccione Proveedor";
            // 
            // dgvListaProveedor
            // 
            this.dgvListaProveedor.AllowUserToAddRows = false;
            this.dgvListaProveedor.AllowUserToDeleteRows = false;
            this.dgvListaProveedor.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Correo,
            this.Celular});
            this.dgvListaProveedor.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvListaProveedor.Location = new System.Drawing.Point(18, 22);
            this.dgvListaProveedor.MultiSelect = false;
            this.dgvListaProveedor.Name = "dgvListaProveedor";
            this.dgvListaProveedor.RowHeadersVisible = false;
            this.dgvListaProveedor.RowHeadersWidth = 51;
            this.dgvListaProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaProveedor.RowTemplate.Height = 24;
            this.dgvListaProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProveedor.Size = new System.Drawing.Size(401, 142);
            this.dgvListaProveedor.TabIndex = 0;
            this.dgvListaProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProveedor_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 172;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            this.Descripcion.Width = 125;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Visible = false;
            this.Correo.Width = 125;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 6;
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Visible = false;
            this.Celular.Width = 125;
            // 
            // gbBuscarProveedor
            // 
            this.gbBuscarProveedor.Controls.Add(this.txtBuscarProveedor);
            this.gbBuscarProveedor.Location = new System.Drawing.Point(13, 49);
            this.gbBuscarProveedor.Name = "gbBuscarProveedor";
            this.gbBuscarProveedor.Size = new System.Drawing.Size(436, 48);
            this.gbBuscarProveedor.TabIndex = 5;
            this.gbBuscarProveedor.TabStop = false;
            this.gbBuscarProveedor.Text = "Buscar Proveedor";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarProveedor.Location = new System.Drawing.Point(17, 22);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(401, 15);
            this.txtBuscarProveedor.TabIndex = 0;
            this.txtBuscarProveedor.TextChanged += new System.EventHandler(this.txtBuscarProveedor_TextChanged);
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 288);
            this.Controls.Add(this.gbBuscarProveedor);
            this.Controls.Add(this.tsListaProveedor);
            this.Controls.Add(this.gbListaProveedor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Proveedor";
            this.Load += new System.EventHandler(this.frmListaProveedor_Load);
            this.tsListaProveedor.ResumeLayout(false);
            this.tsListaProveedor.PerformLayout();
            this.gbListaProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedor)).EndInit();
            this.gbBuscarProveedor.ResumeLayout(false);
            this.gbBuscarProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsListaProveedor;
        private System.Windows.Forms.ToolStripButton tsbAgregarProveedor;
        private System.Windows.Forms.GroupBox gbListaProveedor;
        private System.Windows.Forms.DataGridView dgvListaProveedor;
        private System.Windows.Forms.ToolStripButton tsbEditarProveedor;
        private System.Windows.Forms.GroupBox gbBuscarProveedor;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}