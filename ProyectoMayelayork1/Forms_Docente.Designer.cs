namespace ProyectoMayelayork1
{
    partial class Forms_Docente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Cerrar = new Button();
            label_Info = new Label();
            btn_AsignTarea = new Button();
            btn_AsignExam = new Button();
            dataGridView_Actividades = new DataGridView();
            nombreAlumno = new DataGridViewTextBoxColumn();
            calificacion_final = new DataGridViewTextBoxColumn();
            combo_Alumnos = new ComboBox();
            btn_AddAlumno = new Button();
            nUpD_Valor_act = new NumericUpDown();
            nUpD_Valor_Exam = new NumericUpDown();
            label_Valor_act = new Label();
            label_Valor_examen = new Label();
            btn_CalcularP = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Actividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpD_Valor_act).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUpD_Valor_Exam).BeginInit();
            SuspendLayout();
            // 
            // button_Cerrar
            // 
            button_Cerrar.Location = new Point(1098, 543);
            button_Cerrar.Name = "button_Cerrar";
            button_Cerrar.Size = new Size(75, 55);
            button_Cerrar.TabIndex = 0;
            button_Cerrar.Text = "Cerrar";
            button_Cerrar.UseVisualStyleBackColor = true;
            button_Cerrar.Click += button1_Click;
            // 
            // label_Info
            // 
            label_Info.AutoSize = true;
            label_Info.Location = new Point(100, 36);
            label_Info.Name = "label_Info";
            label_Info.Size = new Size(38, 15);
            label_Info.TabIndex = 1;
            label_Info.Text = "label1";
            // 
            // btn_AsignTarea
            // 
            btn_AsignTarea.Location = new Point(100, 472);
            btn_AsignTarea.Name = "btn_AsignTarea";
            btn_AsignTarea.Size = new Size(92, 70);
            btn_AsignTarea.TabIndex = 2;
            btn_AsignTarea.Text = "Asignar nueva actividad";
            btn_AsignTarea.UseVisualStyleBackColor = true;
            btn_AsignTarea.Click += btn_AsignTarea_Click;
            // 
            // btn_AsignExam
            // 
            btn_AsignExam.Location = new Point(198, 472);
            btn_AsignExam.Name = "btn_AsignExam";
            btn_AsignExam.Size = new Size(98, 70);
            btn_AsignExam.TabIndex = 3;
            btn_AsignExam.Text = "Asignar nuevo examen";
            btn_AsignExam.UseVisualStyleBackColor = true;
            btn_AsignExam.Click += btn_AsignExam_Click;
            // 
            // dataGridView_Actividades
            // 
            dataGridView_Actividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Actividades.Columns.AddRange(new DataGridViewColumn[] { nombreAlumno, calificacion_final });
            dataGridView_Actividades.Location = new Point(100, 135);
            dataGridView_Actividades.Name = "dataGridView_Actividades";
            dataGridView_Actividades.Size = new Size(1019, 331);
            dataGridView_Actividades.TabIndex = 4;
            dataGridView_Actividades.CellContentClick += dataGridView_Actividades_CellContentClick;
            dataGridView_Actividades.CellValidated += dataGridView_Actividades_CellValidated;
            dataGridView_Actividades.CellValidating += dataGridView_Actividades_CellValidating;
            // 
            // nombreAlumno
            // 
            nombreAlumno.HeaderText = "Alumno";
            nombreAlumno.Name = "nombreAlumno";
            nombreAlumno.ReadOnly = true;
            // 
            // calificacion_final
            // 
            calificacion_final.HeaderText = "Calificacion final";
            calificacion_final.Name = "calificacion_final";
            calificacion_final.ReadOnly = true;
            // 
            // combo_Alumnos
            // 
            combo_Alumnos.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Alumnos.FormattingEnabled = true;
            combo_Alumnos.Location = new Point(391, 719);
            combo_Alumnos.Name = "combo_Alumnos";
            combo_Alumnos.Size = new Size(201, 23);
            combo_Alumnos.TabIndex = 5;
            combo_Alumnos.SelectedIndexChanged += combo_Alumnos_SelectedIndexChanged;
            // 
            // btn_AddAlumno
            // 
            btn_AddAlumno.Location = new Point(282, 719);
            btn_AddAlumno.Name = "btn_AddAlumno";
            btn_AddAlumno.Size = new Size(75, 45);
            btn_AddAlumno.TabIndex = 6;
            btn_AddAlumno.Text = "Agregar alumno";
            btn_AddAlumno.UseVisualStyleBackColor = true;
            btn_AddAlumno.Click += btn_AddAlumno_Click;
            // 
            // nUpD_Valor_act
            // 
            nUpD_Valor_act.Location = new Point(198, 561);
            nUpD_Valor_act.Name = "nUpD_Valor_act";
            nUpD_Valor_act.Size = new Size(55, 23);
            nUpD_Valor_act.TabIndex = 7;
            nUpD_Valor_act.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nUpD_Valor_act.ValueChanged += nUpD_Valor_act_ValueChanged;
            // 
            // nUpD_Valor_Exam
            // 
            nUpD_Valor_Exam.Location = new Point(198, 590);
            nUpD_Valor_Exam.Name = "nUpD_Valor_Exam";
            nUpD_Valor_Exam.Size = new Size(55, 23);
            nUpD_Valor_Exam.TabIndex = 8;
            nUpD_Valor_Exam.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nUpD_Valor_Exam.ValueChanged += nUpD_Valor_Exam_ValueChanged;
            // 
            // label_Valor_act
            // 
            label_Valor_act.AutoSize = true;
            label_Valor_act.Location = new Point(64, 563);
            label_Valor_act.Name = "label_Valor_act";
            label_Valor_act.Size = new Size(128, 15);
            label_Valor_act.TabIndex = 9;
            label_Valor_act.Text = "Valor de las actividades";
            // 
            // label_Valor_examen
            // 
            label_Valor_examen.AutoSize = true;
            label_Valor_examen.Location = new Point(95, 592);
            label_Valor_examen.Name = "label_Valor_examen";
            label_Valor_examen.Size = new Size(97, 15);
            label_Valor_examen.TabIndex = 10;
            label_Valor_examen.Text = "Valor del examen";
            // 
            // btn_CalcularP
            // 
            btn_CalcularP.Location = new Point(969, 479);
            btn_CalcularP.Name = "btn_CalcularP";
            btn_CalcularP.Size = new Size(75, 63);
            btn_CalcularP.TabIndex = 11;
            btn_CalcularP.Text = "Calcular promedios";
            btn_CalcularP.UseVisualStyleBackColor = true;
            btn_CalcularP.Click += btn_CalcularP_Click;
            // 
            // Forms_Docente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 831);
            Controls.Add(btn_CalcularP);
            Controls.Add(label_Valor_examen);
            Controls.Add(label_Valor_act);
            Controls.Add(nUpD_Valor_Exam);
            Controls.Add(nUpD_Valor_act);
            Controls.Add(btn_AddAlumno);
            Controls.Add(combo_Alumnos);
            Controls.Add(dataGridView_Actividades);
            Controls.Add(btn_AsignExam);
            Controls.Add(btn_AsignTarea);
            Controls.Add(label_Info);
            Controls.Add(button_Cerrar);
            Name = "Forms_Docente";
            Text = "Forms_Docente";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Actividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpD_Valor_act).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUpD_Valor_Exam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Cerrar;
        private Label label_Info;
        private Button btn_AsignTarea;
        private Button btn_AsignExam;
        private DataGridView dataGridView_Actividades;
        private DataGridViewTextBoxColumn nombreAlumno;
        private ComboBox combo_Alumnos;
        private Button btn_AddAlumno;
        private DataGridViewTextBoxColumn calificacion_final;
        private NumericUpDown nUpD_Valor_act;
        private NumericUpDown nUpD_Valor_Exam;
        private Label label_Valor_act;
        private Label label_Valor_examen;
        private Button btn_CalcularP;
    }
}