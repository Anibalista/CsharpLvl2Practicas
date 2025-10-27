namespace Practica02
{
    partial class FrmDiscos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloDiscos = new System.Windows.Forms.Label();
            this.dataGridDiscos = new System.Windows.Forms.DataGridView();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.lblTituloPortadas = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFiltroTitulo = new System.Windows.Forms.Label();
            this.txtFiltroTitulo = new System.Windows.Forms.TextBox();
            this.lblFiltroFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstilo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEdicion = new System.Windows.Forms.ComboBox();
            this.btnAltaDisco = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaDisco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbEdicion);
            this.groupBox1.Controls.Add(this.lblFiltroEstilo);
            this.groupBox1.Controls.Add(this.cbEstilo);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblFiltroFecha);
            this.groupBox1.Controls.Add(this.txtFiltroTitulo);
            this.groupBox1.Controls.Add(this.lblFiltroTitulo);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(311, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menú principal";
            // 
            // lblTituloDiscos
            // 
            this.lblTituloDiscos.AutoSize = true;
            this.lblTituloDiscos.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDiscos.Location = new System.Drawing.Point(170, 141);
            this.lblTituloDiscos.Name = "lblTituloDiscos";
            this.lblTituloDiscos.Size = new System.Drawing.Size(77, 25);
            this.lblTituloDiscos.TabIndex = 1;
            this.lblTituloDiscos.Text = "DISCOS";
            // 
            // dataGridDiscos
            // 
            this.dataGridDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiscos.Location = new System.Drawing.Point(0, 169);
            this.dataGridDiscos.Name = "dataGridDiscos";
            this.dataGridDiscos.Size = new System.Drawing.Size(497, 278);
            this.dataGridDiscos.TabIndex = 2;
            // 
            // pbPortada
            // 
            this.pbPortada.Location = new System.Drawing.Point(503, 169);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(235, 183);
            this.pbPortada.TabIndex = 3;
            this.pbPortada.TabStop = false;
            // 
            // lblTituloPortadas
            // 
            this.lblTituloPortadas.AutoSize = true;
            this.lblTituloPortadas.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPortadas.Location = new System.Drawing.Point(589, 146);
            this.lblTituloPortadas.Name = "lblTituloPortadas";
            this.lblTituloPortadas.Size = new System.Drawing.Size(60, 19);
            this.lblTituloPortadas.TabIndex = 4;
            this.lblTituloPortadas.Text = "Portada";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(540, 379);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(163, 46);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblFiltroTitulo
            // 
            this.lblFiltroTitulo.AutoSize = true;
            this.lblFiltroTitulo.Location = new System.Drawing.Point(6, 50);
            this.lblFiltroTitulo.Name = "lblFiltroTitulo";
            this.lblFiltroTitulo.Size = new System.Drawing.Size(43, 15);
            this.lblFiltroTitulo.TabIndex = 1;
            this.lblFiltroTitulo.Text = "Título: ";
            // 
            // txtFiltroTitulo
            // 
            this.txtFiltroTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroTitulo.Location = new System.Drawing.Point(55, 47);
            this.txtFiltroTitulo.Name = "txtFiltroTitulo";
            this.txtFiltroTitulo.Size = new System.Drawing.Size(256, 23);
            this.txtFiltroTitulo.TabIndex = 2;
            // 
            // lblFiltroFecha
            // 
            this.lblFiltroFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroFecha.AutoSize = true;
            this.lblFiltroFecha.Location = new System.Drawing.Point(385, 50);
            this.lblFiltroFecha.Name = "lblFiltroFecha";
            this.lblFiltroFecha.Size = new System.Drawing.Size(112, 15);
            this.lblFiltroFecha.TabIndex = 3;
            this.lblFiltroFecha.Text = "Fecha Lanzamiento: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(503, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cbEstilo
            // 
            this.cbEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Location = new System.Drawing.Point(55, 94);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(174, 23);
            this.cbEstilo.TabIndex = 5;
            // 
            // lblFiltroEstilo
            // 
            this.lblFiltroEstilo.AutoSize = true;
            this.lblFiltroEstilo.Location = new System.Drawing.Point(7, 97);
            this.lblFiltroEstilo.Name = "lblFiltroEstilo";
            this.lblFiltroEstilo.Size = new System.Drawing.Size(42, 15);
            this.lblFiltroEstilo.TabIndex = 6;
            this.lblFiltroEstilo.Text = "Estilo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edición: ";
            // 
            // cbEdicion
            // 
            this.cbEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdicion.FormattingEnabled = true;
            this.cbEdicion.Location = new System.Drawing.Point(317, 94);
            this.cbEdicion.Name = "cbEdicion";
            this.cbEdicion.Size = new System.Drawing.Size(174, 23);
            this.cbEdicion.TabIndex = 7;
            // 
            // btnAltaDisco
            // 
            this.btnAltaDisco.Location = new System.Drawing.Point(583, 83);
            this.btnAltaDisco.Name = "btnAltaDisco";
            this.btnAltaDisco.Size = new System.Drawing.Size(148, 34);
            this.btnAltaDisco.TabIndex = 9;
            this.btnAltaDisco.Text = "Registrar Disco";
            this.btnAltaDisco.UseVisualStyleBackColor = true;
            // 
            // FrmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 452);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTituloPortadas);
            this.Controls.Add(this.pbPortada);
            this.Controls.Add(this.dataGridDiscos);
            this.Controls.Add(this.lblTituloDiscos);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(759, 491);
            this.Name = "FrmDiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abm Discos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloDiscos;
        private System.Windows.Forms.DataGridView dataGridDiscos;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lblTituloPortadas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFiltroTitulo;
        private System.Windows.Forms.Label lblFiltroFecha;
        private System.Windows.Forms.TextBox txtFiltroTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbEstilo;
        private System.Windows.Forms.Label lblFiltroEstilo;
        private System.Windows.Forms.Button btnAltaDisco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEdicion;
    }
}

