using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo01
{
    public class Telefono
    {
        private int codigoOperador;
        private string modelo;
        private string marca;

        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        public string Modelo { get { return modelo; } }
        public string Marca { get { return marca; } }
        public string NumeroTelefonico { get; set; }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value < 1 || value > 3)
                    codigoOperador = 0;
                else
                    codigoOperador = value;
            }
        }

        public string Llamar(string numero)
        {
            return $"Llamando al número {numero} ...";
        }

        public string Llamar()
        {
            return $"Realizando llamada...";
        }
    }
}
