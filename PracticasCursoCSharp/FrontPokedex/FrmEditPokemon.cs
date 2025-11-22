using DominioPokedex;
using NegocioPokedex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontPokedex
{
    public partial class FrmEditPokemon : Form
    {
        private Pokemon Pokemon = null;
        public FrmEditPokemon()
        {
            InitializeComponent();
        }

        private void FrmEditPokemon_Load(object sender, EventArgs e)
        {
            cargarElementos();
            if (Pokemon != null)
            {
                txtNumero.Text = Pokemon.Numero.ToString();
                txtNombre.Text = Pokemon.Nombre;
                txtDescripcion.Text = Pokemon.Descripcion;
                txtImagen.Text = Pokemon.UrlImagen ?? "";
                cbTipo.SelectedValue = Pokemon.Tipo.Id;
                cbDebilidad.SelectedValue = Pokemon.Debilidad.Id;
            }
        }

        private void cargarElementos()
        {
            ElementoNegocio negocio = new ElementoNegocio();
            try
            {
                cbTipo.DataSource = negocio.listar();
                cbTipo.SelectedIndex = -1;
                cbDebilidad.DataSource = negocio.listar();
                cbDebilidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void inicioModificar(Pokemon Poke)
        {
            Pokemon = Poke;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validarObligatorios(ref string mensaje)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
                mensaje += "- El campo 'Número' es obligatorio.\n";
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                mensaje += "- El campo 'Nombre' es obligatorio.\n";
            if (cbTipo.SelectedIndex == -1)
                mensaje += "- Debe seleccionar un 'Tipo'.\n";
            if (cbDebilidad.SelectedIndex == -1)
                mensaje += "- Debe seleccionar una 'Debilidad'.\n";
            return String.IsNullOrWhiteSpace(mensaje);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (!validarObligatorios(ref mensaje))
            {
                MessageBox.Show("Por favor, complete los siguientes campos obligatorios:\n" + mensaje, "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Pokemon == null)
                Pokemon = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                Pokemon.Numero = int.Parse(txtNumero.Text);
                Pokemon.Nombre = txtNombre.Text;
                Pokemon.Descripcion = txtDescripcion.Text;
                Pokemon.UrlImagen = String.IsNullOrWhiteSpace(txtImagen.Text) ? "" : txtImagen.Text;
                Pokemon.Tipo = (Elemento)cbTipo.SelectedItem;
                Pokemon.Debilidad = (Elemento)cbDebilidad.SelectedItem;

                if (Pokemon.Id == 0)
                {
                    negocio.Agregar(Pokemon);
                    mensajeFinalizar("Pokemon agregado exitosamente", true);
                }
                else
                {
                    negocio.Modificar(Pokemon);
                    mensajeFinalizar("Pokémon modificado exitosamente.", false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpiarCampos()
        {
            Pokemon = null;
            txtNumero.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtImagen.Clear();
            cbTipo.SelectedIndex = -1;
            cbDebilidad.SelectedIndex = -1;
            picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(""));
        }

        private void mensajeFinalizar(string mensaje, bool alta)
        {
            DialogResult pregunta = MessageBox.Show(mensaje + (alta ? "\n¿Desea agregar otro Pokemon?" : ""), "Operación exitosa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (pregunta == DialogResult.Yes && alta)
            {
                limpiarCampos();
            }
            else
            {
                this.Close();
            }

        }

        private void cerrar()
        {
            string mensaje = string.Empty;
            if (Pokemon != null)
            {
                mensaje = Pokemon.Id > 0 ? "Los cambios realizados se perderán" : "";
            }
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea salir? {mensaje}.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
                this.Close();
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(txtImagen.Text));
            }
            catch (Exception ex)
            {
                picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(""));
                MessageBox.Show(ex.Message);
            }
        }
    }
}
