using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMayelayork1
{
    internal class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public Usuario? ()
        {
            Nombre = this.Nombre;
            Correo = this.Correo;
            Contraseña = this.Contraseña;
        }
        public Usuario? (string nombre, string correo, string contraseña)
        {
            Nombre = nombre;
            Correo = correo;
            Contraseña = contraseña;
            
        }
    }
}
