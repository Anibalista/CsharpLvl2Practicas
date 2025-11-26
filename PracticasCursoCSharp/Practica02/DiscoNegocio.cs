using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public class DiscoNegocio
    {
        public List<Estilos> listarEstilos()
        {
            List<Estilos> lista = new List<Estilos>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Descripcion From ESTILOS ORDER BY Descripcion");
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Estilos aux = new Estilos();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
        }

        public List<TiposEdicion> listaTiposEdicion()
        {
            List<TiposEdicion> tiposEdiciones = new List<TiposEdicion>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Descripcion From TIPOSEDICION ORDER BY Descripcion");
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    TiposEdicion aux = new TiposEdicion();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    tiposEdiciones.Add(aux);
                }
                return tiposEdiciones;
            }
            catch (Exception ex)
            {
                throw ex;
            } finally
            {
                accesoDatos.CerrarConexion();
            }
        }

        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Select d.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, e.Descripcion as Estilo, IdTipoEdicion, t.Descripcion as TipoEdicion From DISCOS d join ESTILOS e on d.IdEstilo = e.Id join TIPOSEDICION t on d.IdTipoEdicion = t.Id ORDER BY Titulo");
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Disco aux = new Disco((int)accesoDatos.Lector["Id"]);
                    aux.Titulo = (string)accesoDatos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)accesoDatos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)accesoDatos.Lector["CantidadCanciones"];
                    if (!(accesoDatos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)accesoDatos.Lector["UrlImagenTapa"];

                    Estilos estilo = new Estilos();
                    estilo.Id = (int)accesoDatos.Lector["IdEstilo"];
                    estilo.Descripcion = (string)accesoDatos.Lector["Estilo"];
                    aux.Estilo = estilo;

                    TiposEdicion edicion = new TiposEdicion();
                    edicion.Id = (int)accesoDatos.Lector["IdTipoEdicion"];
                    edicion.Descripcion = (string)accesoDatos.Lector["TipoEdicion"];
                    aux.TipoEdicion = edicion;

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } finally
            {
                accesoDatos.CerrarConexion();
            }

            return lista;
        }

        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta($"Insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion) values ('{nuevo.Titulo}', '{nuevo.FechaLanzamiento.ToString("yyyy-MM-dd")}', {nuevo.CantidadCanciones}, {nuevo.Estilo.Id}, {nuevo.TipoEdicion.Id})");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
