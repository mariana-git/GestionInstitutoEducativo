using System.Data;
using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        #region CONEXION OLEDB (DESACTIVADO)
        //private OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Personas.accdb");

        //public OleDbConnection Conectar()
        //{
        //    if (Conexion.State == ConnectionState.Open) Conexion.Close();        //    
        //    Conexion.Open();
        //    return Conexion;
        //}

        //public OleDbConnection Desconectar()
        //{
        //    Conexion.Close();
        //    return Conexion;
        //}
        #endregion

        #region CONEXION MYSQL (ACTIVADO)
        //Parámetros para la conexion Mysql
        private readonly MySqlConnection CN = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestioninstituto;sslmode=none;persistsecurityinfo=true;");
        public MySqlConnection Conectar()
        {
            //método para ABRIR la conexion

            if (CN.State == ConnectionState.Open) CN.Close();
            CN.Open();            
            return CN;
        }
        public MySqlConnection Desconectar()
        {
            //método para CERRAR la conexion
            CN.Close();
            return CN;
        }
        #endregion

    }
}

