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
        /// Objeto para la conexion a la base de datos
        /// </summary>wsa
        public MySqlConnection cConexion = new MySqlConnection();
        /// <summary>
        /// Objecto para acceder a la conexion de la db.
        /// </summary>
        Conexion conexionDB = new Conexion();
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
                conexionDB.Conectar();
                cm.Parameters.AddWithValue("@Usuario", clsU.usuario);
                cm.Parameters.AddWithValue("@Contrasena", clsU.contrasena);
                sql = "select idUsuarios from usuarios where usuario = @Usuario and Contrasena = sha1(md5(@Contrasena))";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conexionDB.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    int s = dr.GetInt32("idUsuarios");
                    conexionDB.Cerrar();
                    return s;
                }
                else
                {
                    conexionDB.Cerrar();
                    return 0;
                }
                
            }
            catch (MySqlException e)
            {
                return -1;
                conexionDB.Cerrar();
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
                conexionDB.Conectar();
                cm.Parameters.AddWithValue("@Usuario", clsU.usuario);
                cm.Parameters.AddWithValue("@Contrasena", clsU.contrasena);
                sql = "select count(*) from usuarios where usuario = @Usuario and Contrasena = sha1(md5(@Contrasena))";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conexionDB.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr.GetInt32("count(*)")!=0)
                    {
                        conexionDB.Cerrar();
                        return true;
                    }
                    else
                    {
                        conexionDB.Cerrar();
                        return false;
                    }
                }
                else
                {
                    conexionDB.Cerrar();
                    return false;
                }
            }catch(MySqlException e){
                return false;
                conexionDB.Cerrar();
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
                conexionDB.Conectar();
                cm.Parameters.AddWithValue("@id", clsU.idUsuario);
                sql = "select Nombre from usuarios where idUsuarios = @id";
                cm.CommandText = sql;
                cm.CommandType = CommandType.Text;
                cm.Connection = conexionDB.cConexion;
                dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string s = dr.GetString("Nombre");
                    conexionDB.Cerrar();
                    return s;
                }
                else
                {
                    conexionDB.Cerrar();
                    return "";
                }

            }
            catch (MySqlException e)
            {
                return "";
                conexionDB.Cerrar();
            }
            return "";
        }



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
            conexionDB.Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@idUsuario", u.idUsuario);
            sql = "DELETE FROM usuarios WHERE idUsuarios = @idUsuario";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text; ;
            cm.Connection = conexionDB.cConexion;
            cm.ExecuteNonQuery();
            conexionDB.Cerrar();
        }
        /// <summary>
        /// Agrega usuarios a la tabla de la db
        /// </summary>
        /// <param name="usuario"></param>
        public void AgregarUsuario(Cls_Usuarios usuario)
        {
            string sql;
            MySqlCommand cm;
            conexionDB.Conectar();
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
            cm.Connection = conexionDB.cConexion;
            cm.ExecuteNonQuery();
            conexionDB.Cerrar();
        }


        /// <summary>
        /// Realiza la carga de los datos
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>

        public Objetos.Cls_Usuarios buscarUsuario(ref Objetos.Cls_Usuarios cli)
        {
            string sql;
         
            conexionDB.Conectar();
            
         sql = "Select * from usuarios where idUsuarios=" + cli.idUsuario;
            MySqlCommand miCom = new MySqlCommand(sql, cConexion);
            MySqlDataReader midataReader = miCom.ExecuteReader();
            midataReader.Read();
            if (midataReader.HasRows)
            {
                cli.idUsuario = Convert.ToInt32(midataReader["idUsuarios"].ToString());
                cli.nombre = midataReader["Nombre"].ToString();
                cli.direccion = midataReader["Direccion"].ToString();
                cli.telefono = midataReader["Telefono"].ToString();
                cli.usuario = midataReader["Categoria"].ToString();
                cli.contrasena =midataReader["Contrasena"].ToString();
                cli.puesto =midataReader["Puesto"].ToString();
              

            }
            else
            {
                return null;
            }
            midataReader.Close();
            miCom.Dispose();
            cConexion.Close();
            return cli;
        }

        /// <summary>
        /// Busca usuarios por id
        /// </summary>
        /// <param name="IdUsuarios"></param>
        /// <returns></returns>
        public static List<Objetos.Cls_Usuarios> Buscar(string IdUsuarios)
        {
            List<Objetos.Cls_Usuarios> _lista = new List<Objetos.Cls_Usuarios>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT idUsuarios, Nombre, Direccion, Telefono, Usuario, Contrasena, Puesto FROM usuarios where idUsuarios ='{0};'", IdUsuarios), Objetos.Cls_Usuarios.Conexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cls_Usuarios ObjUsuarios = new Cls_Usuarios();

                ObjUsuarios.idUsuario = _reader.GetInt32(0);
                ObjUsuarios.nombre = _reader.GetString(1);
                ObjUsuarios.direccion = _reader.GetString(2);
                ObjUsuarios.telefono = _reader.GetString(3);
                ObjUsuarios.usuario = _reader.GetString(4);
                ObjUsuarios.contrasena = _reader.GetString(5);
                ObjUsuarios.puesto = _reader.GetString(6);



                _lista.Add(ObjUsuarios);
            }
            return _lista;


        }
    
    }
}
