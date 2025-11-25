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
            cargarCBCampos();
        }

        private void cargarPokemons()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemons = negocio.Listar(checkEliminados.Checked);
                refrescarListaPokemons(listaPokemons);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void refrescarListaPokemons(List<Pokemon> lista)
        {
            try
            {
                dataGridPokemons.DataSource = null;
                dataGridPokemons.DataSource = lista ?? new List<Pokemon>();
                picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(listaPokemons?[0]));
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
                    picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(seleccionado));
                }
                else
                {
                    picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(listaPokemons?[0]));

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

        private void validarPokemonActivo(Pokemon seleccionado)
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
            }
            else
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
            }
            else
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
                if (dataGridPokemons.DataSource != null)
                {
                    if (dataGridPokemons.CurrentRow != null)
                    {
                        seleccionado = (Pokemon)dataGridPokemons.CurrentRow.DataBoundItem;
                    }
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
            if (!String.IsNullOrEmpty(txtFiltroRapido.Text))
            {
                filtroRapido();
            }
            if (!String.IsNullOrWhiteSpace(txtFiltroAvanzado.Text) && cbCriterios.SelectedIndex >= 0)
            {
                filtroAvanzado();
            } else
            {
                cargarPokemons();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            filtroAvanzado();
        }

        private string validarFiltro(string filtro)
        {
            if (cbCampos.SelectedIndex < 0)
            {
                return "Seleccione un campo para filtrar.";
            }
            if (cbCriterios.SelectedIndex < 0)
            {
                return "Seleccione un criterio para filtrar.";
            }
            if (String.IsNullOrEmpty(filtro))
            {
                return "Ingrese un valor para filtrar";
            }
            int numero = int.MinValue;
            if (cbCampos.SelectedIndex == 0) //Número
            {
                if (!int.TryParse(filtro, out numero))
                {
                    return "El valor ingresado debe ser numérico.";
                }
                if (numero == int.MinValue)
                {
                    return "Ingrese un número para filtrar.";
                }
            }
            return "";
        }
        private void filtroAvanzado()
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            string filtro = txtFiltroAvanzado.Text;
            string error = validarFiltro(filtro);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            try
            {
                string campo = cbCampos.SelectedItem.ToString();
                string criterio = cbCriterios.SelectedItem.ToString();
                listaPokemons = pokemonNegocio.Filtrar(campo, criterio, filtro, checkEliminados.Checked);
                refrescarListaPokemons(listaPokemons);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void filtroRapido()
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtFiltroRapido.Text;
            try
            {
                if (!String.IsNullOrEmpty(filtro))
                {
                    listaFiltrada = listaPokemons.FindAll(p => p.Nombre.ToUpper().Contains(filtro.ToUpper()) || p.Descripcion.ToUpper().Contains(filtro.ToUpper())
                                                            && (p.Activo == checkEliminados.Checked || p.Activo));
                }
                else
                {
                    listaFiltrada = listaPokemons;
                }
                refrescarListaPokemons(listaFiltrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroRapido.Text.Length > 2 || txtFiltroRapido.Text.Length == 0)
                filtroRapido();
        }

        private void cargarCBCampos()
        {
            cbCampos.Items.Add("Numero");
            cbCampos.Items.Add("Nombre");
            cbCampos.Items.Add("Descripcion");
            cbCampos.Items.Add("Tipo");
            cbCampos.Items.Add("Debilidad");
            cbCampos.SelectedIndex = -1;
        }

        private void cargarCBCriterios(int indexCampos = -1)
        {
            try
            {
                cbCriterios.Enabled = indexCampos >= 0;
                switch (indexCampos)
                {
                    case -1:
                        cbCriterios.Items.Clear();
                        break;
                    case 0: //Número
                        cbCriterios.Items.Clear();
                        cbCriterios.Items.Add("Mayor a");
                        cbCriterios.Items.Add("Menor a");
                        cbCriterios.Items.Add("Igual a");
                        break;
                    default:
                        cbCriterios.Items.Clear();
                        cbCriterios.Items.Add("Contiene");
                        cbCriterios.Items.Add("Comienza con");
                        cbCriterios.Items.Add("Termina con");
                        break;
                }
                if (indexCampos >= 0)
                {
                    cbCriterios.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbCampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbCampos.Items.Count > 0 ? cbCampos.SelectedIndex : -1;
            cargarCBCriterios(indice);
        }

        private void cbCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bool filtro = false;
                if (cbCriterios.Items.Count > 0)
                {
                    filtro = cbCriterios.SelectedIndex >= 0;
                }
                btnFiltro.Enabled = filtro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
