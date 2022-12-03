namespace slm.GestionAlmacen.Proveedor
{
    partial class frmEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            this.tsEditarProveedor = new System.Windows.Forms.ToolStrip();
            this.btnEditarProveedor = new System.Windows.Forms.ToolStripButton();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblValId = new System.Windows.Forms.Label();
            this.tsEditarProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsEditarProveedor
            // 
            this.tsEditarProveedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsEditarProveedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditarProveedor});
            this.tsEditarProveedor.Location = new System.Drawing.Point(0, 0);
            this.tsEditarProveedor.Name = "tsEditarProveedor";
            this.tsEditarProveedor.Size = new System.Drawing.Size(311, 27);
            this.tsEditarProveedor.TabIndex = 21;
            this.tsEditarProveedor.Text = "toolStrip1";
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProveedor.Image")));
            this.btnEditarProveedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(29, 24);
            this.btnEditarProveedor.Text = "EditarProveedor";
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(109, 242);
            this.txtCelular.MaxLength = 9;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(110, 22);
            this.txtCelular.TabIndex = 20;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(12, 245);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(52, 16);
            this.lblCelular.TabIndex = 19;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(109, 208);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(183, 22);
            this.txtCorreo.TabIndex = 18;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(12, 214);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 16);
            this.lblCorreo.TabIndex = 17;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 145);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(183, 51);
            this.txtDescripcion.TabIndex = 16;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 148);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 117);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(109, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 22);
            this.txtCodigo.TabIndex = 12;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 46);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "ID:";
            // 
            // lblValId
            // 
            this.lblValId.AutoSize = true;
            this.lblValId.Location = new System.Drawing.Point(109, 46);
            this.lblValId.Name = "lblValId";
            this.lblValId.Size = new System.Drawing.Size(20, 16);
            this.lblValId.TabIndex = 24;
            this.lblValId.Text = "ID";
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 288);
            this.Controls.Add(this.lblValId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tsEditarProveedor);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditar";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            this.tsEditarProveedor.ResumeLayout(false);
            this.tsEditarProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsEditarProveedor;
        private System.Windows.Forms.ToolStripButton btnEditarProveedor;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblValId;
    }
}