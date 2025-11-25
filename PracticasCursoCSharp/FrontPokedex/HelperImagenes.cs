using DominioPokedex;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontPokedex
{
    public static class HelperImagenes
    {
        public static string ObtenerUrlSeleccionada(Pokemon pokemon)
        {

            try
            {
                string urlImagen = pokemon?.UrlImagen;
                if (String.IsNullOrWhiteSpace(urlImagen))
                    return "imagenes/quien_es_este_pokemon.png";

                string ruta = urlImagen;
                if (ruta.StartsWith("http"))
                    return ruta;
                if (!File.Exists(ruta))
                    return "imagenes/quien_es_este_pokemon.png";
                return ruta;
            }
            catch (Exception)
            {
                return "imagenes/quien_es_este_pokemon.png";
            }
        }
    }
}
