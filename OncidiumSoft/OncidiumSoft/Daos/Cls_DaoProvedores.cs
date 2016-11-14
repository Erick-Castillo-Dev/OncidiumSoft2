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
        /// Objecto para acceder a la conexion de la db.
        /// </summary>
        Conexion c = new Conexion();
        /// <summary>
        /// Metodo de llenado de provedores que contiene la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataSet llenar()
        {
            c.Conectar();
            MySqlDataAdapter muestreo = new MySqlDataAdapter("select*from provedores", c.cConexion);
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
            c.Conectar();

            cm = new MySqlCommand();
            cm.Parameters.AddWithValue("@idProvedores", u.iddeProvedores);
            sql = "DELETE FROM provedores WHERE idProvedores = @idProvedores";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text; ;
            cm.Connection = c.cConexion;
            cm.ExecuteNonQuery();
            c.Cerrar();
        }
        /// <summary>
        /// Agrega provedores a la db
        /// </summary>
        /// <param name="p"></param>
        public void AgregarProvedor(Cls_Provedores p)
        {
            string sql;
            MySqlCommand cm;
            c.Conectar();
            cm = new MySqlCommand();
           
            cm.Parameters.AddWithValue("@Nombre", p.NombreProvedor);
            cm.Parameters.AddWithValue("@Direccion", p.DireccionProvedor);
            cm.Parameters.AddWithValue("@Telefono", p.TelefonoProvedor);
            cm.Parameters.AddWithValue("@Empresa", p.EmpresadeProvedor);
            sql = "INSERT INTO provedores (Nombre,Direccion,Telefono,Empresa)  VALUES (@Nombre,@Direccion,@Telefono,@Empresa)";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = c.cConexion;
            cm.ExecuteNonQuery();
            c.Cerrar();
        }

        /// <summary>
        /// Busca un provedor por id
        /// </summary>
        /// <param name="IdProvedores"></param>
        /// <returns></returns>
      /*  public static List<Cls_Provedores> Buscar(string IdProvedores)
        {
            List<Cls_Provedores> _lista = new List<Cls_Provedores>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT idProvedores, Nombre, Direccion, Telefono, Empresa FROM provedores where idProvedores ='{0};'", IdProvedores), c.cConexion);
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



        }*/


         public Objetos.Cls_Provedores buscarProvedor(ref Objetos.Cls_Provedores cli)
        {
            c.Conectar();
            string consulta = "Select * from Provedores where idProvedores= " + cli.iddeProvedores;
            MySqlCommand miCom = new MySqlCommand(consulta, c.cConexion);
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
            c.Cerrar();
            return cli;
        }



    }

}
