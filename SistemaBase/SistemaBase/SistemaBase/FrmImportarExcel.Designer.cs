namespace SistemaBase
{
    partial class FrmImportarExcel
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
            this.radioVendedoras = new System.Windows.Forms.RadioButton();
            this.RadioJoyas = new System.Windows.Forms.RadioButton();
            this.txt_Ruta = new System.Windows.Forms.TextBox();
            this.btnAbrirImagen = new System.Windows.Forms.Button();
            this.txtProceso = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioVendedoras
            // 
            this.radioVendedoras.AutoSize = true;
            this.radioVendedoras.Location = new System.Drawing.Point(111, 34);
            this.radioVendedoras.Name = "radioVendedoras";
            this.radioVendedoras.Size = new System.Drawing.Size(82, 17);
            this.radioVendedoras.TabIndex = 24;
            this.radioVendedoras.Text = "Vendedoras";
            this.radioVendedoras.UseVisualStyleBackColor = true;
            // 
            // RadioJoyas
            // 
            this.RadioJoyas.AutoSize = true;
            this.RadioJoyas.Checked = true;
            this.RadioJoyas.Location = new System.Drawing.Point(32, 34);
            this.RadioJoyas.Name = "RadioJoyas";
            this.RadioJoyas.Size = new System.Drawing.Size(52, 17);
            this.RadioJoyas.TabIndex = 23;
            this.RadioJoyas.TabStop = true;
            this.RadioJoyas.Text = "Joyas";
            this.RadioJoyas.UseVisualStyleBackColor = true;
            // 
            // txt_Ruta
            // 
            this.txt_Ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ruta.Location = new System.Drawing.Point(32, 107);
            this.txt_Ruta.Name = "txt_Ruta";
            this.txt_Ruta.Size = new System.Drawing.Size(230, 26);
            this.txt_Ruta.TabIndex = 22;
            // 
            // btnAbrirImagen
            // 
            this.btnAbrirImagen.Location = new System.Drawing.Point(32, 139);
            this.btnAbrirImagen.Name = "btnAbrirImagen";
            this.btnAbrirImagen.Size = new System.Drawing.Size(102, 34);
            this.btnAbrirImagen.TabIndex = 21;
            this.btnAbrirImagen.Text = "Seleccionar";
            this.btnAbrirImagen.UseVisualStyleBackColor = true;
            // 
            // txtProceso
            // 
            this.txtProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProceso.Location = new System.Drawing.Point(162, 75);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(100, 26);
            this.txtProceso.TabIndex = 20;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(32, 73);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(109, 28);
            this.btnAbrir.TabIndex = 19;
            this.btnAbrir.Text = "Procesar ";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // FrmImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 416);
            this.Controls.Add(this.radioVendedoras);
            this.Controls.Add(this.RadioJoyas);
            this.Controls.Add(this.txt_Ruta);
            this.Controls.Add(this.btnAbrirImagen);
            this.Controls.Add(this.txtProceso);
            this.Controls.Add(this.btnAbrir);
            this.Name = "FrmImportarExcel";
            this.Text = "FrmImportarExcel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioVendedoras;
        private System.Windows.Forms.RadioButton RadioJoyas;
        private System.Windows.Forms.TextBox txt_Ruta;
        private System.Windows.Forms.Button btnAbrirImagen;
        private System.Windows.Forms.TextBox txtProceso;
        private System.Windows.Forms.Button btnAbrir;
    }
}