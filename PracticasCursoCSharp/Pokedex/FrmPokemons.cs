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
            picBoxPokemon.Load(listaPokemons[0].UrlImagen);
        }

        private string ObtenerUrlSeleccionada(Pokemon pokemon)
        {
            if (String.IsNullOrWhiteSpace(pokemon.UrlImagen))
                return "imagenes/quien_es_este_pokemon.png";
            return pokemon.UrlImagen;
        }

        private void dataGridPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dataGridPokemons.CurrentRow.DataBoundItem;
                picBoxPokemon.Load(ObtenerUrlSeleccionada(seleccionado));
            } else
            {
                picBoxPokemon.Load(ObtenerUrlSeleccionada(listaPokemons[0]));
            }
        }
    }
}
