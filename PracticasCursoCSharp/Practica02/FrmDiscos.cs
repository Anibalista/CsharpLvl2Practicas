using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica02
{
    public partial class FrmDiscos : Form
    {
        private List<Disco> listaDiscos;
        private List<Estilos> listaEstilos;
        private List<TiposEdicion> tiposEdiciones;
        private bool cerrando = false;
        private bool cargar = false;
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        public FrmDiscos()
        {
            InitializeComponent();
        }

        private void FrmDiscos_Load(object sender, EventArgs e)
        {
            cargarDiscos();
            cargarEstilos();
            cargarTiposEdicion();
        }

        //Métodos
        private void cargarDiscos()
        {
            if (cerrando) return;
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                cargar = true;
                dataGridDiscos.DataSource = null;
                listaDiscos = negocio.listar();
                dataGridDiscos.DataSource = listaDiscos;
                invisibilizarColumnas("Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
            {
                cargar = false;

            }

        }

        private void cargarEstilos()
        {
            if (cerrando) return;
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                cargar = true;
                cbEstilo.Items.Clear();
                cbEstilo.DataSource = null;
                listaEstilos = negocio.listarEstilos();
                cbEstilo.DataSource = listaEstilos;
                cbEstilo.DisplayMember = "Descripcion";
                cbEstilo.ValueMember = "Id";
                cbEstilo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cargar = false;
            }
        }

        private void cargarTiposEdicion()
        {
            if (cerrando) return;
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                cargar = true;
                cbEdicion.Items.Clear();
                cbEdicion.DataSource = null;
                tiposEdiciones = negocio.listaTiposEdicion();
                cbEdicion.DataSource = tiposEdiciones;
                cbEdicion.DisplayMember = "Descripcion";
                cbEdicion.ValueMember = "Id";
                cbEdicion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cargar = false;
            }
        }

        private void invisibilizarColumnas(string columna)
        {
            dataGridDiscos.Columns[columna].Visible = false;
        }

        private void cerrar()
        {
            cerrando = true;
            Close();
        }

        private void filtrarDiscos()
        {
            List<Disco> listaFiltrada = new List<Disco>();
            try
            {
                List<int> idsEstilos = new List<int>();
                List<int> idsTiposEdicion = new List<int>();
                bool cargarTodo = true;
                if (cbEstilo.SelectedIndex != -1)
                {
                    idsEstilos.Add(((Estilos)cbEstilo.SelectedItem).Id);
                }
                else
                {
                    idsEstilos = listaEstilos.Select(e => e.Id).ToList();
                    cargarTodo = false;
                }
                if (cbEdicion.SelectedIndex != -1)
                {
                    idsTiposEdicion.Add(((TiposEdicion)cbEdicion.SelectedItem).Id);
                }
                else
                {
                    idsTiposEdicion = tiposEdiciones.Select(te => te.Id).ToList();
                    cargarTodo = false;
                }
                string filtro = txtFiltroTitulo.Text.Trim().ToLower();
                cargarTodo = cargarTodo ? filtro.Length < 3 : false;
                if (cargarTodo)
                {
                    cargarDiscos();
                    return;
                } else
                {
                    listaFiltrada = listaDiscos.FindAll(l => l.Titulo.ToLower().Contains(filtro) && idsEstilos.Contains(l.Estilo.Id) && idsTiposEdicion.Contains(l.TipoEdicion.Id));
                }
                cargar = true;
                dataGridDiscos.DataSource = null;
                dataGridDiscos.DataSource = listaFiltrada;
                invisibilizarColumnas("Id");
                dataGridDiscos.Refresh();
                cargar = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbPortada.Load(imagen);
            }
            catch
            {
                pbPortada.Image = null;
            }
        }

                //Eventos
        private void txtFiltroTitulo_TextChanged(object sender, EventArgs e)
        {
            if (cerrando)
            {
                return;
            }
            if (txtFiltroTitulo.Text.Length > 0 && txtFiltroTitulo.Text.Length < 3)
                return;
            try
            {
                filtrarDiscos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void cbEstilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cerrando || cargar)
            {
                return;
            }
            try
            {
                filtrarDiscos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbEdicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cerrando || cargar)
            {
                return;
            }
            try
            {
                filtrarDiscos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (cerrando || cargar)
            {
                return;
            }
            try
            {
                if (dataGridDiscos.SelectedRows.Count > 0)
                {
                    Disco seleccionado = (Disco)dataGridDiscos.CurrentRow.DataBoundItem;
                    cargarImagen(seleccionado.UrlImagenTapa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAltaDisco_Click(object sender, EventArgs e)
        {
            string titulo = txtFiltroTitulo.Text.Trim();
            if (String.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("Ingrese un título para el nuevo disco.");
                return;
            }
            try
            {
                if (listaDiscos.Exists(d => d.Titulo.Equals(titulo, StringComparison.CurrentCultureIgnoreCase)))
                {
                    MessageBox.Show("Ya existe un disco con ese título.");
                    return;
                }
                if (cbEdicion.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un tipo de edición.");
                    return;
                }
                if (cbEstilo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un estilo.");
                    return;
                }
                Disco nuevoDisco = new Disco(0)
                {
                    Titulo = textInfo.ToTitleCase(titulo),
                    FechaLanzamiento = dateLanzamiento.Value,
                    CantidadCanciones = (int)numCamciones.Value,
                    Estilo = (Estilos)cbEstilo.SelectedItem,
                    TipoEdicion = (TiposEdicion)cbEdicion.SelectedItem
                };
                DiscoNegocio negocio = new DiscoNegocio();
                negocio.agregar(nuevoDisco);
                DialogResult respuesta = MessageBox.Show("Disco agregado con éxito. ¿Desea agregar otro?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    txtFiltroTitulo.Clear();
                    dateLanzamiento.Value = DateTime.Now;
                    numCamciones.Value = 1;
                    cbEstilo.SelectedIndex = -1;
                    cbEdicion.SelectedIndex = -1;
                    txtFiltroTitulo.Focus();
                }
                else
                {
                    cerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
