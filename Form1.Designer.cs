namespace WindowsFormsApp2
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
            this.BTNmostrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.DgDatos = new System.Windows.Forms.DataGridView();
            this.BTNimportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNmostrar
            // 
            this.BTNmostrar.Location = new System.Drawing.Point(156, 321);
            this.BTNmostrar.Name = "BTNmostrar";
            this.BTNmostrar.Size = new System.Drawing.Size(109, 52);
            this.BTNmostrar.TabIndex = 0;
            this.BTNmostrar.Text = "Mostrar";
            this.BTNmostrar.UseVisualStyleBackColor = true;
            this.BTNmostrar.Click += new System.EventHandler(this.BTNmostrar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(543, 321);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(109, 52);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // DgDatos
            // 
            this.DgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDatos.Location = new System.Drawing.Point(156, 75);
            this.DgDatos.Name = "DgDatos";
            this.DgDatos.Size = new System.Drawing.Size(496, 194);
            this.DgDatos.TabIndex = 2;
            // 
            // BTNimportar
            // 
            this.BTNimportar.Location = new System.Drawing.Point(355, 321);
            this.BTNimportar.Name = "BTNimportar";
            this.BTNimportar.Size = new System.Drawing.Size(109, 52);
            this.BTNimportar.TabIndex = 3;
            this.BTNimportar.Text = "importar";
            this.BTNimportar.UseVisualStyleBackColor = true;
            this.BTNimportar.Click += new System.EventHandler(this.BTNimportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNimportar);
            this.Controls.Add(this.DgDatos);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.BTNmostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNmostrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView DgDatos;
        private System.Windows.Forms.Button BTNimportar;
    }
}

