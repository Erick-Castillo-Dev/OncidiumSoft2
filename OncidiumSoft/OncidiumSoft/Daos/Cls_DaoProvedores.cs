using MySql.Data.MySqlClient;
using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OncidiumSoft.Objetos;

namespace OncidiumSoft.Daos
{
    class Cls_DaoProvedores
    {
        /// <summary>
        /// Objecto para acceder a a la conecion a la db
        /// </summary>
        Conexion c = new Conexion();
        /// <summary>
        /// Metodo para selecionar los provedores de la db
        /// </summary>
        /// <returns></returns>
        public List<Cls_Provedores> llenar()
        {
            List<Cls_Provedores> list = new List<Cls_Provedores>();
            try
            {
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "select * from provedores";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Cls_Provedores p = new Cls_Provedores();
                    p.iddeProvedores = dr.GetInt32("idProvedores");
                    p.NombreProvedor = dr.GetString("Nombre");
                    p.DireccionProvedor = dr.GetString("Direccion");
                    p.TelefonoProvedor = dr.GetString("Telefono");
                    p.EmpresadeProvedor = dr.GetString("Empresa");
                    list.Add(p);
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
        /// <summary>
        /// Metodo para modificar provedores en la db
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool editar(Cls_Provedores p)
        {
            bool q = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                c.Conectar();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@id",p.iddeProvedores);
                cmd.Parameters.AddWithValue("@Nombre", p.NombreProvedor);
                cmd.Parameters.AddWithValue("@Direccion", p.DireccionProvedor);
                cmd.Parameters.AddWithValue("@Empresa", p.EmpresadeProvedor);
                cmd.Parameters.AddWithValue("@Telefono", p.TelefonoProvedor);
                cmd.CommandText = "UPDATE provedores SET Nombre = @Nombre,Direccion = @Direccion,Telefono = @Telefono,Empresa = @Empresa WHERE idProvedores = @id";
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
        /// <summary>
        /// Metodo para buscar el provedor por el nombre en ls db
        /// </summary>
        /// <param name="provedor"></param>
        /// <returns></returns>
        public List<Cls_Provedores> buscar(string provedor)
        {
            try
            {
                List<Cls_Provedores> x = new List<Cls_Provedores>();
                string sql = "";
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                sql = "select * from provedores where Nombre LIKE '" + provedor + "%'";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Cls_Provedores p = new Cls_Provedores();
                    p.iddeProvedores = dr.GetInt32("idProvedores");
                    p.NombreProvedor = dr.GetString("Nombre");
                    p.DireccionProvedor = dr.GetString("Direccion");
                    p.TelefonoProvedor = dr.GetString("Telefono");
                    p.EmpresadeProvedor = dr.GetString("Empresa");
                    
                    x.Add(p);
                }
                c.Cerrar();
                return x;

            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }
        /// <summary>
        /// Metodo para agregar nuevos proveedores a la db.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool agregar(Cls_Provedores p) {
            bool q = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                c.Conectar();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@Nombre", p.NombreProvedor);
                cmd.Parameters.AddWithValue("@Direccion", p.DireccionProvedor);
                cmd.Parameters.AddWithValue("@Empresa", p.EmpresadeProvedor);
                cmd.Parameters.AddWithValue("@Telefono", p.TelefonoProvedor);
                cmd.CommandText = "INSERT INTO provedores (Nombre,Direccion,Telefono,Empresa)VALUES(@Nombre,@Direccion,@Telefono,@Empresa);";
                cmd.ExecuteNonQuery();
                q = true;
                c.Cerrar();
            }catch (MySqlException ex)
            {
                q = false;
                c.Cerrar();
            }
            return q;
        }
        /// <summary>
        /// Metodo que nos hace la seleccion de provedores por el id en la db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cls_Provedores obtenerProvedor(int id)
        {
            Cls_Ventas cls = new Cls_Ventas();
            string sql = "";
            try
            {
                MySqlCommand cm = new MySqlCommand();
                MySqlDataReader dr;
                c.Conectar();
                cm.Parameters.AddWithValue("@id",id);
                sql = "select * from provedores where idProvedores = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = c.cConexion;
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    Cls_Provedores p = new Cls_Provedores();
                    p.iddeProvedores = dr.GetInt32("idProvedores");
                    p.NombreProvedor = dr.GetString("Nombre");
                    p.DireccionProvedor = dr.GetString("Direccion");
                    p.TelefonoProvedor = dr.GetString("Telefono");
                    p.EmpresadeProvedor = dr.GetString("Empresa");
                    c.Cerrar();
                    return p;
                }
            }
            catch (MySqlException e)
            {
                c.Cerrar();
                return null;
            }
            return null;
        }
        /// <summary>
        /// Metodo para eliminar proveedores por el id en la db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool eliminarProvedor(int id)
        {
            bool q = false;
            try
            {
                c.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = c.cConexion;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "DELETE FROM provedores WHERE idProvedores = @id";
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

    }

}
