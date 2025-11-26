namespace FrontPokedex
{
    partial class FrmElementos
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
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.listaElementos = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.lblTituloSeleccionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento.Location = new System.Drawing.Point(186, 5);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(210, 27);
            this.txtElemento.TabIndex = 1;
            // 
            // listaElementos
            // 
            this.listaElementos.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaElementos.FormattingEnabled = true;
            this.listaElementos.Location = new System.Drawing.Point(0, 0);
            this.listaElementos.Name = "listaElementos";
            this.listaElementos.Size = new System.Drawing.Size(180, 248);
            this.listaElementos.TabIndex = 2;
            this.listaElementos.SelectedIndexChanged += new System.EventHandler(this.listaElementos_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(184, 38);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 31);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Nuevo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(293, 38);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 31);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(186, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(210, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(186, 105);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(210, 27);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(227, 83);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(118, 19);
            this.lblBusqueda.TabIndex = 7;
            this.lblBusqueda.Text = "Buscar Elemento";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionado.Location = new System.Drawing.Point(258, 165);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 19);
            this.lblSeleccionado.TabIndex = 8;
            // 
            // lblTituloSeleccionado
            // 
            this.lblTituloSeleccionado.AutoSize = true;
            this.lblTituloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTituloSeleccionado.Location = new System.Drawing.Point(223, 146);
            this.lblTituloSeleccionado.Name = "lblTituloSeleccionado";
            this.lblTituloSeleccionado.Size = new System.Drawing.Size(140, 13);
            this.lblTituloSeleccionado.TabIndex = 9;
            this.lblTituloSeleccionado.Text = "Elemento Seleccionado";
            // 
            // FrmElementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 248);
            this.Controls.Add(this.lblTituloSeleccionado);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.listaElementos);
            this.Controls.Add(this.txtElemento);
            this.Name = "FrmElementos";
            this.Text = "FrmElementos";
            this.Load += new System.EventHandler(this.FrmElementos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.ListBox listaElementos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label lblTituloSeleccionado;
    }
}