using DominioPokedex;
using NegocioPokedex;
using System;
using System.IO;
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
                copiarImagen(txtImagen.Text);
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
            picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(null));
        }

        private void copiarImagen(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return;
            if (!Path.IsPathRooted(url))
                return;
            string nombre = string.Empty;
            try
            {
                nombre = txtNumero.Text + "_" + txtNombre.Text + System.IO.Path.GetExtension(url);
                nombre = HelperImagenes.CopiarImagenSeleccionada(url, nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo copiar la imagen: " + ex.Message);
            }
            txtImagen.Text = nombre;
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
            Pokemon poke = new Pokemon();
            poke.UrlImagen = txtImagen.Text;
            try
            {
                picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(poke));
            }
            catch (Exception ex)
            {
                picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(null));
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = "";
                ruta = HelperImagenes.SeleccionarImagen();
                txtImagen.Text = ruta;
                picBoxPokemon.Load(HelperImagenes.ObtenerUrlSeleccionada(new Pokemon { UrlImagen = ruta }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnElemento_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Desea agregar un nuevo elemento o modificar uno existente?", "Elementos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.No)
                return;
            FrmElementos formulario = new FrmElementos();
            formulario.ShowDialog();
            cargarElementos();
        }
    }
}
