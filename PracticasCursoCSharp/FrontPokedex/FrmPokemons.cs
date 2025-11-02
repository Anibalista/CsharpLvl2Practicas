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
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemons = negocio.Listar();
            dataGridPokemons.DataSource = listaPokemons;
            picBoxPokemon.Load(listaPokemons[0].UrlImagen);
            quitarColumna("UrlImagen");
        }

        private void quitarColumna(string nombreColumna)
        {
            dataGridPokemons.Columns[nombreColumna].Visible = false;
        }

        private string ObtenerUrlSeleccionada(Pokemon pokemon)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(pokemon.UrlImagen))
                    return "imagenes/quien_es_este_pokemon.png";

                string ruta = pokemon.UrlImagen;
                if (ruta.StartsWith("http"))
                    return ruta;

                // Validar si el archivo existe
                string rutaCompleta = Path.Combine(Application.StartupPath, ruta);
                if (!File.Exists(rutaCompleta))
                    return "imagenes/quien_es_este_pokemon.png";

                return ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridPokemons_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPokemons.CurrentRow != null)
                {
                    Pokemon seleccionado = (Pokemon)dataGridPokemons.CurrentRow.DataBoundItem;
                    picBoxPokemon.Load(ObtenerUrlSeleccionada(seleccionado));
                }
                else
                {
                    picBoxPokemon.Load(ObtenerUrlSeleccionada(listaPokemons[0]));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //picBoxPokemon.Image = null;
            }
        }
    }
}
