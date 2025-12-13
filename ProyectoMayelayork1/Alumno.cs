using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMayelayork1
{
    internal class Alumno : Usuario
    {
        public string Matricula { get; }
        public string Carrera { get; }
        public string Semestre { get; }
    }
}
