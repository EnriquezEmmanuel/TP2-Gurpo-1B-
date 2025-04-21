
namespace TP2Grupo1B
{
    partial class frmModificar
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
            this.pbxProductoModificar = new System.Windows.Forms.PictureBox();
            this.lbModCodigo = new System.Windows.Forms.Label();
            this.lbModNombre = new System.Windows.Forms.Label();
            this.lbModDescripcion = new System.Windows.Forms.Label();
            this.lbModMarca = new System.Windows.Forms.Label();
            this.lbModPrecio = new System.Windows.Forms.Label();
            this.lbModImagen = new System.Windows.Forms.Label();
            this.lbModCategoria = new System.Windows.Forms.Label();
            this.txModCodigo = new System.Windows.Forms.TextBox();
            this.txModNombre = new System.Windows.Forms.TextBox();
            this.txModDescripcion = new System.Windows.Forms.TextBox();
            this.txModImagen = new System.Windows.Forms.TextBox();
            this.txModPrecio = new System.Windows.Forms.TextBox();
            this.cboModMarca = new System.Windows.Forms.ComboBox();
            this.cboModCategoria = new System.Windows.Forms.ComboBox();
            this.btnModModificar = new System.Windows.Forms.Button();
            this.dgvModListado = new System.Windows.Forms.DataGridView();
            this.txIdOcutlto = new System.Windows.Forms.TextBox();
            this.lblListadoArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductoModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModListado)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxProductoModificar
            // 
            this.pbxProductoModificar.Location = new System.Drawing.Point(474, 114);
            this.pbxProductoModificar.Name = "pbxProductoModificar";
            this.pbxProductoModificar.Size = new System.Drawing.Size(223, 229);
            this.pbxProductoModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProductoModificar.TabIndex = 2;
            this.pbxProductoModificar.TabStop = false;
            // 
            // lbModCodigo
            // 
            this.lbModCodigo.AutoSize = true;
            this.lbModCodigo.Location = new System.Drawing.Point(174, 117);
            this.lbModCodigo.Name = "lbModCodigo";
            this.lbModCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbModCodigo.TabIndex = 3;
            this.lbModCodigo.Text = "Código";
            // 
            // lbModNombre
            // 
            this.lbModNombre.AutoSize = true;
            this.lbModNombre.Location = new System.Drawing.Point(170, 148);
            this.lbModNombre.Name = "lbModNombre";
            this.lbModNombre.Size = new System.Drawing.Size(44, 13);
            this.lbModNombre.TabIndex = 4;
            this.lbModNombre.Text = "Nombre";
            // 
            // lbModDescripcion
            // 
            this.lbModDescripcion.AutoSize = true;
            this.lbModDescripcion.Location = new System.Drawing.Point(151, 179);
            this.lbModDescripcion.Name = "lbModDescripcion";
            this.lbModDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbModDescripcion.TabIndex = 5;
            this.lbModDescripcion.Text = "Descripcion";
            // 
            // lbModMarca
            // 
            this.lbModMarca.AutoSize = true;
            this.lbModMarca.Location = new System.Drawing.Point(177, 210);
            this.lbModMarca.Name = "lbModMarca";
            this.lbModMarca.Size = new System.Drawing.Size(37, 13);
            this.lbModMarca.TabIndex = 6;
            this.lbModMarca.Text = "Marca";
            // 
            // lbModPrecio
            // 
            this.lbModPrecio.AutoSize = true;
            this.lbModPrecio.Location = new System.Drawing.Point(177, 303);
            this.lbModPrecio.Name = "lbModPrecio";
            this.lbModPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbModPrecio.TabIndex = 9;
            this.lbModPrecio.Text = "Precio";
            // 
            // lbModImagen
            // 
            this.lbModImagen.AutoSize = true;
            this.lbModImagen.Location = new System.Drawing.Point(172, 272);
            this.lbModImagen.Name = "lbModImagen";
            this.lbModImagen.Size = new System.Drawing.Size(42, 13);
            this.lbModImagen.TabIndex = 8;
            this.lbModImagen.Text = "Imagen";
            // 
            // lbModCategoria
            // 
            this.lbModCategoria.AutoSize = true;
            this.lbModCategoria.Location = new System.Drawing.Point(160, 241);
            this.lbModCategoria.Name = "lbModCategoria";
            this.lbModCategoria.Size = new System.Drawing.Size(54, 13);
            this.lbModCategoria.TabIndex = 7;
            this.lbModCategoria.Text = "Categoría";
            // 
            // txModCodigo
            // 
            this.txModCodigo.Location = new System.Drawing.Point(220, 114);
            this.txModCodigo.Name = "txModCodigo";
            this.txModCodigo.Size = new System.Drawing.Size(216, 20);
            this.txModCodigo.TabIndex = 10;
            this.txModCodigo.TextChanged += new System.EventHandler(this.txModCodigo_TextChanged);
            // 
            // txModNombre
            // 
            this.txModNombre.Location = new System.Drawing.Point(220, 145);
            this.txModNombre.Name = "txModNombre";
            this.txModNombre.Size = new System.Drawing.Size(216, 20);
            this.txModNombre.TabIndex = 11;
            // 
            // txModDescripcion
            // 
            this.txModDescripcion.Location = new System.Drawing.Point(220, 176);
            this.txModDescripcion.Name = "txModDescripcion";
            this.txModDescripcion.Size = new System.Drawing.Size(216, 20);
            this.txModDescripcion.TabIndex = 12;
            // 
            // txModImagen
            // 
            this.txModImagen.Location = new System.Drawing.Point(220, 271);
            this.txModImagen.Name = "txModImagen";
            this.txModImagen.Size = new System.Drawing.Size(216, 20);
            this.txModImagen.TabIndex = 13;
            this.txModImagen.Leave += new System.EventHandler(this.txModImagen_Leave);
            // 
            // txModPrecio
            // 
            this.txModPrecio.Location = new System.Drawing.Point(220, 302);
            this.txModPrecio.Name = "txModPrecio";
            this.txModPrecio.Size = new System.Drawing.Size(216, 20);
            this.txModPrecio.TabIndex = 14;
            // 
            // cboModMarca
            // 
            this.cboModMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModMarca.FormattingEnabled = true;
            this.cboModMarca.Location = new System.Drawing.Point(220, 207);
            this.cboModMarca.Name = "cboModMarca";
            this.cboModMarca.Size = new System.Drawing.Size(121, 21);
            this.cboModMarca.TabIndex = 15;
            // 
            // cboModCategoria
            // 
            this.cboModCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModCategoria.FormattingEnabled = true;
            this.cboModCategoria.Location = new System.Drawing.Point(220, 239);
            this.cboModCategoria.Name = "cboModCategoria";
            this.cboModCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboModCategoria.TabIndex = 16;
            // 
            // btnModModificar
            // 
            this.btnModModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModModificar.Location = new System.Drawing.Point(220, 357);
            this.btnModModificar.Name = "btnModModificar";
            this.btnModModificar.Size = new System.Drawing.Size(131, 39);
            this.btnModModificar.TabIndex = 17;
            this.btnModModificar.Text = "Modificar";
            this.btnModModificar.UseVisualStyleBackColor = true;
            this.btnModModificar.Click += new System.EventHandler(this.btnModModificar_Click);
            // 
            // dgvModListado
            // 
            this.dgvModListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModListado.Location = new System.Drawing.Point(72, 413);
            this.dgvModListado.Name = "dgvModListado";
            this.dgvModListado.Size = new System.Drawing.Size(742, 150);
            this.dgvModListado.TabIndex = 18;
            // 
            // txIdOcutlto
            // 
            this.txIdOcutlto.Location = new System.Drawing.Point(474, 367);
            this.txIdOcutlto.Name = "txIdOcutlto";
            this.txIdOcutlto.Size = new System.Drawing.Size(100, 20);
            this.txIdOcutlto.TabIndex = 19;
            this.txIdOcutlto.Visible = false;
            // 
            // lblListadoArticulo
            // 
            this.lblListadoArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListadoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoArticulo.Location = new System.Drawing.Point(321, 33);
            this.lblListadoArticulo.Name = "lblListadoArticulo";
            this.lblListadoArticulo.Size = new System.Drawing.Size(376, 37);
            this.lblListadoArticulo.TabIndex = 37;
            this.lblListadoArticulo.Text = "Modificacion de Articulos ";
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(997, 579);
            this.Controls.Add(this.lblListadoArticulo);
            this.Controls.Add(this.txIdOcutlto);
            this.Controls.Add(this.dgvModListado);
            this.Controls.Add(this.btnModModificar);
            this.Controls.Add(this.cboModCategoria);
            this.Controls.Add(this.cboModMarca);
            this.Controls.Add(this.txModPrecio);
            this.Controls.Add(this.txModImagen);
            this.Controls.Add(this.txModDescripcion);
            this.Controls.Add(this.txModNombre);
            this.Controls.Add(this.txModCodigo);
            this.Controls.Add(this.lbModPrecio);
            this.Controls.Add(this.lbModImagen);
            this.Controls.Add(this.lbModCategoria);
            this.Controls.Add(this.lbModMarca);
            this.Controls.Add(this.lbModDescripcion);
            this.Controls.Add(this.lbModNombre);
            this.Controls.Add(this.lbModCodigo);
            this.Controls.Add(this.pbxProductoModificar);
            this.Name = "frmModificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductoModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProductoModificar;
        private System.Windows.Forms.Label lbModCodigo;
        private System.Windows.Forms.Label lbModNombre;
        private System.Windows.Forms.Label lbModDescripcion;
        private System.Windows.Forms.Label lbModMarca;
        private System.Windows.Forms.Label lbModPrecio;
        private System.Windows.Forms.Label lbModImagen;
        private System.Windows.Forms.Label lbModCategoria;
        private System.Windows.Forms.TextBox txModCodigo;
        private System.Windows.Forms.TextBox txModNombre;
        private System.Windows.Forms.TextBox txModDescripcion;
        private System.Windows.Forms.TextBox txModImagen;
        private System.Windows.Forms.TextBox txModPrecio;
        private System.Windows.Forms.ComboBox cboModMarca;
        private System.Windows.Forms.ComboBox cboModCategoria;
        private System.Windows.Forms.Button btnModModificar;
        private System.Windows.Forms.DataGridView dgvModListado;
        private System.Windows.Forms.TextBox txIdOcutlto;
        private System.Windows.Forms.Label lblListadoArticulo;
    }
}