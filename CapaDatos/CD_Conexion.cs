using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    class CD_Conexion
    {
        private OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Personas.accdb");

        public OleDbConnection Conectar()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            Conexion.Open();

            return Conexion;
        }

        public OleDbConnection Desconectar()
        {
            Conexion.Close();
            return Conexion;
        }
    }
}
