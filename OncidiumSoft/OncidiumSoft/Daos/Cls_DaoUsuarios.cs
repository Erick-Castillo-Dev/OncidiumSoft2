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
        /// <summary>
        /// Objeto para hacer la conexion a la base de datos
        /// </summary>
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
        /// Objecto para acceder a la conexion de la db.
        /// </summary>
        Conexion conexionDB = new Conexion();
        /// <summary>
        /// Metodo de llenado de usuarios que contiene la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataSet llenar()
        {
            conexionDB.Conectar();
            MySqlDataAdapter muestreo = new MySqlDataAdapter("select*from usuarios", conexionDB.cConexion);
            DataSet usuarios = new DataSet();
            muestreo.Fill(usuarios, "usuarios");
            return usuarios;
        }
        /// <summary>
        /// Elimina el Usuario selecionado.
        /// </summary>
        /// <param name="u"></param>
        public void EliminarUsuario(Cls_Usuarios u)
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
        }
    }
}
