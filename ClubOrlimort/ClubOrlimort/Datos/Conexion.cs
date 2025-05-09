﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubOrlimort.Datos
{
    internal class Conexion
    {
        private string baseDatos, servidor, puerto, usuario, clave;
        private static Conexion? con = null;

        private Conexion()
        {
            this.baseDatos = "lordorlimort";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "14095";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor + ";port=" + this.puerto +
                    ";username=" + this.usuario + ";password=" + this.clave + ";Database=" + this.baseDatos;
            }
            catch (Exception ex) 
            { cadena = null; throw;}
            return cadena;
        }
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
