using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMayelayork1
{
    public partial class Form_Registro : Form
    {
        public Form_Registro()
        {
            InitializeComponent();
        }
        private void btn_Cancelar_registro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_UserType_registro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            switch (combo_UserType_registro.SelectedItem.ToString())
            {
                case "Alumno":
                    comboBox_Opcion2.Items.Clear();
                    comboBox_Opcion3.Items.Clear();
                    comboBox_Opcion2.Items.AddRange(new string[] { "Ingeniería en Sistemas Computacionales", "Ingeniería Industrial", "Ingeniería en Mecatrónica", "Licenciatura en Administración", "Licenciatura en Contaduría" });
                    comboBox_Opcion3.Items.AddRange(new string[] { "1º Semestre", "2º Semestre", "3º Semestre", "4º Semestre", "5º Semestre", "6º Semestre", "7º Semestre", "8º Semestre", "9º Semestre", "10º Semestre" });
                    txt_Opcion1.Visible = true;
                    comboBox_Opcion2.Visible = true;
                    comboBox_Opcion3.Visible = true;
                    label_Opcion1.Text = "Matrícula:";
                    label_Opcion2.Text = "Carrera:";
                    label_Opcion3.Text = "Semestre:";
                    label_Opcion1.Visible = true;
                    label_Opcion2.Visible = true;
                    label_Opcion3.Visible = true;
                    break;
                case "Docente":
                    comboBox_Opcion2.Items.Clear();
                    comboBox_Opcion2.Items.AddRange(new string[] { "Matemáticas", "Física", "Química", "Programación", "Administración", "Contabilidad" });
                    txt_Opcion1.Visible = true;
                    comboBox_Opcion2.Visible = true;
                    comboBox_Opcion3.Visible = false;
                    label_Opcion1.Text = "Número de Empleado:";
                    label_Opcion2.Text = "Materia:";
                    label_Opcion1.Visible = true;
                    label_Opcion2.Visible = true;
                    label_Opcion3.Visible = false;
                    break;
                default:
                    label_Opcion1.Visible = false;
                    label_Opcion2.Visible = false;
                    label_Opcion3.Visible = false;
                    txt_Opcion1.Visible = false;
                    comboBox_Opcion2.Visible = false;
                    comboBox_Opcion3.Visible = false;
                    break;
            }
        }

        private void btn_Registrar_registro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre_registro.Text) ||
                string.IsNullOrWhiteSpace(txt_User_registro.Text) ||
                string.IsNullOrWhiteSpace(txt_Passw_registro.Text) ||
                combo_UserType_registro.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txt_Opcion1.Text) ||
                comboBox_Opcion2.SelectedItem == null ||
                (combo_UserType_registro.SelectedItem.ToString() == "Alumno" && comboBox_Opcion3.SelectedItem == null))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (combo_UserType_registro.SelectedItem.ToString())
            {
                case "Alumno":
                    Alumno nuevoAlumno = new Alumno
                    {
                        Nombre = txt_Nombre_registro.Text,
                        Correo = txt_User_registro.Text.ToLower(),
                        Contraseña = txt_Passw_registro.Text,
                        Matricula = txt_Opcion1.Text,
                        Carrera = comboBox_Opcion2.SelectedItem.ToString(),
                        Semestre = comboBox_Opcion3.SelectedItem.ToString()
                    };
                    
                    MessageBox.Show("Registro de alumno exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1.alumnos.Add(nuevoAlumno);
                    this.Close();
                    break;
                case "Docente":
                    Docente nuevoDocente = new Docente
                    {
                        Nombre = txt_Nombre_registro.Text,
                        Correo = txt_User_registro.Text.ToLower(),
                        Contraseña = txt_Passw_registro.Text,
                        NumeroEmpleado = txt_Opcion1.Text,
                        Materia = comboBox_Opcion2.SelectedItem.ToString()
                    };
                    
                    MessageBox.Show("Registro de docente exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1.docentes.Add(nuevoDocente);
                    this.Close();
                    break;
            }


        }
    }
}
