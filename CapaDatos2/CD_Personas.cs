using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Personas : CD_Conexion 
    {

        private CD_EjecuatarTransaccion Transaccion = new CD_EjecuatarTransaccion();
        private DataTable DT = new DataTable();

        #region ATRIBUTOS
        private int idpersona, legajo, cuil, codPostal, tipoDoc, idlocalidad, idprovincia, numeroCalle;
        private string nombre, apellido, fechaNac, documento, telefono, calle, piso, depto, email, sentencia, mensajeOk;
        #endregion
        #region PROPIERTIES
        public int IdPersona { get => idpersona; set => idpersona = value; }
        public int IdLocalidad { get => idlocalidad; set => idlocalidad = value; }
        public int IdProvincia { get => idprovincia; set => idprovincia = value; }
        public int CodPostal { get => codPostal; set => codPostal = value; }
        public int TipoDoc { get => tipoDoc; set => tipoDoc = value; }
        public int Cuil { get => cuil; set => cuil = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public int NumeroCalle { get => numeroCalle; set => numeroCalle = value; }
        public string Piso { get => piso; set => piso = value; }
        public string Depto { get => depto; set => depto = value; }
        public string Email { get => email; set => email = value; }

        #endregion

        #region METODOS 
        public DataTable ConsultarPersona(int rol, string busqueda)
        {
            DT.Clear();
            if (busqueda != "") sentencia = $"SELECT * FROM personas WHERE (Nombre LIKE '%{busqueda}%'" +
                    $" OR Apellido LIKE '%{busqueda}%' OR Documento LIKE '%{busqueda}%' OR Legajo LIKE '%{busqueda}%');";
           else sentencia = $"SELECT * FROM Personas WHERE IDRol = {rol};";

            DT = Transaccion.ModoConectado(sentencia);
            return DT;
        }

        public void AgregarPersona(string rol)
        {
            sentencia = "INSERT INTO Personas (IDPersona, IDRol, Legajo, Nombre, Apelllido, FechaNac, Documento, " +
                "TipoDoc,CUIL,Telefono,Calle,Numero,Piso,Departamento, IDLocalidad, CP, IDProvincia) " +
                $"VALUES (NULL, 1,{Legajo},{Nombre},{Apellido}, {FechaNac},{Documento},{TipoDoc},{Cuil},{Telefono}, {Calle}, {NumeroCalle} +" +
                $", {Piso}, {Depto},{IdLocalidad},{CodPostal}, {IdProvincia});";
           
            Transaccion.ModoDesconectado(sentencia);
        }

        public void ModificarPersona(string rol)
        {
            sentencia = "UPDATE Personas SET " +
                "Legajo = " + Legajo + ", Nombre ='" + Nombre + "',Apellido = '" + Apellido + "',FechaNac = '" + FechaNac + "'," +
                "', Documento = '" + Documento + "',TipoDoc= '" + TipoDoc + "',CUIL = " + Cuil + ",Telefono = '" + Telefono + "'," +
                "Calle ='" + Calle + "',Numero = " + NumeroCalle + ", Piso = '" + Piso + "',Departamento = '" + Depto + "', Localidad = " +
                "'" + IdLocalidad + "',CP = " + CodPostal + ", Provincia = '" + IdProvincia +"' WHERE IDPersona =" + IdPersona;

            Transaccion.ModoDesconectado(sentencia);
        }

        public void EliminarPersona(string rol)
        {
            sentencia = "DELETE FROM Personas WHERE Id =" +IdPersona;
            Transaccion.ModoDesconectado(sentencia);
        }


        #endregion
    }
}
