
namespace TP2Grupo1B
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsBtnListadoDeArtículos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnBusquedaDeArticulos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnModificarArtículo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTexto = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModificar
            // 
            this.lblModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblModificar.Location = new System.Drawing.Point(452, 264);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(50, 13);
            this.lblModificar.TabIndex = 28;
            this.lblModificar.Text = "Modificar";
            // 
            // lblAgregar
            // 
            this.lblAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAgregar.Location = new System.Drawing.Point(396, 264);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblAgregar.TabIndex = 27;
            this.lblAgregar.Text = "Agregar";
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBuscar.Location = new System.Drawing.Point(341, 264);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 26;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblListado
            // 
            this.lblListado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblListado.Location = new System.Drawing.Point(285, 264);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(41, 13);
            this.lblListado.TabIndex = 25;
            this.lblListado.Text = "Listado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnListadoDeArtículos,
            this.toolStripSeparator1,
            this.tlsBtnBusquedaDeArticulos,
            this.toolStripSeparator2,
            this.tlsBtnAgregar,
            this.toolStripSeparator3,
            this.tlsBtnModificarArtículo,
            this.toolStripSeparator4,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(271, 214);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(245, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsBtnListadoDeArtículos
            // 
            this.tlsBtnListadoDeArtículos.AutoSize = false;
            this.tlsBtnListadoDeArtículos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnListadoDeArtículos.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnListadoDeArtículos.Image")));
            this.tlsBtnListadoDeArtículos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnListadoDeArtículos.Name = "tlsBtnListadoDeArtículos";
            this.tlsBtnListadoDeArtículos.Size = new System.Drawing.Size(50, 50);
            this.tlsBtnListadoDeArtículos.Text = "Listado de artículos";
            this.tlsBtnListadoDeArtículos.Click += new System.EventHandler(this.tlsBtnListadoDeArtículos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tlsBtnBusquedaDeArticulos
            // 
            this.tlsBtnBusquedaDeArticulos.AutoSize = false;
            this.tlsBtnBusquedaDeArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnBusquedaDeArticulos.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnBusquedaDeArticulos.Image")));
            this.tlsBtnBusquedaDeArticulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnBusquedaDeArticulos.Name = "tlsBtnBusquedaDeArticulos";
            this.tlsBtnBusquedaDeArticulos.Size = new System.Drawing.Size(50, 50);
            this.tlsBtnBusquedaDeArticulos.Text = "Busqueda de articulos";
            this.tlsBtnBusquedaDeArticulos.Click += new System.EventHandler(this.tlsBtnBusquedaDeArticulos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // tlsBtnAgregar
            // 
            this.tlsBtnAgregar.AutoSize = false;
            this.tlsBtnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnAgregar.Image")));
            this.tlsBtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnAgregar.Name = "tlsBtnAgregar";
            this.tlsBtnAgregar.Size = new System.Drawing.Size(50, 50);
            this.tlsBtnAgregar.Text = "Agrgar articulo";
            this.tlsBtnAgregar.Click += new System.EventHandler(this.tlsBtnAgregar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // tlsBtnModificarArtículo
            // 
            this.tlsBtnModificarArtículo.AutoSize = false;
            this.tlsBtnModificarArtículo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnModificarArtículo.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnModificarArtículo.Image")));
            this.tlsBtnModificarArtículo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnModificarArtículo.Name = "tlsBtnModificarArtículo";
            this.tlsBtnModificarArtículo.Size = new System.Drawing.Size(50, 50);
            this.tlsBtnModificarArtículo.Text = "Modificar artículo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 50);
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTexto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTexto.Location = new System.Drawing.Point(205, 144);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(390, 70);
            this.lblTexto.TabIndex = 23;
            this.lblTexto.Text = "Catalogo de articulos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTexto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsBtnListadoDeArtículos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsBtnBusquedaDeArticulos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsBtnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlsBtnModificarArtículo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label lblTexto;
    }
}

