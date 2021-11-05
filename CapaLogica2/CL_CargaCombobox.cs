using System.Data;
using CapaDatos;

namespace CapaLogica
{
    class CL_CargaCombobox
    {
        private DataTable DT = new DataTable();
        private CD_CargaCombobox DatosCMB = new CD_CargaCombobox();

        #region ATRIBUTOS
        private string tabla;
        private string campoID;
        private string campoNombre;
        #endregion
        #region PROPERTIES
        public string Tabla { get => tabla; set => tabla = value; }
        public string CampoID { get => campoID; set => campoID = value; }
        public string CampoNombre { get => campoNombre; set => campoNombre = value; }
        #endregion

        public DataTable CargarCBM()
        {
            DatosCMB.Tabla = this.Tabla;
            DatosCMB.CampoID = this.CampoID;
            DatosCMB.CampoNombre = this.CampoNombre;

            DataTable tabla = new DataTable();
            tabla = DatosCMB.CargarCombos();
            return tabla;
        }
    }
}
