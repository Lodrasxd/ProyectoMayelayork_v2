using System.Collections.Generic;
namespace ProyectoMayelayork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<List<Usuario>> usuarios = new List<List<Usuario>>();
            List<Alumno> alumnos = new List<Alumno>();
            List<Docente> docentes = new List<Docente>();
            usuarios.Add(alumnos.Cast<Usuario>().ToList());
            usuarios.Add(docentes.Cast<Usuario>().ToList());
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void check_MostrarPassw_CheckedChanged(object sender, EventArgs e)
        {
            txt_Passw.PasswordChar = check_MostrarPassw.Checked ? '\0' : '*';
        }
    }
}
