using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
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
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.Listar();
            dataGridPokemons.DataSource = listaPokemons;
            picBoxPokemon.Load(ObtenerUrlSeleccionada());
        }

        private string ObtenerUrlSeleccionada()
        {
            if (dataGridPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dataGridPokemons.CurrentRow.DataBoundItem;
                return seleccionado.UrlImagen;
            }
            return listaPokemons[0].UrlImagen;
        }
    }
}
