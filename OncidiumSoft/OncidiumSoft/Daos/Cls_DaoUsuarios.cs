using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncidiumSoft.Objetos;
using OncidiumSoft.Conexxion_Datos;
using MySql.Data.MySqlClient;
using System.Data;



namespace OncidiumSoft.Daos
{
    class Cls_DaoUsuarios
    {

        Conexion c = new Conexion();
        /// <summary>
        /// Metodo para obtener el id del usuario para su uso posterio
        /// </summary>
        /// <param name="clsU"></param>
        /// <returns></returns>
        public int idUsuario(Cls_Usuarios clsU)
        {
            try
            {

                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@Usuario", clsU.usuario);
                cm.Parameters.AddWithValue("@Contrasena", clsU.contrasena);
                sql = "select idUsuarios from usuarios where usuario = @Usuario and Contrasena = sha1(md5(@Contrasena))";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    int s = dr.GetInt32("idUsuarios");
                    c.Cerrar();
                    return s;
                }
                else
                {
                    c.Cerrar();
                    return 0;
                }
                
            }
            catch (MySqlException e)
            {
                return -1;
                c.Cerrar();
            }
            return -1;
        }
        /// <summary>
        /// Metodo para la autenticacion de los ususarios que podran entrar al
        /// sistema mediante su usuario y contraseña ademas de usar encriptacion
        /// sh1 con md5
        /// </summary>
        /// <param name="clsU"></param>
        /// <returns></returns>
        public bool entrar(Cls_Usuarios clsU)
        {
            try
            {
                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@Usuario", clsU.usuario);
                cm.Parameters.AddWithValue("@Contrasena", clsU.contrasena);
                sql = "select count(*) from usuarios where usuario = @Usuario and Contrasena = sha1(md5(@Contrasena))";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr.GetInt32("count(*)")!=0)
                    {
                        c.Cerrar();
                        return true;
                    }
                    else
                    {
                        c.Cerrar();
                        return false;
                    }
                }
                else
                {
                    c.Cerrar();
                    return false;
                }
            }catch(MySqlException e){
                return false;
                c.Cerrar();
            }
            return false;
        }

        public string administrador(Cls_Usuarios clsU)
        {
            string s;
            try
            {

                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@id", clsU.idUsuario);
                sql = "select Puesto from usuarios where idUsuarios = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    s = dr.GetString("Puesto");
                    c.Cerrar();
                }
                else
                {
                    c.Cerrar();
                    s = "";
                }

            }
            catch (MySqlException e)
            {
                s = "";
                c.Cerrar();
            }
            return s;
        }

        /// <summary>
        /// Metodo para obtener el nombre del usuario de la base de datos 
        /// </summary>
        /// <param name="clsU"></param>
        /// <returns></returns>
        public string NombreUsuario(Cls_Usuarios clsU)
        {
            try
            {

                string sql;
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@id", clsU.idUsuario);
                sql = "select Nombre from usuarios where idUsuarios = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string s = dr.GetString("Nombre");
                    c.Cerrar();
                    return s;
                }
                else
                {
                    c.Cerrar();
                    return "";
                }

            }
            catch (MySqlException e)
            {
                return "";
                c.Cerrar();
            }
            return "";
        }

        /// <summary>
        /// Metodo de llenado de usuarios que contiene la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataSet llenar()
        {
            DataSet usuarios = new DataSet();
            try
            {
                c.Conectar();
                MySqlDataAdapter muestreo = new MySqlDataAdapter("select*from usuarios", c.cConexion);
            muestreo.Fill(usuarios, "usuarios");
            }catch(MySqlException e){
                c.Cerrar();
                return null;
            }
            return usuarios;
        }
        /// <summary>
        /// Elimina el Usuario selecionado.
        /// </summary>
        /// <param name="u"></param>
        public bool EliminarUsuario(Cls_Usuarios u)
        {
            bool s;
            try
            {
                string sql;
                MySqlCommand cm;
                c.Conectar();

                cm = new MySqlCommand();
                cm.Parameters.AddWithValue("@idUsuario", u.idUsuario);
                sql = "DELETE FROM usuarios WHERE idUsuarios = @idUsuario";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text; ;
                cm.Connection = c.cConexion;
                cm.ExecuteNonQuery();
                c.Cerrar();
                s = true;
            }catch(MySqlException e){
                c.Cerrar();
                s = false;
            }
            return s;
        }
        /// <summary>
        /// Agrega usuarios a la tabla de la db
        /// </summary>
        /// <param name="usuario"></param>
        public void AgregarUsuario(Cls_Usuarios usuario)
        {
            string sql;
            MySqlCommand cm;
            c.Conectar();
            cm = new MySqlCommand();

            cm.Parameters.AddWithValue("@Nombre", usuario.nombre);
            cm.Parameters.AddWithValue("@Direccion", usuario.direccion);
            cm.Parameters.AddWithValue("@Telefono", usuario.telefono);
            cm.Parameters.AddWithValue("@Usuario", usuario.usuario);
            cm.Parameters.AddWithValue("@Contrasena", usuario.contrasena);
            cm.Parameters.AddWithValue("@Puesto", usuario.puesto);

            sql = "INSERT INTO usuarios (Nombre,Direccion,Telefono,Usuario,Contrasena,Puesto)  VALUES (@Nombre,@Direccion,@Telefono,@Usuario,sha1(md5(@Contrasena)),@Puesto)";
            
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = c.cConexion;
            cm.ExecuteNonQuery();
            c.Cerrar();
        }


        
    
    
    }
}
