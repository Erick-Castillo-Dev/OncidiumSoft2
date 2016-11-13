﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OncidiumSoft.Objetos
{
    class Cls_Provedores
    {
        /// <summary>
        /// Variables para provedores
        /// </summary>
        private int idProvedores;
        private string Nombre;
        private string Direccion;
        private string Telefono;
        private string Empresa;

        public static MySqlConnection Conexion()
        {

            MySqlConnection conectar = new MySqlConnection("SERVER=" + "localhost" + ";PORT=3307" + ";DATABASE=" + "vivero" + ";UID=" + "root" + ";PWD=" + "");

            conectar.Open();
            return conectar;
        }

        public int iddeProvedores
        {
            get { return idProvedores; }
            set { idProvedores = value; }
        }


        public string NombreProvedor
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string DireccionProvedor
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public string TelefonoProvedor
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        public string EmpresadeProvedor
        {
            get { return Empresa; }
            set { Empresa = value; }
        }
    }
    }
}
