using System.Collections.Generic;
namespace ProyectoMayelayork1
{
    public partial class Form1 : Form
    {
        internal static List<Alumno> alumnos = new List<Alumno>();
        internal static List<Docente> docentes = new List<Docente>();
        public Form1()
        {
            InitializeComponent();
            List<List<Usuario>> usuarios = new List<List<Usuario>>();
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

        private void link_CrearUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Registro form_Registro = new Form_Registro();
            form_Registro.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            foreach (var docente in docentes)
            {
                if (docente.Correo == txt_User.Text.ToLower() && docente.Contraseña == txt_Passw.Text)
                {

                    MessageBox.Show($"Bienvenido, {docente.Nombre}!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forms_Docente forms_Docente = new Forms_Docente(docente);
                    forms_Docente.Show();
                    this.Hide();
                    return;
                }
                foreach (var alumno in alumnos)
                {
                    if (alumno.Correo == txt_User.Text.ToLower() && alumno.Contraseña == txt_Passw.Text)
                    {
                        MessageBox.Show($"Bienvenido, {alumno.Nombre}!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }
            }
            MessageBox.Show("Credenciales incorrectas. Por favor, intente de nuevo.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = string.Join(", ", alumnos);
            MessageBox.Show(s,"Info alumnos", MessageBoxButtons.OK);
        }
    }
}
