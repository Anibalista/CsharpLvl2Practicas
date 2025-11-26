using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Título")]
        public string Titulo{
            get { return titulo; }
            set { titulo = value; }
        }

        [DisplayName("Fecha de Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [DisplayName("Cantidad de Canciones")]
        public int CantidadCanciones { get; set; }

        [DisplayName("Imagen de Tapa")]
        public string UrlImagenTapa { get; set; }
        public Estilos Estilo { get; set; }

        [DisplayName("Tipo de Edición")]
        public TiposEdicion TipoEdicion { get; set; }
    }
}
