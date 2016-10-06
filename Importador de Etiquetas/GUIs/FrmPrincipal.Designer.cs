namespace Importador_de_Etiquetas.GUIs
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombreEtiqueta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPRN = new System.Windows.Forms.TextBox();
            this.btnBuscarPRN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.ofdPRN = new System.Windows.Forms.OpenFileDialog();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importador de Plantillas de Etiquetas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(12, 12);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(110, 40);
            this.btnConfiguracion.TabIndex = 1;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la etiqueta:";
            // 
            // txbNombreEtiqueta
            // 
            this.txbNombreEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombreEtiqueta.Location = new System.Drawing.Point(12, 96);
            this.txbNombreEtiqueta.Name = "txbNombreEtiqueta";
            this.txbNombreEtiqueta.Size = new System.Drawing.Size(327, 26);
            this.txbNombreEtiqueta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Archivo PRN:";
            // 
            // txbPRN
            // 
            this.txbPRN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPRN.BackColor = System.Drawing.Color.White;
            this.txbPRN.Enabled = false;
            this.txbPRN.Location = new System.Drawing.Point(12, 146);
            this.txbPRN.Name = "txbPRN";
            this.txbPRN.ReadOnly = true;
            this.txbPRN.Size = new System.Drawing.Size(781, 26);
            this.txbPRN.TabIndex = 5;
            // 
            // btnBuscarPRN
            // 
            this.btnBuscarPRN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPRN.Location = new System.Drawing.Point(799, 145);
            this.btnBuscarPRN.Name = "btnBuscarPRN";
            this.btnBuscarPRN.Size = new System.Drawing.Size(39, 27);
            this.btnBuscarPRN.TabIndex = 6;
            this.btnBuscarPRN.Text = "...";
            this.btnBuscarPRN.UseVisualStyleBackColor = true;
            this.btnBuscarPRN.Click += new System.EventHandler(this.btnBuscarPRN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Imagen Ejemplo:";
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(12, 202);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(781, 291);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 8;
            this.pbImagen.TabStop = false;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarImagen.Location = new System.Drawing.Point(799, 202);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(39, 27);
            this.btnBuscarImagen.TabIndex = 9;
            this.btnBuscarImagen.Text = "...";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // ofdPRN
            // 
            this.ofdPRN.Filter = "Archivos PRN|*.prn";
            // 
            // ofdImagen
            // 
            this.ofdImagen.Filter = "Archivos de Imagenes|*.jpg;*.png";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Location = new System.Drawing.Point(375, 499);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(850, 546);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarPRN);
            this.Controls.Add(this.txbPRN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNombreEtiqueta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Importar Etiquetas";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombreEtiqueta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPRN;
        private System.Windows.Forms.Button btnBuscarPRN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.OpenFileDialog ofdPRN;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.Button btnGuardar;
    }
}