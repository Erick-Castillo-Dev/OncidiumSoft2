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

        public Cls_Usuarios obtenerUsuario(int id)
        {
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@id", id);
                sql = "select * from usuarios where idUsuarios = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    Cls_Usuarios u = new Cls_Usuarios();
                    u.idUsuario = dr.GetInt32("idUsuarios");
                    u.nombre = dr.GetString("Nombre");
                    u.direccion = dr.GetString("Direccion");
                    u.telefono = dr.GetString("Telefono");
                    u.usuario = dr.GetString("Usuario");
                    u.contrasena = dr.GetString("Contrasena");
                    u.puesto = dr.GetString("Puesto");
                    c.Cerrar();
                    return u;
                }
                
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }

        public List<Cls_Usuarios> llenar()
        {
            List<Cls_Usuarios> list = new List<Cls_Usuarios>();
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "select * from usuarios";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Cls_Usuarios u = new Cls_Usuarios();
                    u.idUsuario = dr.GetInt32("idUsuarios");
                    u.nombre = dr.GetString("Nombre");
                    u.direccion = dr.GetString("Direccion");
                    u.telefono = dr.GetString("Telefono");
                    u.usuario = dr.GetString("Usuario");
                    u.contrasena = dr.GetString("Contrasena");
                    u.puesto = dr.GetString("Puesto");
                    list.Add(u);
                }
                c.Cerrar();
                return list;
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }

        public bool eliminar(int id)
        {
            bool q = false;
            try
            {
                c.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "DELETE FROM usuarios WHERE idUsuarios = @id";
                cmd.ExecuteNonQuery();
                q = true;
                c.Cerrar();
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return q;
            }
            return q;
        }

        public bool agregar(Cls_Usuarios u)
        {
            bool q = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                c.Conectar();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@Nombre", u.nombre);
                cmd.Parameters.AddWithValue("@Direccion", u.direccion);
                cmd.Parameters.AddWithValue("@Telefono", u.telefono);
                cmd.Parameters.AddWithValue("@Usuario", u.usuario);
                cmd.Parameters.AddWithValue("@Contrasena", u.contrasena);
                cmd.Parameters.AddWithValue("@Puesto", u.puesto);
                cmd.CommandText = "INSERT INTO usuarios(Nombre,Direccion,Telefono,Usuario,Contrasena,Puesto)VALUES("+
                    "@Nombre,@Direccion,@Telefono,@Usuario,sha1(md5(@Contrasena)),@Puesto);";
                cmd.ExecuteNonQuery();
                q = true;
                c.Cerrar();
            }
            catch (MySqlException ex)
            {
                q = false;
                c.Cerrar();
            }
            return q;
        }

        public List<Cls_Usuarios> buscar(string usuario)
        {
            List<Cls_Usuarios> list = new List<Cls_Usuarios>();
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "select * from usuarios where Nombre LIKE '" + usuario + "%'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Cls_Usuarios u = new Cls_Usuarios();
                    u.idUsuario = dr.GetInt32("idUsuarios");
                    u.nombre = dr.GetString("Nombre");
                    u.direccion = dr.GetString("Direccion");
                    u.telefono = dr.GetString("Telefono");
                    u.usuario = dr.GetString("Usuario");
                    u.contrasena = dr.GetString("Contrasena");
                    u.puesto = dr.GetString("Puesto");
                    list.Add(u);
                }
                c.Cerrar();
                return list;
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }

        public bool editar(Cls_Usuarios u)
        {
            bool q = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                c.Conectar();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@id", u.idUsuario);
                cmd.Parameters.AddWithValue("@Nombre",u.nombre);
                cmd.Parameters.AddWithValue("@Direccion", u.direccion);
                cmd.Parameters.AddWithValue("@Telefono", u.telefono);
                cmd.Parameters.AddWithValue("@Usuario", u.usuario);
                cmd.Parameters.AddWithValue("@Contrasena", u.contrasena);
                cmd.Parameters.AddWithValue("@Puesto", u.puesto);
                cmd.CommandText = "UPDATE usuarios SET Nombre = @Nombre ,Direccion = @Direccion ,Telefono = @Telefono ,Usuario = @Usuario ,Contrasena = @Contrasena sha1(md5('@Contrasena'),Puesto = @Puesto WHERE idUsuarios = @id";
                cmd.ExecuteNonQuery();
                q = true;
                c.Cerrar();
            }
            catch (MySqlException ex)
            {
                q = false;
                c.Cerrar();
            }
            return q;
        }
    
    }
}
