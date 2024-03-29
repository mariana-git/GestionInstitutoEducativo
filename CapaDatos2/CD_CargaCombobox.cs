﻿using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_CargaCombobox : CD_Conexion
    {
        
        private DataTable DT = new DataTable();
        private CD_EjecuatarTransaccion Transaccion = new CD_EjecuatarTransaccion();

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

        public DataTable CargarCombos ()
        {
            DT.Clear();
            string sentencia = $"SELECT {CampoID}, {CampoNombre} FROM {Tabla} ORDER BY {CampoNombre};";
            DT = Transaccion.ModoConectado(sentencia);
            return DT;


        }

    }
}
