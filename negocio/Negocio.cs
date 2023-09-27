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
        public List<OutSide> listarOutSide()
        {
            List<OutSide> lista = new List<OutSide>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select L.ID_Local, L.Nombre, L.Direccion, L.ID_Localidad, L.Descripcion, L.ID_Categoria, Loc.Nombre as Localidad, C.Nombre as Categoria, I.ID_Imagen as ID_Imagen, I.Nombre as Imagen, I.ID_Food as IdFood, L.Afuera as Donde from Locales L inner join Localidades Loc on L.ID_Localidad = Loc.ID_Localidad inner join Categorias C on L.ID_Categoria = C.ID_Categoria inner join Imagenes I on I.ID_Food = L.ID_Local");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    OutSide aux = new OutSide();

                    aux.id = (int)datos.Lector["ID_Local"];
                    aux.name = (string)datos.Lector["Nombre"];
                    aux.adress = (string)datos.Lector["Direccion"];

                    aux.localidad = new Localidad();
                    aux.localidad.id = (int)datos.Lector["Id_Localidad"];
                    aux.localidad.descripcion = (string)datos.Lector["Localidad"];

                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    aux.imagen = new Imagen();
                    aux.imagen.id = (int)datos.Lector["ID_Imagen"];
                    aux.imagen.name = (string)datos.Lector["Imagen"];
                    aux.imagen.Id_Food = (int)datos.Lector["IDFood"];

                    aux.outside = (int)datos.Lector["Donde"];

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
                datos.setearConsulta("");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    OutSide aux = new OutSide();
                    aux.id = (int)datos.Lector["ID_Local"];
                    aux.name = (string)datos.Lector["Nombre"];
                    aux.adress = (string)datos.Lector["Direccion"];

                    aux.localidad = new Localidad();
                    aux.localidad.id = (int)datos.Lector["Id_Localidad"];
                    aux.localidad.descripcion = (string)datos.Lector["Localidad"];

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

        public void addOut(OutSide nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Locales(Nombre, Direccion, ID_Localidad, Descripcion, ID_Categoria, Afuera)values(@nombre, @direccion, @localidad, @descripcion, @categoria, 1)");
                datos.setearParametro("@nombre", nuevo.name);
                datos.setearParametro("@direccion", nuevo.adress);
                datos.setearParametro("@localidad", nuevo.localidad.id);
                datos.setearParametro("@descripcion", nuevo.descripcion);
                datos.setearParametro("@categoria", nuevo.categoria.id);
                datos.ejecutarAcccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void addImagen(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Imagenes(Nombre, ID_Food)values(@name,@id_food)");
                datos.setearParametro("@id_food", nuevo.Id_Food);
                datos.setearParametro("@name", nuevo.name);              
                datos.ejecutarAcccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(OutSide local)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Locales set Nombre = @nombre , Direccion = @direccion, ID_Localidad = @id_Localidad, Descripcion = @descripcion,ID_Categoria = @id_Categoria where ID_Local = @id");
                datos.setearParametro("@nombre", local.name);
                datos.setearParametro("@direccion",local.adress);
                datos.setearParametro("@id_Localidad",local.localidad.id);
                datos.setearParametro("@descripcion",local.descripcion);
                datos.setearParametro("@id_Categoria",local.categoria.id);
                datos.setearParametro("@id",local.id);
                datos.ejecutarAcccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificarImagen(Imagen imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Imagenes set Nombre = @nombre where ID_Imagen = @id and ID_Food = @id_Food");
                datos.setearParametro("@id", imagen.id);
                datos.setearParametro("@nombre", imagen.name);
                datos.setearParametro("@id_Food",imagen.Id_Food);
                datos.ejecutarAcccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Locales where ID_Local = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAcccion();               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                datos.cerrarConexion();
            }
        }
        public void eliminarImagen(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {               
                datos.setearConsulta("delete from Imagenes where ID_Food = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAcccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Categoria> listarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID_Categoria, Nombre from Categorias");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.id = (int)datos.Lector["ID_Categoria"];
                    aux.nombre = (string)datos.Lector["Nombre"];
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
                datos.cerrarConexion();
            }
        }
        public List<Localidad> listarLocalidad()
        {
            List<Localidad> lista = new List<Localidad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID_Localidad, Nombre from Localidades");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Localidad aux = new Localidad();
                    aux.id = (int)datos.Lector["ID_Localidad"];
                    aux.descripcion = (string)datos.Lector["Nombre"];
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
                datos.cerrarConexion();
            }
        }
        public int UltimoRegistro()
        {
            List<OutSide> lista = new List<OutSide>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID_Local as id from Locales");
                datos.ejecutarLectura();
                int aux = new int();

                while (datos.Lector.Read())
                {
                    aux = (int)datos.Lector["id"];                    
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

