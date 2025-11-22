namespace FrontPokedex
{
    partial class FrmPokemons
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
            this.dataGridPokemons = new System.Windows.Forms.DataGridView();
            this.picBoxPokemon = new System.Windows.Forms.PictureBox();
            this.btnAltaPokemon = new System.Windows.Forms.Button();
            this.btnModificarPokemon = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.checkEliminados = new System.Windows.Forms.CheckBox();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPokemons
            // 
            this.dataGridPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridPokemons.Location = new System.Drawing.Point(13, 45);
            this.dataGridPokemons.MultiSelect = false;
            this.dataGridPokemons.Name = "dataGridPokemons";
            this.dataGridPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPokemons.Size = new System.Drawing.Size(683, 379);
            this.dataGridPokemons.TabIndex = 0;
            this.dataGridPokemons.SelectionChanged += new System.EventHandler(this.dataGridPokemons_SelectionChanged);
            // 
            // picBoxPokemon
            // 
            this.picBoxPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxPokemon.Location = new System.Drawing.Point(702, 161);
            this.picBoxPokemon.Name = "picBoxPokemon";
            this.picBoxPokemon.Size = new System.Drawing.Size(356, 263);
            this.picBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPokemon.TabIndex = 2;
            this.picBoxPokemon.TabStop = false;
            // 
            // btnAltaPokemon
            // 
            this.btnAltaPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAltaPokemon.BackColor = System.Drawing.Color.Lime;
            this.btnAltaPokemon.Location = new System.Drawing.Point(12, 430);
            this.btnAltaPokemon.Name = "btnAltaPokemon";
            this.btnAltaPokemon.Size = new System.Drawing.Size(349, 38);
            this.btnAltaPokemon.TabIndex = 1;
            this.btnAltaPokemon.Text = "Nuevo Pokemon";
            this.btnAltaPokemon.UseVisualStyleBackColor = false;
            this.btnAltaPokemon.Click += new System.EventHandler(this.btnAltaPokemon_Click);
            // 
            // btnModificarPokemon
            // 
            this.btnModificarPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarPokemon.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificarPokemon.Location = new System.Drawing.Point(13, 474);
            this.btnModificarPokemon.Name = "btnModificarPokemon";
            this.btnModificarPokemon.Size = new System.Drawing.Size(348, 38);
            this.btnModificarPokemon.TabIndex = 2;
            this.btnModificarPokemon.Text = "Modificar Pokemon";
            this.btnModificarPokemon.UseVisualStyleBackColor = false;
            this.btnModificarPokemon.Click += new System.EventHandler(this.btnModificarPokemon_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(702, 430);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(356, 82);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarFisico.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFisico.Location = new System.Drawing.Point(367, 430);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(328, 38);
            this.btnEliminarFisico.TabIndex = 4;
            this.btnEliminarFisico.Text = "Eliminar Pokemon Permanente";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarLogico.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarLogico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLogico.Location = new System.Drawing.Point(367, 474);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(328, 38);
            this.btnEliminarLogico.TabIndex = 5;
            this.btnEliminarLogico.Text = "Eliminar Pokemon (Reversible)";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // checkEliminados
            // 
            this.checkEliminados.AutoSize = true;
            this.checkEliminados.Location = new System.Drawing.Point(581, 18);
            this.checkEliminados.Name = "checkEliminados";
            this.checkEliminados.Size = new System.Drawing.Size(114, 17);
            this.checkEliminados.TabIndex = 6;
            this.checkEliminados.Text = "Mostrar Eliminados";
            this.checkEliminados.UseVisualStyleBackColor = true;
            this.checkEliminados.CheckedChanged += new System.EventHandler(this.checkEliminados_CheckedChanged);
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroRapido.Location = new System.Drawing.Point(12, 12);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(445, 27);
            this.txtFiltroRapido.TabIndex = 7;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(463, 12);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(112, 27);
            this.btnFiltro.TabIndex = 8;
            this.btnFiltro.Text = "Buscar BD";
            this.btnFiltro.UseVisualStyleBackColor = true;
            // 
            // FrmPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 558);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.checkEliminados);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarPokemon);
            this.Controls.Add(this.btnAltaPokemon);
            this.Controls.Add(this.picBoxPokemon);
            this.Controls.Add(this.dataGridPokemons);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(904, 501);
            this.Name = "FrmPokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.FrmPokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPokemons;
        private System.Windows.Forms.PictureBox picBoxPokemon;
        private System.Windows.Forms.Button btnAltaPokemon;
        private System.Windows.Forms.Button btnModificarPokemon;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.CheckBox checkEliminados;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Button btnFiltro;
    }
}

