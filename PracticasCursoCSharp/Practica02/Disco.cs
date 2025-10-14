using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public class Disco
    {
        //Atributos
        private int id;
        private string titulo;

        public Disco(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return titulo;
        }

        public string Titulo{
            get { return titulo; }
            set { titulo = value; }
        }

        public DateTime FechaLanzamiento { get; set; }
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        public string Estilo { get; set; }
        public string TipoEdicion { get; set; }
    }
}
