using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_CargaCombobox : CD_Conexion
    {
        
        private DataTable DT = new DataTable();

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

      

    }
}
