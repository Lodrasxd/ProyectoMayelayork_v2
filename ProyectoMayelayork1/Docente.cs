using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMayelayork1
{
    internal class Docente : Usuario
    {
        public string NumeroEmpleado { get; set; }
        public string Materia { get; set; } 

        public Docente ()
        {
            NumeroEmpleado = string.Empty;
            Materia = string.Empty
        }
        public Docente (string numeroEmpleado, stringg materia)
        {
            NumeroEmpleado = numeroEmpleado;
            Materia = materia;
        }
    }
}
