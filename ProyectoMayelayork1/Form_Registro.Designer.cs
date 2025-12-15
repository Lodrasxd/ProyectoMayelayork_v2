namespace ProyectoMayelayork1
{
    partial class Form_Registro
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
            btn_Registrar_registro = new Button();
            btn_Cancelar_registro = new Button();
            combo_UserType_registro = new ComboBox();
            txt_User_registro = new TextBox();
            txt_Passw_registro = new TextBox();
            label_User_registro = new Label();
            label_Passw_registro = new Label();
            label_Permisos_registro = new Label();
            label_Nombre_registro = new Label();
            txt_Nombre_registro = new TextBox();
            txt_Opcion1 = new TextBox();
            label_Opcion1 = new Label();
            label_Opcion2 = new Label();
            label_Opcion3 = new Label();
            comboBox_Opcion2 = new ComboBox();
            comboBox_Opcion3 = new ComboBox();
            SuspendLayout();
            // 
            // btn_Registrar_registro
            // 
            btn_Registrar_registro.Location = new Point(235, 369);
            btn_Registrar_registro.Name = "btn_Registrar_registro";
            btn_Registrar_registro.Size = new Size(75, 23);
            btn_Registrar_registro.TabIndex = 0;
            btn_Registrar_registro.Text = "Registrar";
            btn_Registrar_registro.UseVisualStyleBackColor = true;
            btn_Registrar_registro.Click += btn_Registrar_registro_Click;
            // 
            // btn_Cancelar_registro
            // 
            btn_Cancelar_registro.Location = new Point(410, 369);
            btn_Cancelar_registro.Name = "btn_Cancelar_registro";
            btn_Cancelar_registro.Size = new Size(75, 23);
            btn_Cancelar_registro.TabIndex = 1;
            btn_Cancelar_registro.Text = "Cancelar";
            btn_Cancelar_registro.UseVisualStyleBackColor = true;
            btn_Cancelar_registro.Click += btn_Cancelar_registro_Click;
            // 
            // combo_UserType_registro
            // 
            combo_UserType_registro.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_UserType_registro.FormattingEnabled = true;
            combo_UserType_registro.Items.AddRange(new object[] { "Alumno", "Docente" });
            combo_UserType_registro.Location = new Point(235, 160);
            combo_UserType_registro.Name = "combo_UserType_registro";
            combo_UserType_registro.Size = new Size(250, 23);
            combo_UserType_registro.TabIndex = 2;
            combo_UserType_registro.SelectedIndexChanged += combo_UserType_registro_SelectedIndexChanged;
            // 
            // txt_User_registro
            // 
            txt_User_registro.Location = new Point(235, 92);
            txt_User_registro.Name = "txt_User_registro";
            txt_User_registro.Size = new Size(250, 23);
            txt_User_registro.TabIndex = 3;
            // 
            // txt_Passw_registro
            // 
            txt_Passw_registro.Location = new Point(235, 121);
            txt_Passw_registro.Name = "txt_Passw_registro";
            txt_Passw_registro.Size = new Size(250, 23);
            txt_Passw_registro.TabIndex = 4;
            // 
            // label_User_registro
            // 
            label_User_registro.AutoSize = true;
            label_User_registro.Location = new Point(84, 95);
            label_User_registro.Name = "label_User_registro";
            label_User_registro.Size = new Size(43, 15);
            label_User_registro.TabIndex = 5;
            label_User_registro.Text = "Correo";
            // 
            // label_Passw_registro
            // 
            label_Passw_registro.AutoSize = true;
            label_Passw_registro.Location = new Point(84, 124);
            label_Passw_registro.Name = "label_Passw_registro";
            label_Passw_registro.Size = new Size(67, 15);
            label_Passw_registro.TabIndex = 6;
            label_Passw_registro.Text = "Contraseña";
            // 
            // label_Permisos_registro
            // 
            label_Permisos_registro.AutoSize = true;
            label_Permisos_registro.Location = new Point(84, 163);
            label_Permisos_registro.Name = "label_Permisos_registro";
            label_Permisos_registro.Size = new Size(88, 15);
            label_Permisos_registro.TabIndex = 7;
            label_Permisos_registro.Text = "Tipo de usuario";
            // 
            // label_Nombre_registro
            // 
            label_Nombre_registro.AutoSize = true;
            label_Nombre_registro.Location = new Point(84, 66);
            label_Nombre_registro.Name = "label_Nombre_registro";
            label_Nombre_registro.Size = new Size(105, 15);
            label_Nombre_registro.TabIndex = 8;
            label_Nombre_registro.Text = "Nombre completo";
            // 
            // txt_Nombre_registro
            // 
            txt_Nombre_registro.Location = new Point(235, 63);
            txt_Nombre_registro.Name = "txt_Nombre_registro";
            txt_Nombre_registro.Size = new Size(250, 23);
            txt_Nombre_registro.TabIndex = 9;
            // 
            // txt_Opcion1
            // 
            txt_Opcion1.Location = new Point(235, 204);
            txt_Opcion1.Name = "txt_Opcion1";
            txt_Opcion1.Size = new Size(250, 23);
            txt_Opcion1.TabIndex = 10;
            txt_Opcion1.Visible = false;
            // 
            // label_Opcion1
            // 
            label_Opcion1.AutoSize = true;
            label_Opcion1.Location = new Point(84, 212);
            label_Opcion1.Name = "label_Opcion1";
            label_Opcion1.Size = new Size(38, 15);
            label_Opcion1.TabIndex = 11;
            label_Opcion1.Text = "label1";
            label_Opcion1.Visible = false;
            // 
            // label_Opcion2
            // 
            label_Opcion2.AutoSize = true;
            label_Opcion2.Location = new Point(84, 260);
            label_Opcion2.Name = "label_Opcion2";
            label_Opcion2.Size = new Size(38, 15);
            label_Opcion2.TabIndex = 14;
            label_Opcion2.Text = "label2";
            label_Opcion2.Visible = false;
            // 
            // label_Opcion3
            // 
            label_Opcion3.AutoSize = true;
            label_Opcion3.Location = new Point(84, 304);
            label_Opcion3.Name = "label_Opcion3";
            label_Opcion3.Size = new Size(38, 15);
            label_Opcion3.TabIndex = 15;
            label_Opcion3.Text = "label3";
            label_Opcion3.Visible = false;
            // 
            // comboBox_Opcion2
            // 
            comboBox_Opcion2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Opcion2.FormattingEnabled = true;
            comboBox_Opcion2.Location = new Point(235, 257);
            comboBox_Opcion2.Name = "comboBox_Opcion2";
            comboBox_Opcion2.Size = new Size(250, 23);
            comboBox_Opcion2.TabIndex = 16;
            comboBox_Opcion2.Visible = false;
            // 
            // comboBox_Opcion3
            // 
            comboBox_Opcion3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Opcion3.FormattingEnabled = true;
            comboBox_Opcion3.Location = new Point(235, 301);
            comboBox_Opcion3.Name = "comboBox_Opcion3";
            comboBox_Opcion3.Size = new Size(250, 23);
            comboBox_Opcion3.TabIndex = 17;
            comboBox_Opcion3.Visible = false;
            // 
            // Form_Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 552);
            Controls.Add(comboBox_Opcion3);
            Controls.Add(comboBox_Opcion2);
            Controls.Add(label_Opcion3);
            Controls.Add(label_Opcion2);
            Controls.Add(label_Opcion1);
            Controls.Add(txt_Opcion1);
            Controls.Add(txt_Nombre_registro);
            Controls.Add(label_Nombre_registro);
            Controls.Add(label_Permisos_registro);
            Controls.Add(label_Passw_registro);
            Controls.Add(label_User_registro);
            Controls.Add(txt_Passw_registro);
            Controls.Add(txt_User_registro);
            Controls.Add(combo_UserType_registro);
            Controls.Add(btn_Cancelar_registro);
            Controls.Add(btn_Registrar_registro);
            Name = "Form_Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Registrar_registro;
        private Button btn_Cancelar_registro;
        private ComboBox combo_UserType_registro;
        private TextBox txt_User_registro;
        private TextBox txt_Passw_registro;
        private Label label_User_registro;
        private Label label_Passw_registro;
        private Label label_Permisos_registro;
        private Label label_Nombre_registro;
        private TextBox txt_Nombre_registro;
        private TextBox txt_Opcion1;
        private Label label_Opcion1;
        private Label label_Opcion2;
        private Label label_Opcion3;
        private ComboBox comboBox_Opcion2;
        private ComboBox comboBox_Opcion3;
    }
}