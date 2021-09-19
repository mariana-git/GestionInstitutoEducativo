using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_CargaCombobox : CD_Conexion
    {
        
        private DataTable DT = new DataTable();
        //private CD_Conexion Conexion = new CD_Conexion();

        #region ATRIBUTOS
        private string tabla;
        private string idCampo;
        private string campoDescrip;
        private string condicion;
        #endregion

        #region PROPERTIES
        public string Tabla { get => tabla; set => tabla = value; }
        public string Campoid { get => idCampo; set => idCampo = value; }
        public string Campodescrip { get => campoDescrip; set => campoDescrip = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        #endregion

        #region CONEXION OLEDB (DESACTIVADO)

        //public DataTable CargaCombobox()
        //{
        //    string consulta;
        //    if (condicion == "")
        //    {
        //        consulta = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " ORDER BY " + campodescrip;
        //    }
        //    else
        //    {
        //        consulta = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " Where  " + condicion + " ORDER BY " + campodescrip;
        //    }

        //    
        //    OleDbCommand Comandos = new OleDbCommand(consulta, Conexion.Conectar());
        //    OleDbDataReader LeerBD = Comandos.ExecuteReader();
        //    DT.Load(LeerBD);
        //    Conexion.Desconectar();
        //    return DT;
        //}
        #endregion
        #region CONEXION MYSQL (ACTIVADO)

        public DataTable CargaCombobox()
        {
            string consulta;
            if (condicion == "")
            {
                consulta = "SELECT " + idCampo + ", " + campoDescrip + " FROM " + tabla + " ORDER BY " + campoDescrip;
            }
            else
            {
                consulta = "SELECT " + idCampo + ", " + campoDescrip + " FROM " + tabla + " Where  " + condicion + " ORDER BY " + campoDescrip;
            }
            MySqlCommand Comandos = new MySqlCommand(consulta, Conectar());
            MySqlDataReader LeerBD = Comandos.ExecuteReader();
            DT.Load(LeerBD);
            Desconectar();
            return DT;
        }
        #endregion

    }
}
