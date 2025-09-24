namespace Modulo01
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.groupBoxTelefonos = new System.Windows.Forms.GroupBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lvlMarca = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.numOperador = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumLlamada = new System.Windows.Forms.TextBox();
            this.lblNumLlamada = new System.Windows.Forms.Label();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.dataGridTelefonos = new System.Windows.Forms.DataGridView();
            this.groupBoxTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTelefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(17, 33);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo: ";
            // 
            // groupBoxTelefonos
            // 
            this.groupBoxTelefonos.Controls.Add(this.btnAgregar);
            this.groupBoxTelefonos.Controls.Add(this.numOperador);
            this.groupBoxTelefonos.Controls.Add(this.lblOperador);
            this.groupBoxTelefonos.Controls.Add(this.txtNumero);
            this.groupBoxTelefonos.Controls.Add(this.lblNumero);
            this.groupBoxTelefonos.Controls.Add(this.txtMarca);
            this.groupBoxTelefonos.Controls.Add(this.lvlMarca);
            this.groupBoxTelefonos.Controls.Add(this.txtModelo);
            this.groupBoxTelefonos.Controls.Add(this.lblModelo);
            this.groupBoxTelefonos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTelefonos.MinimumSize = new System.Drawing.Size(282, 228);
            this.groupBoxTelefonos.Name = "groupBoxTelefonos";
            this.groupBoxTelefonos.Size = new System.Drawing.Size(282, 228);
            this.groupBoxTelefonos.TabIndex = 1;
            this.groupBoxTelefonos.TabStop = false;
            this.groupBoxTelefonos.Text = "Agregar Telefono";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.Location = new System.Drawing.Point(66, 30);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(210, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Location = new System.Drawing.Point(66, 64);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(210, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lvlMarca
            // 
            this.lvlMarca.AutoSize = true;
            this.lvlMarca.Location = new System.Drawing.Point(17, 67);
            this.lvlMarca.Name = "lvlMarca";
            this.lvlMarca.Size = new System.Drawing.Size(43, 13);
            this.lvlMarca.TabIndex = 2;
            this.lvlMarca.Text = "Marca: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Location = new System.Drawing.Point(66, 93);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(210, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(10, 96);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numero: ";
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(12, 127);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(93, 13);
            this.lblOperador.TabIndex = 6;
            this.lblOperador.Text = "Codigo Operador: ";
            // 
            // numOperador
            // 
            this.numOperador.Location = new System.Drawing.Point(111, 127);
            this.numOperador.Name = "numOperador";
            this.numOperador.Size = new System.Drawing.Size(69, 20);
            this.numOperador.TabIndex = 7;
            this.numOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(24, 173);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(235, 45);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Telefono";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLlamar);
            this.groupBox1.Controls.Add(this.txtNumLlamada);
            this.groupBox1.Controls.Add(this.lblNumLlamada);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.MinimumSize = new System.Drawing.Size(282, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llamadas";
            // 
            // txtNumLlamada
            // 
            this.txtNumLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumLlamada.Location = new System.Drawing.Point(66, 28);
            this.txtNumLlamada.MaxLength = 20;
            this.txtNumLlamada.Name = "txtNumLlamada";
            this.txtNumLlamada.Size = new System.Drawing.Size(210, 20);
            this.txtNumLlamada.TabIndex = 3;
            // 
            // lblNumLlamada
            // 
            this.lblNumLlamada.AutoSize = true;
            this.lblNumLlamada.Location = new System.Drawing.Point(10, 31);
            this.lblNumLlamada.Name = "lblNumLlamada";
            this.lblNumLlamada.Size = new System.Drawing.Size(50, 13);
            this.lblNumLlamada.TabIndex = 2;
            this.lblNumLlamada.Text = "Numero: ";
            // 
            // btnLlamar
            // 
            this.btnLlamar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLlamar.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamar.Location = new System.Drawing.Point(24, 75);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(235, 45);
            this.btnLlamar.TabIndex = 9;
            this.btnLlamar.Text = "Agregar Telefono";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // dataGridTelefonos
            // 
            this.dataGridTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTelefonos.Location = new System.Drawing.Point(300, 12);
            this.dataGridTelefonos.Name = "dataGridTelefonos";
            this.dataGridTelefonos.Size = new System.Drawing.Size(548, 361);
            this.dataGridTelefonos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 385);
            this.Controls.Add(this.dataGridTelefonos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTelefonos);
            this.MinimumSize = new System.Drawing.Size(816, 424);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTelefonos.ResumeLayout(false);
            this.groupBoxTelefonos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTelefonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox groupBoxTelefonos;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lvlMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown numOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumLlamada;
        private System.Windows.Forms.Label lblNumLlamada;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.DataGridView dataGridTelefonos;
    }
}

