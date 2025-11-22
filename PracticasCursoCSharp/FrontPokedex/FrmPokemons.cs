using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DominioPokedex;
using NegocioPokedex;

namespace FrontPokedex
{
    public partial class FrmPokemons : Form
    {
        private List<Pokemon> listaPokemons;
        public FrmPokemons()
        {
            InitializeComponent();
        }

        private void FrmPokemons_Load(object sender, EventArgs e)
        {
            cargarPokemons();
        }

        private void cargarPokemons()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemons = negocio.Listar(checkEliminados.Checked);
                dataGridPokemons.DataSource = listaPokemons;
                picBoxPokemon.Load(listaPokemons[0].UrlImagen);
                quitarColumna("Id");
                quitarColumna("Activo");
                pintarInactivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void quitarColumna(string nombreColumna)
        {
            dataGridPokemons.Columns[nombreColumna].Visible = false;
        }

        private void dataGridPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = obtenerPokemonSeleccionado();
            try
            {
                if (seleccionado != null)
                {
                    picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(seleccionado.UrlImagen));
                }
                else
                {
                    picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(listaPokemons[0].UrlImagen));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //picBoxPokemon.Image = null;
            }
        }
        private void pintarInactivos()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridPokemons.Rows)
                {
                    Pokemon poke = (Pokemon)row.DataBoundItem;
                    if (!poke.Activo)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAltaPokemon_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditPokemon alta = new FrmEditPokemon();
                alta.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            cargarPokemons();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificarPokemon_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = obtenerPokemonSeleccionado();

            try
            {
                if (seleccionado != null)
                {
                    FrmEditPokemon modificar = new FrmEditPokemon();
                    modificar.inicioModificar(seleccionado);
                    modificar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione un Pokémon para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cargarPokemons();
        }

        private void validarPokemonActivo (Pokemon seleccionado)
        {
            if (seleccionado != null)
            {
                if (seleccionado.Activo)
                {
                    cambiarBotonEliminar(true);
                }
                else
                {
                    cambiarBotonEliminar(false);
                }
            } else
            {
                cambiarBotonEliminar(true);
            }
        }

        private void cambiarBotonEliminar(bool eliminar)
        {
           if (eliminar)
            {
                btnEliminarLogico.Text = "Eliminar Pokemon (Reversible)";
                btnEliminarLogico.BackColor = Color.Orange;
            } else
            {
                btnEliminarLogico.Text = "Reactivar Pokemon";
                btnEliminarLogico.BackColor = Color.LightGreen;
            }
        }

        private Pokemon obtenerPokemonSeleccionado()
        {
            Pokemon seleccionado = null;
            try
            {
                if (dataGridPokemons.CurrentRow != null)
                {
                    seleccionado = (Pokemon)dataGridPokemons.CurrentRow.DataBoundItem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            validarPokemonActivo(seleccionado);
            return seleccionado;
        }

        private bool confirmarEliminacion()
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el Pokémon seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return respuesta == DialogResult.Yes;
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = obtenerPokemonSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un Pokémon para eliminar.");
                return;
            }
            try
            {
                if (confirmarEliminacion())
                {
                    DialogResult respuesta = MessageBox.Show("Esta acción eliminará permanentemente el Pokémon. ¿Desea continuar?", "Confirmar eliminación permanente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.No)
                        return;
                    PokemonNegocio negocio = new PokemonNegocio();
                    negocio.EliminarFisico(seleccionado);
                    cargarPokemons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = obtenerPokemonSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un Pokémon para eliminar.");
                return;
            }
            try
            {
                if (btnEliminarLogico.Text == "Reactivar Pokemon")
                {
                    PokemonNegocio negocio = new PokemonNegocio();
                    negocio.Activar(seleccionado);
                }
                else
                {
                    if (confirmarEliminacion())
                    {
                        PokemonNegocio negocio = new PokemonNegocio();
                        negocio.EliminarLogico(seleccionado);
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cargarPokemons();
        }

        private void checkEliminados_CheckedChanged(object sender, EventArgs e)
        {
            cargarPokemons();
        }
    }
}
