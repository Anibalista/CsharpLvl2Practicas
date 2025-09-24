using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo01
{
    public partial class Form1 : Form
    {
        private List<Telefono> telefonos = new List<Telefono>();
        private string marca;
        private string modelo;

        public Form1()
        {
            InitializeComponent();
        }

        public bool telefonoIncorrecto()
        {
            marca = txtMarca.Text;
            modelo = txtModelo.Text;
            return String.IsNullOrWhiteSpace(marca) || String.IsNullOrWhiteSpace(modelo);
        }

        public void cargaInicial()
        {
            telefonos.Add(new Telefono("A51", "Samsung"));
            telefonos.Add(new Telefono("Iphone 11", "Apple"));
            telefonos.Add(new Telefono("Moto G7", "Motorola"));
            telefonos.Add(new Telefono("Xperia Z5", "Sony"));
            telefonos.Add(new Telefono("P30 Lite", "Huawei"));
            telefonos.Add(new Telefono("Redmi Note 8", "Xiaomi"));
            telefonos[0].NumeroTelefonico = "1122334455";
            telefonos[1].NumeroTelefonico = "2233445566";
            telefonos[2].NumeroTelefonico = "3344556677";
            telefonos[3].NumeroTelefonico = "4455667788";
            telefonos[4].NumeroTelefonico = "5566778899";
            telefonos[5].NumeroTelefonico = "6677889900";
            telefonos[0].CodigoOperador = 1;
            telefonos[1].CodigoOperador = 2;
            telefonos[2].CodigoOperador = 3;
            telefonos[3].CodigoOperador = 4;
            telefonos[4].CodigoOperador = 0;
            telefonos[5].CodigoOperador = -1;
        }

        private void agregarAGrilla( Telefono telefono)
        {
            if (telefono == null) return;
            telefonos.Add(telefono);
            dataGridTelefonos.DataSource = null;
            dataGridTelefonos.DataSource = telefonos;
            dataGridTelefonos.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaInicial();
            dataGridTelefonos.DataSource = telefonos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (telefonoIncorrecto())
            {
                MessageBox.Show("Debe completar los campos Marca y Modelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Telefono tel = new Telefono(modelo, marca);
            tel.NumeroTelefonico = txtNumero.Text;
            tel.CodigoOperador = (int)numOperador.Value;
            agregarAGrilla(tel);
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            string numero = txtNumLlamada.Text;
            string mensaje;
            Telefono tel = (Telefono)dataGridTelefonos.CurrentRow.DataBoundItem;
            if (String.IsNullOrWhiteSpace(numero))
            {
                mensaje = tel.Llamar();
            }
            else
            {
                mensaje = tel.Llamar(numero);
            }
            MessageBox.Show(mensaje, "Llamada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
