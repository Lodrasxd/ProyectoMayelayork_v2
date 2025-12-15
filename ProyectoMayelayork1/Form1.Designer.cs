namespace ProyectoMayelayork1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_User = new TextBox();
            txt_Passw = new TextBox();
            label_User = new Label();
            label_Passw = new Label();
            check_MostrarPassw = new CheckBox();
            btn_Login = new Button();
            btn_Cancelar = new Button();
            link_CrearUser = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_User
            // 
            txt_User.Location = new Point(523, 130);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(240, 23);
            txt_User.TabIndex = 0;
            // 
            // txt_Passw
            // 
            txt_Passw.Location = new Point(524, 177);
            txt_Passw.Name = "txt_Passw";
            txt_Passw.PasswordChar = '*';
            txt_Passw.Size = new Size(239, 23);
            txt_Passw.TabIndex = 1;
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(431, 133);
            label_User.Name = "label_User";
            label_User.Size = new Size(43, 15);
            label_User.TabIndex = 2;
            label_User.Text = "Correo";
            // 
            // label_Passw
            // 
            label_Passw.AutoSize = true;
            label_Passw.Location = new Point(431, 180);
            label_Passw.Name = "label_Passw";
            label_Passw.Size = new Size(67, 15);
            label_Passw.TabIndex = 3;
            label_Passw.Text = "Contraseña";
            // 
            // check_MostrarPassw
            // 
            check_MostrarPassw.AutoSize = true;
            check_MostrarPassw.Location = new Point(524, 206);
            check_MostrarPassw.Name = "check_MostrarPassw";
            check_MostrarPassw.Size = new Size(128, 19);
            check_MostrarPassw.TabIndex = 4;
            check_MostrarPassw.Text = "Mostrar contraseña";
            check_MostrarPassw.UseVisualStyleBackColor = true;
            check_MostrarPassw.CheckedChanged += check_MostrarPassw_CheckedChanged;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(467, 252);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 23);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(548, 252);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(75, 23);
            btn_Cancelar.TabIndex = 6;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // link_CrearUser
            // 
            link_CrearUser.AutoSize = true;
            link_CrearUser.Location = new Point(57, 366);
            link_CrearUser.Name = "link_CrearUser";
            link_CrearUser.Size = new Size(183, 15);
            link_CrearUser.TabIndex = 7;
            link_CrearUser.TabStop = true;
            link_CrearUser.Text = "Click para crear un usuario nuevo";
            link_CrearUser.LinkClicked += link_CrearUser_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(381, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(link_CrearUser);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Login);
            Controls.Add(check_MostrarPassw);
            Controls.Add(label_Passw);
            Controls.Add(label_User);
            Controls.Add(txt_Passw);
            Controls.Add(txt_User);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_User;
        private TextBox txt_Passw;
        private Label label_User;
        private Label label_Passw;
        private CheckBox check_MostrarPassw;
        private Button btn_Login;
        private Button btn_Cancelar;
        private LinkLabel link_CrearUser;
        private Button button1;
    }
}
