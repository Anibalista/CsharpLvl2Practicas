namespace Pokedex
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPokemons
            // 
            this.dataGridPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridPokemons.Location = new System.Drawing.Point(12, 12);
            this.dataGridPokemons.Name = "dataGridPokemons";
            this.dataGridPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPokemons.Size = new System.Drawing.Size(508, 426);
            this.dataGridPokemons.TabIndex = 0;
            // 
            // picBoxPokemon
            // 
            this.picBoxPokemon.Location = new System.Drawing.Point(526, 12);
            this.picBoxPokemon.Name = "picBoxPokemon";
            this.picBoxPokemon.Size = new System.Drawing.Size(262, 212);
            this.picBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPokemon.TabIndex = 1;
            this.picBoxPokemon.TabStop = false;
            // 
            // FrmPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxPokemon);
            this.Controls.Add(this.dataGridPokemons);
            this.Name = "FrmPokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Pokemons";
            this.Load += new System.EventHandler(this.FrmPokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPokemons;
        private System.Windows.Forms.PictureBox picBoxPokemon;
    }
}

