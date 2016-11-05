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
            }
            return -1;
        }

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
            }
            return false;
        }

    }
}
