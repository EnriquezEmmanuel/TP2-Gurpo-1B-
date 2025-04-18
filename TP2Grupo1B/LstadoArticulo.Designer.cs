namespace TP2Grupo1B
{
    partial class LstadoArticulo
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
            this.lblListadoDeArticulos = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListadoDeArticulos
            // 
            this.lblListadoDeArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListadoDeArticulos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblListadoDeArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoDeArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListadoDeArticulos.Location = new System.Drawing.Point(147, 69);
            this.lblListadoDeArticulos.Name = "lblListadoDeArticulos";
            this.lblListadoDeArticulos.Size = new System.Drawing.Size(500, 60);
            this.lblListadoDeArticulos.TabIndex = 5;
            this.lblListadoDeArticulos.Text = "ListadoDeArticulos";
            // 
            // btnListar
            // 
            this.btnListar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListar.Location = new System.Drawing.Point(322, 137);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(150, 40);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Buscar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(69, 216);
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.Size = new System.Drawing.Size(663, 320);
            this.dgvListadoArticulos.TabIndex = 3;
            // 
            // LstadoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.lblListadoDeArticulos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListadoArticulos);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "LstadoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LstadoArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListadoDeArticulos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListadoArticulos;
    }
}