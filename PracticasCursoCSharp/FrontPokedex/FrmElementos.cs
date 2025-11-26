using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DominioPokedex;
using NegocioPokedex;

namespace FrontPokedex
{
    public partial class FrmElementos : Form
    {
        private List<Elemento> listaDeElementos;
        private bool cerrarFormulario = false;
        private bool cargando = true;
        Elemento elemento;
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        public FrmElementos()
        {
            InitializeComponent();
        }

        private void FrmElementos_Load(object sender, EventArgs e)
        {
            cargarElementos();
        }

        //métodos
        private void cerrar()
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar el formulario?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                cerrarFormulario = false;
                return;
            }
            cerrarFormulario = true;
            this.Close();
        }

        private void cargarElementos()
        {
            ElementoNegocio negocio = new ElementoNegocio();
            cargando = true;
            try
            {
                listaDeElementos = negocio.listar();
                listaElementos.DataSource = listaDeElementos;
                listaElementos.ValueMember = "Id";
                listaElementos.DisplayMember = "Descripcion";
                listaElementos.SelectedIndex = -1;
                cargando = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validarElemento()
        {
            if (string.IsNullOrWhiteSpace(txtElemento.Text))
            {
                MessageBox.Show("Debe ingresar una descripción para el elemento.");
                return false;
            }
            return true;
        }

        private void limpiarFormulario()
        {
            txtElemento.Clear();
            lblSeleccionado.Text = "";
            elemento = null;
            txtFiltro.Clear();
            cargarElementos();
            txtElemento.Focus();
        }

        private bool validarSeleccion()
        {
            try
            {
                if (listaElementos.SelectedIndex < 0)
                {
                    return false;
                }
                elemento = (Elemento)listaElementos.SelectedItem;
                return true;
            }
            catch
            {
                throw;
            }

        }

        private void filtrarElementos()
        {
            List<Elemento> listaFiltrada;
            cargando = true;
            string filtro = txtFiltro.Text.ToLower();
            try
            {
                listaFiltrada = listaDeElementos.FindAll(e => e.Descripcion.ToLower().Contains(filtro));
                listaElementos.DataSource = null;
                listaElementos.DataSource = listaFiltrada;
                listaElementos.ValueMember = "Id";
                listaElementos.DisplayMember = "Descripcion";
                cargando = false;
            }
            catch
            {
                throw;
            }
        }

        private bool elementoExistente(string descripcion)
        {
            if (listaDeElementos == null)
                return false;
            return listaDeElementos.Any(e => e.Descripcion.Equals(descripcion, StringComparison.OrdinalIgnoreCase));
        }

        //eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;
            if (String.IsNullOrWhiteSpace(filtro))
                cargarElementos();
            if (filtro.Length < 3)
                return;
            try
            {
                filtrarElementos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listaElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cerrarFormulario)
                return;
            if (cargando)
                return;
            try
            {
                if (!validarSeleccion())
                {
                    lblSeleccionado.Text = "";
                    elemento = null;
                    return;
                }
                lblSeleccionado.Text = elemento.Descripcion;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!validarElemento())
                return;
            string descripcion = txtElemento.Text.Trim();
            if (descripcion.Length < 3)
            {
                MessageBox.Show("La descripción debe tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (elementoExistente(descripcion))
                {
                    MessageBox.Show("El elemento ya existe en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Elemento nuevoElemento = new Elemento();
                nuevoElemento.Descripcion = textInfo.ToTitleCase(descripcion.ToLower());
                ElementoNegocio negocio = new ElementoNegocio();
                negocio.agregar(nuevoElemento);
                DialogResult res = MessageBox.Show("Elemento agregado correctamente.\n¿Desea agregar otro elemento?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    limpiarFormulario();
                }
                else
                {
                    cerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validarElemento())
                return;
            string descripcion = txtElemento.Text.Trim();
            if (descripcion.Length < 3)
            {
                MessageBox.Show("La descripción debe tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (elementoExistente(descripcion))
                {
                    MessageBox.Show("El elemento ya existe en la lista (No tiene modificaciones).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string descripcionNueva = textInfo.ToTitleCase(descripcion.ToLower());
                DialogResult confirmar = MessageBox.Show($"¿Confirma modificar el elemento '{elemento.Descripcion}' por '{descripcionNueva}'?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.No)
                    return;
                elemento.Descripcion = descripcionNueva;
                ElementoNegocio negocio = new ElementoNegocio();
                negocio.modificar(elemento);
                DialogResult res = MessageBox.Show("Elemento modificado correctamente.\n¿Desea modificar o cargar otro elemento?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    limpiarFormulario();
                } else
                {
                    cerrar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
