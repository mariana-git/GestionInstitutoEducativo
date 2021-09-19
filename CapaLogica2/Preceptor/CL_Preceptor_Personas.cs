using System;
using System.Data;

namespace CapaLogica.Preceptor
{
    class CL_Preceptor_Personas
    {
        #region ATRIBUTOS
        private int legajo, cuil, codPsotal;
        private string nombre, apellido, fechaNac,documento, tipodoc, telefono, calle, numeroCalle, piso, depto, localidad, provincia, email;
        #endregion
        #region PROPIERTIES
        public int Legajo { get => legajo; set => legajo = value; }
        public int Cuil { get => cuil; set => cuil = value; }
        public int CodPsotal { get => codPsotal; set => codPsotal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Tipodoc { get => tipodoc; set => tipodoc = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public string NumeroCalle { get => numeroCalle; set => numeroCalle = value; }
        public string Piso { get => piso; set => piso = value; }
        public string Depto { get => depto; set => depto = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Email { get => email; set => email = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        #endregion


    }
}
