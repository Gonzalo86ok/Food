using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class Negocio
    {
        public List<TakeWay> listarTakeWay()
        {
            List<TakeWay> lista = new List<TakeWay>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select L.ID_Local, L.Nombre, L.Direccion, L.ID_Localidad, L.Descripcion, L.ID_Imagen, L.ID_Categoria, Loc.Nombre as Localidad, C.Nombre as Categoria, I.Nombre as Imagen from Locales L inner join Localidades Loc on L.ID_Localidad = Loc.ID_Localidad inner join Categorias C on L.ID_Categoria = C.ID_Categoria inner join Imagenes I on I.ID_Imagen = L.ID_Imagen");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TakeWay aux = new TakeWay();
                    aux.id = (int)datos.Lector["ID_Local"];
                    aux.name = (string)datos.Lector["Nombre"];
                    aux.adress = (string)datos.Lector["Direccion"];

                    aux.localidad = new Localidad();
                    aux.localidad.id = (int)datos.Lector["Id_Localidad"];
                    aux.localidad.name = (string)datos.Lector["Localidad"];

                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    aux.imagen = new Imagen();
                    aux.imagen.id = (int)datos.Lector["ID_Imagen"];
                    aux.imagen.name = (string)datos.Lector["Imagen"];

                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["ID_Categoria"];
                    aux.categoria.nombre = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<OutSide> listarOutSide()
        {
            List<OutSide> lista = new List<OutSide>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select L.ID_Local, L.Nombre, L.Direccion, L.ID_Localidad, L.Descripcion, L.ID_Imagen, L.ID_Categoria, Loc.Nombre as Localidad, C.Nombre as Categoria, I.Nombre as Imagen from Locales L inner join Localidades Loc on L.ID_Localidad = Loc.ID_Localidad inner join Categorias C on L.ID_Categoria = C.ID_Categoria inner join Imagenes I on I.ID_Imagen = L.ID_Imagen");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    OutSide aux = new OutSide();
                    aux.id = (int)datos.Lector["ID_Local"];
                    aux.name = (string)datos.Lector["Nombre"];
                    aux.adress = (string)datos.Lector["Direccion"];

                    aux.localidad = new Localidad();
                    aux.localidad.id = (int)datos.Lector["Id_Localidad"];
                    aux.localidad.name = (string)datos.Lector["Localidad"];

                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    aux.imagen = new Imagen();
                    aux.imagen.id = (int)datos.Lector["ID_Imagen"];
                    aux.imagen.name = (string)datos.Lector["Imagen"];

                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["ID_Categoria"];
                    aux.categoria.nombre = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<OutSide> listarHome()
        {
            List<OutSide> lista = new List<OutSide>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select L.ID_Local, L.Nombre, L.Direccion, L.ID_Localidad, L.Descripcion, L.ID_Imagen, L.ID_Categoria, Loc.Nombre as Localidad, C.Nombre as Categoria, I.Nombre as Imagen from Locales L inner join Localidades Loc on L.ID_Localidad = Loc.ID_Localidad inner join Categorias C on L.ID_Categoria = C.ID_Categoria inner join Imagenes I on I.ID_Imagen = L.ID_Imagen");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    OutSide aux = new OutSide();
                    aux.id = (int)datos.Lector["ID_Local"];
                    aux.name = (string)datos.Lector["Nombre"];
                    aux.adress = (string)datos.Lector["Direccion"];

                    aux.localidad = new Localidad();
                    aux.localidad.id = (int)datos.Lector["Id_Localidad"];
                    aux.localidad.name = (string)datos.Lector["Localidad"];

                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    aux.imagen = new Imagen();
                    aux.imagen.id = (int)datos.Lector["ID_Imagen"];
                    aux.imagen.name = (string)datos.Lector["Imagen"];

                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["ID_Categoria"];
                    aux.categoria.nombre = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

