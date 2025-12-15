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
    public partial class Forms_Docente : Form
    {
        int numTareas = 0;
        int numExams = 0;
        internal Forms_Docente(Docente docenteactual)
        {
            InitializeComponent();

            Docente DocenteActual = docenteactual;
            label_Info.Text = $"Bienvenido {DocenteActual.Nombre}!\nNúmero de Empleado: {DocenteActual.NumeroEmpleado}\nMateria: {DocenteActual.Materia}";
            foreach (var alumno in Form1.alumnos)
            {
                combo_Alumnos.Items.Add(alumno.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void btn_AsignTarea_Click(object sender, EventArgs e)
        {
            numTareas++;
            DataGridViewTextBoxColumn actividadColumn = new DataGridViewTextBoxColumn();
            actividadColumn.HeaderText = $"Actividad {numTareas}";
            actividadColumn.Name = $"Actividad {numTareas}";
            actividadColumn.ValueType = typeof(double);
            dataGridView_Actividades.Columns.Insert(dataGridView_Actividades.ColumnCount - 1, actividadColumn);
        }
        private void btn_AsignExam_Click(object sender, EventArgs e)
        {
            numExams++;
            DataGridViewTextBoxColumn examColumn = new DataGridViewTextBoxColumn();
            examColumn.HeaderText = $"Examen {numExams}";
            examColumn.Name = $"Examen {numExams}";
            examColumn.ValueType = typeof(double);
            dataGridView_Actividades.Columns.Insert(dataGridView_Actividades.ColumnCount - 1, examColumn);
        }
        private void btn_AddAlumno_Click(object sender, EventArgs e)
        {
            if (combo_Alumnos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dataGridView_Actividades.Rows)
            {
                if (row.Cells["nombreAlumno"].Value != null && row.Cells["nombreAlumno"].Value.ToString() == combo_Alumnos.SelectedItem.ToString())
                {
                    MessageBox.Show("El alumno ya ha sido agregado a la lista de actividades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dataGridView_Actividades.Rows.Add(combo_Alumnos.Text);
        }

        private void combo_Alumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Actividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView_Actividades_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                double result;
                if (!double.TryParse(e.FormattedValue.ToString(), out result) || result < 0 || result > 10)
                {
                    e.Cancel = true;
                    dataGridView_Actividades.Rows[e.RowIndex].ErrorText = "Ingresa un valor valido entre 0 y 10 porfavor";
                }
            }
        }
        private void dataGridView_Actividades_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Actividades.Rows[e.RowIndex].ErrorText = null;
        }
        private void dataGridView_Actividades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void nUpD_Valor_act_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nUpD_Valor_Exam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_CalcularP_Click(object sender, EventArgs e)
        {
            CalcularPromedio();
        }
        private void CalcularPromedio()
        {
            int lastCol = dataGridView_Actividades.Columns.Count - 1;

            double pesoAct = (double)nUpD_Valor_act.Value / 100;   // cambiar si ya es fracción
            double pesoExam = (double)nUpD_Valor_Exam.Value / 100; // cambiar si ya es fracción

            foreach (DataGridViewRow row in dataGridView_Actividades.Rows)
            {
                if (row.IsNewRow) continue;

                double sumaAct = 0;
                double sumaExam = 0;
                double cantidadAct = 0;
                double cantidadExam = 0;
                for (int c = 0; c < dataGridView_Actividades.Columns.Count; c++)
                {
                    var col = dataGridView_Actividades.Columns[c];
                    if (col.Name == "calificacion_final") continue;

                    var cell = row.Cells[c];
                    if (cell?.Value == null) continue;

                    if (!double.TryParse(cell.Value.ToString(), out double val)) continue;

                    if (col.Name.Contains("Actividad"))
                    {
                        sumaAct += val;
                        cantidadAct++;
                    }

                    else if (col.Name.Contains("Examen"))
                    {
                        sumaExam += val;
                        cantidadExam++;
                    }
                }

                double promedio = (sumaAct * pesoAct) / cantidadAct + (sumaExam * pesoExam) / cantidadExam;
                row.Cells[lastCol].Value = promedio;
            }
        }

        
    }
}

