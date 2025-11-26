using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Elemento elemento;
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
            try
            {
                listaDeElementos = negocio.listar();
                listaElementos.DataSource = listaDeElementos;
                listaElementos.ValueMember = "Id";
                listaElementos.DisplayMember = "Descripcion";
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
                txtElemento.Text = elemento.Descripcion;
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
            string filtro = txtElemento.Text.ToLower();
            try
            {
                listaFiltrada = listaDeElementos.FindAll(e => e.Descripcion.ToLower().Contains(filtro));
                listaElementos.DataSource = null;
                listaElementos.DataSource = listaFiltrada;
                listaElementos.ValueMember = "Id";
                listaElementos.DisplayMember = "Descripcion";
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
        private void txtElemento_TextChanged(object sender, EventArgs e)
        {
            if (cerrarFormulario)
                return;
            string filtro = txtElemento.Text;
            if (filtro.Length > 0 && filtro.Length < 3)
                return;
            try
            {
                if (string.IsNullOrWhiteSpace(filtro))
                {
                    cargarElementos();
                }
                else
                {
                    filtrarElementos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!validarElemento())
                return;
            string descripcion = txtElemento.Text.Trim();
            try
            {
                if (elementoExistente(descripcion))
                {
                    MessageBox.Show("El elemento ya existe en la lista.");
                    return;
                }
                Elemento nuevoElemento = new Elemento();
                nuevoElemento.Descripcion = descripcion;
                ElementoNegocio negocio = new ElementoNegocio();
                negocio.agregar(nuevoElemento);
                MessageBox.Show("Elemento agregado correctamente.");
                DialogResult result = MessageBox.Show("¿Desea agregar otro elemento?", "Agregar otro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    limpiarFormulario();
                    cargarElementos();
                    return;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cerrar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validarElemento())
                return;
            string descripcion = txtElemento.Text.Trim();
            try
            {
                if (!elementoExistente(descripcion))
                {
                    MessageBox.Show("El elemento NO existe! Cargue uno nuevo.");
                    return;
                }

                ElementoNegocio negocio = new ElementoNegocio();
                negocio.modificar(elemento);
                DialogResult res = MessageBox.Show("Elemento modificado correctamente. ¿Desea modificar otro elemento?", "Modificar otro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    limpiarFormulario();
                    cargarElementos();
                    return;
                }
                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void listaElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cerrarFormulario)
                return;
            try
            {
                if (!validarSeleccion())
                {
                    elemento = null;
                    return;
                }
                else
                {
                    txtElemento.Text = elemento.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
