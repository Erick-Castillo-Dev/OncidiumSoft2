using MySql.Data.MySqlClient;
using OncidiumSoft.Conexxion_Datos;
using OncidiumSoft.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OncidiumSoft.Daos
{
    class Cls_DaoProvedores
    {
        /// <summary>
        /// conexion con mysql
        /// </summary>
        private MySqlConnection cnConexion = new MySqlConnection();
        /// <summary>
        /// Objecto para acceder a la conexion de la db.
        /// </summary>
        Conexion conexionDB = new Conexion();
        /// <summary>
        /// Metodo de llenado de provedores que contiene la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataSet llenar()
        {
            conexionDB.Conectar();
            MySqlDataAdapter muestreo = new MySqlDataAdapter("select*from provedores", conexionDB.cConexion);
            DataSet provedores = new DataSet();
            muestreo.Fill(provedores, "provedores");
            return provedores;
        }
        /// <summary>
        /// Elimina un provedor con el id
        /// </summary>
        /// <param name="u"></param>
        public void EliminarProvedor(Cls_Provedores u)
        {
            string sql;
            MySqlCommand cm;
            conexionDB.Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@idProvedores", u.iddeProvedores);
            sql = "DELETE FROM provedores WHERE idProvedores = @idProvedores";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text; ;
            cm.Connection = conexionDB.cConexion;
            cm.ExecuteNonQuery();
            conexionDB.Cerrar();
        }
        /// <summary>
        /// Agrega provedores a la db
        /// </summary>
        /// <param name="p"></param>
        public void AgregarProvedor(Cls_Provedores p)
        {
            string sql;
            MySqlCommand cm;
            conexionDB.Conectar();
            cm = new MySqlCommand();
           
            cm.Parameters.AddWithValue("@Nombre", p.NombreProvedor);
            cm.Parameters.AddWithValue("@Direccion", p.DireccionProvedor);
            cm.Parameters.AddWithValue("@Telefono", p.TelefonoProvedor);
            cm.Parameters.AddWithValue("@Empresa", p.EmpresadeProvedor);
            sql = "INSERT INTO provedores (Nombre,Direccion,Telefono,Empresa)  VALUES (@Nombre,@Direccion,@Telefono,@Empresa)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = conexionDB.cConexion;
            cm.ExecuteNonQuery();
            conexionDB.Cerrar();
        }

        /// <summary>
        /// Busca un provedor por id
        /// </summary>
        /// <param name="IdProvedores"></param>
        /// <returns></returns>
        public static List<Objetos.> Buscar(string IdProvedores)
        {
            List<Objetos.Cls_Provedores> _lista = new List<Objetos.Cls_Usuarios>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT idProvedores, Nombre, Direccion, Telefono, Empresa FROM provedores where idProvedores ='{0};'", IdProvedores), Objetos.Cls_Provedores.Conexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cls_Provedores ObjProvedoress = new Cls_Provedores();

                ObjProvedoress.iddeProvedores = _reader.GetInt32(0);
                ObjProvedoress.NombreProvedor = _reader.GetString(1);
                ObjProvedoress.DireccionProvedor = _reader.GetString(2);
                ObjProvedoress.TelefonoProvedor = _reader.GetString(3);
                ObjProvedoress.EmpresadeProvedor = _reader.GetString(4);



                _lista.Add(ObjProvedoress);
            }
            return _lista;



        }


         public Objetos.Cls_Provedores buscarProvedor(ref Objetos.Cls_Provedores cli)
        {
            conexionDB.Conectar();
            string consulta = "Select * from Provedores where idProvedores= " + cli.iddeProvedores;
            MySqlCommand miCom = new MySqlCommand(consulta, cnConexion);
            MySqlDataReader midataReader = miCom.ExecuteReader();
            midataReader.Read();
            if (midataReader.HasRows)
            {
                cli.iddeProvedores = Convert.ToInt32(midataReader["idProvedor"].ToString());
                cli.NombreProvedor = midataReader["Nombre"].ToString();
                cli.DireccionProvedor = midataReader["Direccion"].ToString();
                cli.TelefonoProvedor = midataReader["Telefono"].ToString();
                cli.EmpresadeProvedor = midataReader["Empresa"].ToString();
          

            }
            else
            {
                return null;
            }
            midataReader.Close();
            miCom.Dispose();
            cnConexion.Close();
            return cli;
        }



    }

}
