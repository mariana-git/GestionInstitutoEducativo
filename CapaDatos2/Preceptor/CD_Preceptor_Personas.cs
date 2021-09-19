using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos.Preceptor
{
    class CD_Preceptor_Personas : CD_Conexion
    {
        

        private DataTable DT = new DataTable();
        private CD_Conexion Conexion = new CD_Conexion();
        private MySqlCommand Comando = new MySqlCommand();
        private MySqlDataReader leer;

        #region ATRIBUTOS
        private int legajo, cuil, codPostal, iDPersona;
        private string nombre, apellido, fechaNac, documento, tipoDoc, telefono, calle, numeroCalle, piso, depto, localidad, provincia, email, sentencia;
        #endregion
        #region PROPIERTIES
        public int IDPersona { get => iDPersona; set => IDPersona = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Documento { get => documento; set => documento = value; }
        public string TipoDoc { get => tipoDoc; set => tipoDoc = value; }
        public int Cuil { get => cuil; set => cuil = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public string NumeroCalle { get => numeroCalle; set => numeroCalle = value; }
        public string Piso { get => piso; set => piso = value; }
        public string Depto { get => depto; set => depto = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int CodPostal { get => codPostal; set => codPostal = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Email { get => email; set => email = value; }



        #endregion

        #region METODOS 
        public DataTable ConsultarEstudiante()
        {
            sentencia = "SELECT * FROM Personas";
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = sentencia;
            Comando.CommandTimeout = 15;
            leer = Comando.ExecuteReader();
            DT.Load(leer);
            if (DT.Rows.Count == 0) throw new Exception("LA BUSQUEDA NO ARROJÓ RESULTADOS\n\n");
            Desconectar();
            return DT;
        }

        public void AgregarEstudiante()
        {
            sentencia = "INSERT INTO Personas (IDPersona, Rol, Legajo, Nombre, Apelllido, FechaNac, Documento, " +
                "TipoDoc,CUIL,Telefono,Calle,Numero,Piso,Departamento, Localidad, CP, Provincia) " +
                "VALUES (NULL, 'Alumno'," + Legajo + ",'" + Nombre + "','" + Apellido + "','" + FechaNac + "','" + Documento + "'," +
                "'" + TipoDoc + "'," + Cuil + ",'" + Telefono + "','" + Calle + "'," + NumeroCalle + ",'" +
                Piso +"','" + Depto + "','" + Localidad + "'," + CodPostal + ",'" + Provincia + "')";

            TransaccionSQLConectado(sentencia);
        }

        public void ModificarEstudiante()
        {
            sentencia = "UPDATE Personas SET " +
                "Legajo = " + Legajo + ", Nombre ='" + Nombre + "',Apellido = '" + Apellido + "',FechaNac = '" + FechaNac + "'," +
                "', Documento = '" + Documento + "',TipoDoc= '" + TipoDoc + "',CUIL = " + Cuil + ",Telefono = '" + Telefono + "'," +
                "Calle ='" + Calle + "',Numero = " + NumeroCalle + ", Piso = '" + Piso + "',Departamento = '" + Depto + "', Localidad = " +
                "'" + Localidad + "',CP = " + CodPostal + ", Provincia = '" + Provincia +"' WHERE IDPersona =" + IDPersona;

            TransaccionSQLConectado(sentencia);
        }

        public void EliminarEstudiante()
        {
            sentencia = "DELETE FROM Personas WHERE Id =" +IDPersona;
            TransaccionSQLConectado(sentencia);
        }
        private void TransaccionSQLConectado(string query)
        {
            //Método para realizar todas las consultas en modo conectado
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = query;
            Comando.ExecuteNonQuery();
            Desconectar();
        }

        #endregion
    }
}
