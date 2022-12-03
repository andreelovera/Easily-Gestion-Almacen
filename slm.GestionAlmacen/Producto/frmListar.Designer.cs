namespace slm.GestionAlmacen.Producto
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
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.txtFiltroProducto = new System.Windows.Forms.TextBox();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsProducto = new System.Windows.Forms.ToolStrip();
            this.tsbAgregarProducto = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarProdicto = new System.Windows.Forms.ToolStripButton();
            this.tsbMarca = new System.Windows.Forms.ToolStripButton();
            this.tsbCategoria = new System.Windows.Forms.ToolStripButton();
            this.ssProducto = new System.Windows.Forms.StatusStrip();
            this.lblMess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNombreProveedor = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIdProveedor = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tsProducto.SuspendLayout();
            this.ssProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.txtFiltroProducto);
            this.gbProducto.Location = new System.Drawing.Point(13, 42);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(775, 56);
            this.gbProducto.TabIndex = 0;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Buscar";
            // 
            // txtFiltroProducto
            // 
            this.txtFiltroProducto.Location = new System.Drawing.Point(7, 22);
            this.txtFiltroProducto.Name = "txtFiltroProducto";
            this.txtFiltroProducto.Size = new System.Drawing.Size(762, 22);
            this.txtFiltroProducto.TabIndex = 0;
            this.txtFiltroProducto.TextChanged += new System.EventHandler(this.txtFiltroProducto_TextChanged);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdMarca,
            this.IdProveedor,
            this.Marca,
            this.IdCategoria,
            this.Categoria,
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Stock,
            this.FechaCreacion,
            this.FechaStock});
            this.dgvProducto.Location = new System.Drawing.Point(13, 119);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersVisible = false;
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.RowTemplate.Height = 24;
            this.dgvProducto.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(775, 319);
            this.dgvProducto.TabIndex = 1;
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
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "IdMarca";
            this.IdMarca.HeaderText = "IdMarca";
            this.IdMarca.MinimumWidth = 6;
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            this.IdMarca.Visible = false;
            this.IdMarca.Width = 125;
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "IdProveedor";
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.MinimumWidth = 6;
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            this.IdProveedor.Width = 125;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "NombreMarca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 70;
            // 
            // IdCategoria
            // 
            this.IdCategoria.DataPropertyName = "IdCategoria";
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.MinimumWidth = 6;
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            this.IdCategoria.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "NombreCategoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 70;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 60;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "Fecha Actualizacion";
            this.FechaCreacion.MinimumWidth = 6;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 130;
            // 
            // FechaStock
            // 
            this.FechaStock.DataPropertyName = "FechaStock";
            this.FechaStock.HeaderText = "Fecha Stock";
            this.FechaStock.MinimumWidth = 6;
            this.FechaStock.Name = "FechaStock";
            this.FechaStock.ReadOnly = true;
            this.FechaStock.Width = 130;
            // 
            // tsProducto
            // 
            this.tsProducto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregarProducto,
            this.tsbEditarProdicto,
            this.tsbMarca,
            this.tsbCategoria});
            this.tsProducto.Location = new System.Drawing.Point(0, 0);
            this.tsProducto.Name = "tsProducto";
            this.tsProducto.Size = new System.Drawing.Size(800, 27);
            this.tsProducto.TabIndex = 2;
            this.tsProducto.Text = "toolStrip1";
            // 
            // tsbAgregarProducto
            // 
            this.tsbAgregarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregarProducto.Image")));
            this.tsbAgregarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarProducto.Name = "tsbAgregarProducto";
            this.tsbAgregarProducto.Size = new System.Drawing.Size(29, 24);
            this.tsbAgregarProducto.Text = "Agregar Producto";
            this.tsbAgregarProducto.Click += new System.EventHandler(this.tsbAgregarProducto_Click);
            // 
            // tsbEditarProdicto
            // 
            this.tsbEditarProdicto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditarProdicto.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditarProdicto.Image")));
            this.tsbEditarProdicto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarProdicto.Name = "tsbEditarProdicto";
            this.tsbEditarProdicto.Size = new System.Drawing.Size(29, 24);
            this.tsbEditarProdicto.Text = "Editar Producto";
            this.tsbEditarProdicto.Click += new System.EventHandler(this.tsbEditarProdicto_Click);
            // 
            // tsbMarca
            // 
            this.tsbMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMarca.Image = ((System.Drawing.Image)(resources.GetObject("tsbMarca.Image")));
            this.tsbMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMarca.Name = "tsbMarca";
            this.tsbMarca.Size = new System.Drawing.Size(29, 24);
            this.tsbMarca.Text = "Agregar Marca";
            this.tsbMarca.Click += new System.EventHandler(this.tsbMarca_Click);
            // 
            // tsbCategoria
            // 
            this.tsbCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsbCategoria.Image")));
            this.tsbCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCategoria.Name = "tsbCategoria";
            this.tsbCategoria.Size = new System.Drawing.Size(29, 24);
            this.tsbCategoria.Text = "Agregar Categoria";
            this.tsbCategoria.Click += new System.EventHandler(this.tsbCategoria_Click);
            // 
            // ssProducto
            // 
            this.ssProducto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMess,
            this.tssNombreProveedor,
            this.lblIdProveedor});
            this.ssProducto.Location = new System.Drawing.Point(0, 447);
            this.ssProducto.Name = "ssProducto";
            this.ssProducto.Size = new System.Drawing.Size(800, 26);
            this.ssProducto.TabIndex = 3;
            this.ssProducto.Text = "statusStrip1";
            // 
            // lblMess
            // 
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(96, 20);
            this.lblMess.Text = "PROVEEDOR:";
            // 
            // tssNombreProveedor
            // 
            this.tssNombreProveedor.Name = "tssNombreProveedor";
            this.tssNombreProveedor.Size = new System.Drawing.Size(132, 20);
            this.tssNombreProveedor.Text = "NombreProveedor";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.lblIdProveedor.Size = new System.Drawing.Size(0, 20);
            this.lblIdProveedor.Visible = false;
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.ssProducto);
            this.Controls.Add(this.tsProducto);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.gbProducto);
            this.Name = "frmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Productos";
            this.Load += new System.EventHandler(this.frmListar_Load);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tsProducto.ResumeLayout(false);
            this.tsProducto.PerformLayout();
            this.ssProducto.ResumeLayout(false);
            this.ssProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.ToolStrip tsProducto;
        private System.Windows.Forms.ToolStripButton tsbAgregarProducto;
        private System.Windows.Forms.ToolStripButton tsbEditarProdicto;
        private System.Windows.Forms.StatusStrip ssProducto;
        public System.Windows.Forms.ToolStripStatusLabel tssNombreProveedor;
        private System.Windows.Forms.ToolStripStatusLabel lblMess;
        private System.Windows.Forms.TextBox txtFiltroProducto;
        public System.Windows.Forms.ToolStripStatusLabel lblIdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaStock;
        private System.Windows.Forms.ToolStripButton tsbMarca;
        private System.Windows.Forms.ToolStripButton tsbCategoria;
    }
}