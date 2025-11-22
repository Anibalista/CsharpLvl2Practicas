using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DominioPokedex;

namespace NegocioPokedex
{
    public class PokemonNegocio
    {
        public List<Pokemon> Listar(bool inactivos)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            int filtroActivo = inactivos ? -1 : 0;
            try
            {
                datos.SetearConsulta($"select p.Id, p.Numero, p.Nombre, p.Descripcion, p.UrlImagen, IdDebilidad, IdTipo, t.Descripcion as Tipo, d.Descripcion as Debilidad, p.Activo from POKEMONS p join ELEMENTOS t on p.IdTipo = t.Id join ELEMENTOS d on p.IdDebilidad = d.Id where Activo > {filtroActivo}");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Activo = (bool)datos.Lector["Activo"];

                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
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
                datos.CerrarConexion();
            }
        }

        public void Agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) values (@Numero, @Nombre, @Descripcion, @UrlImagen, @IdTipo, @IdDebilidad, 1)");
                datos.SetearParametro("@Numero", nuevo.Numero);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@UrlImagen", nuevo.UrlImagen ?? "");
                datos.SetearParametro("@IdTipo", nuevo.Tipo.Id);
                datos.SetearParametro("@IdDebilidad", nuevo.Debilidad.Id);
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

        public void Modificar(Pokemon pokemon)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update POKEMONS set Numero = @Numero, Nombre = @Nombre, Descripcion = @Descripcion, UrlImagen = @UrlImagen, IdTipo = @IdTipo, IdDebilidad = @IdDebilidad where Id = @Id");
                datos.SetearParametro("@Numero", pokemon.Numero);
                datos.SetearParametro("@Nombre", pokemon.Nombre);
                datos.SetearParametro("@Descripcion", pokemon.Descripcion);
                datos.SetearParametro("@UrlImagen", pokemon.UrlImagen ?? "");
                datos.SetearParametro("@IdTipo", pokemon.Tipo.Id);
                datos.SetearParametro("@IdDebilidad", pokemon.Debilidad.Id);
                datos.SetearParametro("@Id", pokemon.Id);
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

        public void EliminarFisico(Pokemon pokemon)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("delete from POKEMONS where Id = @Id");
                datos.SetearParametro("@Id", pokemon.Id);
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

        public void EliminarLogico(Pokemon pokemon)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update POKEMONS set Activo = 0 where Id = @Id");
                datos.SetearParametro("@Id", pokemon.Id);
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

        public void Activar(Pokemon pokemon)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("update POKEMONS set Activo = 1 where Id = @Id");
                datos.SetearParametro("@Id", pokemon.Id);
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
