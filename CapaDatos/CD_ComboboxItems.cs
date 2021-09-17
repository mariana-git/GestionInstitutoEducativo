using System.Data;
using System.Data.OleDb;

/* Esta clase me permite cargar cualquier comboBox desde una tabla
   recibiendo  el Nombre de la tabala, el campo Id de la tabla relacionado al dato que mostrara el ComboBox 
   y el campo que mostrara el ComboBox.
   como opcional podra recibir una condicion .
*/
namespace CapaDatos
{
    public class CD_ComboboxItems
    {
        OleDbDataReader Reader;
        private DataTable DT = new DataTable();

        #region ATRIBUTOS
        private string tabla;
        private string campoid;
        private string campodescrip;
        private string condicion;
        #endregion

        #region PROPERTIES
        public string Tabla { get => tabla; set => tabla = value; }
        public string Campoid { get => campoid; set => campoid = value; }
        public string Campodescrip { get => campodescrip; set => campodescrip = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        #endregion


        public DataTable ItemsCombobox()
        {
            string sentencia;
            if (condicion == "")
            {
                sentencia = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " ORDER BY " + campodescrip;
            }
            else
            {
                sentencia = "SELECT " + campoid + ", " + campodescrip + " FROM " + tabla + " Where  " + condicion + " ORDER BY " + campodescrip;
            }

            CD_Conexion conexion = new CD_Conexion();
            OleDbCommand cmd = new OleDbCommand(sentencia, conexion.Conectar());
            Reader = cmd.ExecuteReader();
            DT.Load(Reader);
            conexion.Desconectar();

            return DT;
        }


    }
}
