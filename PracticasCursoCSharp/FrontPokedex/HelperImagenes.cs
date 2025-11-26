using DominioPokedex;
using System;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

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

        public static string SeleccionarImagen()
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            try
            {
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    return archivo.FileName;
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string CopiarImagenSeleccionada(string urlOrigen, string nombre)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(urlOrigen) || !File.Exists(urlOrigen))
                    return "";

                string carpetaDestino = ConfigurationManager.AppSettings["images-folder"];

                Directory.CreateDirectory(carpetaDestino);

                string destino = Path.Combine(carpetaDestino, nombre);
                File.Copy(urlOrigen, destino, true);

                return destino;
            }
            catch
            {
                throw;
            }
        }
    }
}
