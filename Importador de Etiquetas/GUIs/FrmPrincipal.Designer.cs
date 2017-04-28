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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnModifBuscarComando = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbModifComando = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnModifBuscarImagen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbModifEtiqueta = new System.Windows.Forms.PictureBox();
            this.cmbEtiquetas = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModifEtiqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 52);
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
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la etiqueta:";
            // 
            // txbNombreEtiqueta
            // 
            this.txbNombreEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombreEtiqueta.Location = new System.Drawing.Point(6, 47);
            this.txbNombreEtiqueta.Name = "txbNombreEtiqueta";
            this.txbNombreEtiqueta.Size = new System.Drawing.Size(315, 26);
            this.txbNombreEtiqueta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
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
            this.txbPRN.Location = new System.Drawing.Point(6, 97);
            this.txbPRN.Name = "txbPRN";
            this.txbPRN.ReadOnly = true;
            this.txbPRN.Size = new System.Drawing.Size(889, 26);
            this.txbPRN.TabIndex = 5;
            // 
            // btnBuscarPRN
            // 
            this.btnBuscarPRN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPRN.Location = new System.Drawing.Point(901, 96);
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
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Imagen Ejemplo:";
            // 
            // pbImagen
            // 
            this.pbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(6, 147);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(889, 275);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 8;
            this.pbImagen.TabStop = false;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarImagen.Location = new System.Drawing.Point(901, 147);
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
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(423, 428);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 519);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarPRN);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txbNombreEtiqueta);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txbPRN);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.btnBuscarImagen);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pbImagen);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nueva Etiqueta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCargar);
            this.tabPage2.Controls.Add(this.cmbEtiquetas);
            this.tabPage2.Controls.Add(this.btnModifBuscarComando);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txbModifComando);
            this.tabPage2.Controls.Add(this.btnModificar);
            this.tabPage2.Controls.Add(this.btnModifBuscarImagen);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.pbModifEtiqueta);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Etiqueta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnModifBuscarComando
            // 
            this.btnModifBuscarComando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifBuscarComando.Location = new System.Drawing.Point(901, 96);
            this.btnModifBuscarComando.Name = "btnModifBuscarComando";
            this.btnModifBuscarComando.Size = new System.Drawing.Size(39, 27);
            this.btnModifBuscarComando.TabIndex = 15;
            this.btnModifBuscarComando.Text = "...";
            this.btnModifBuscarComando.UseVisualStyleBackColor = true;
            this.btnModifBuscarComando.Click += new System.EventHandler(this.btnModifBuscarComando_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre de la etiqueta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Archivo PRN:";
            // 
            // txbModifComando
            // 
            this.txbModifComando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbModifComando.BackColor = System.Drawing.Color.White;
            this.txbModifComando.Enabled = false;
            this.txbModifComando.Location = new System.Drawing.Point(9, 97);
            this.txbModifComando.Name = "txbModifComando";
            this.txbModifComando.ReadOnly = true;
            this.txbModifComando.Size = new System.Drawing.Size(886, 26);
            this.txbModifComando.TabIndex = 14;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(423, 428);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 35);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Guardar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnModifBuscarImagen
            // 
            this.btnModifBuscarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifBuscarImagen.Location = new System.Drawing.Point(901, 147);
            this.btnModifBuscarImagen.Name = "btnModifBuscarImagen";
            this.btnModifBuscarImagen.Size = new System.Drawing.Size(39, 27);
            this.btnModifBuscarImagen.TabIndex = 18;
            this.btnModifBuscarImagen.Text = "...";
            this.btnModifBuscarImagen.UseVisualStyleBackColor = true;
            this.btnModifBuscarImagen.Click += new System.EventHandler(this.btnModifBuscarImagen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Imagen Ejemplo:";
            // 
            // pbModifEtiqueta
            // 
            this.pbModifEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbModifEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbModifEtiqueta.Location = new System.Drawing.Point(9, 147);
            this.pbModifEtiqueta.Name = "pbModifEtiqueta";
            this.pbModifEtiqueta.Size = new System.Drawing.Size(886, 275);
            this.pbModifEtiqueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbModifEtiqueta.TabIndex = 17;
            this.pbModifEtiqueta.TabStop = false;
            // 
            // cmbEtiquetas
            // 
            this.cmbEtiquetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtiquetas.FormattingEnabled = true;
            this.cmbEtiquetas.Location = new System.Drawing.Point(9, 47);
            this.cmbEtiquetas.Name = "cmbEtiquetas";
            this.cmbEtiquetas.Size = new System.Drawing.Size(512, 26);
            this.cmbEtiquetas.TabIndex = 20;
            this.cmbEtiquetas.SelectedIndexChanged += new System.EventHandler(this.cmbEtiquetas_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(527, 45);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 30);
            this.btnCargar.TabIndex = 21;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(978, 589);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Importar Etiquetas";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModifEtiqueta)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbEtiquetas;
        private System.Windows.Forms.Button btnModifBuscarComando;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbModifComando;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnModifBuscarImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbModifEtiqueta;
    }
}