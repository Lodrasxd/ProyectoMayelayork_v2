using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMayelayork1
{
    internal class Alumno : Usuario
    {
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public string Semestre { get; set; }

        public Alumno()
        {
              Matricula = string.Empty;
              Carrera = string.Empty;
              Semestre = string,Empty;
        }
        public (string matricula, string carrera, string semestre)
        {
              Matricula = matricula;
              Carrera = carrera;
              Semestre = semesstre;
        }
                public string MostrarMaterias()
        {
                       string Cadena = "";
                       return Cadena;
        }
        
    }
}
