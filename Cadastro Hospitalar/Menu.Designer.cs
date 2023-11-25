namespace Cadastro_Hospitalar
{
    partial class Menu
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
            this.btnCadPacientes = new System.Windows.Forms.Button();
            this.btnCadHospital = new System.Windows.Forms.Button();
            this.btnCadDoutores = new System.Windows.Forms.Button();
            this.btnCadFuncionarios = new System.Windows.Forms.Button();
            this.btnAccConsultas = new System.Windows.Forms.Button();
            this.btnCadConsultas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadPacientes
            // 
            this.btnCadPacientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadPacientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadPacientes.Location = new System.Drawing.Point(55, 160);
            this.btnCadPacientes.Name = "btnCadPacientes";
            this.btnCadPacientes.Size = new System.Drawing.Size(164, 38);
            this.btnCadPacientes.TabIndex = 1;
            this.btnCadPacientes.Text = "Cadastrar Pacientes";
            this.btnCadPacientes.UseVisualStyleBackColor = false;
            this.btnCadPacientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadHospital
            // 
            this.btnCadHospital.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadHospital.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadHospital.Location = new System.Drawing.Point(55, 204);
            this.btnCadHospital.Name = "btnCadHospital";
            this.btnCadHospital.Size = new System.Drawing.Size(164, 40);
            this.btnCadHospital.TabIndex = 2;
            this.btnCadHospital.Text = "Cadastrar Unidades Hospitalares";
            this.btnCadHospital.UseVisualStyleBackColor = false;
            this.btnCadHospital.Click += new System.EventHandler(this.btnCadHospital_Click);
            // 
            // btnCadDoutores
            // 
            this.btnCadDoutores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadDoutores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadDoutores.Location = new System.Drawing.Point(55, 116);
            this.btnCadDoutores.Name = "btnCadDoutores";
            this.btnCadDoutores.Size = new System.Drawing.Size(164, 38);
            this.btnCadDoutores.TabIndex = 3;
            this.btnCadDoutores.Text = "Cadastrar Doutores";
            this.btnCadDoutores.UseVisualStyleBackColor = false;
            this.btnCadDoutores.Click += new System.EventHandler(this.btnCadDoutores_Click);
            // 
            // btnCadFuncionarios
            // 
            this.btnCadFuncionarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadFuncionarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadFuncionarios.Location = new System.Drawing.Point(55, 72);
            this.btnCadFuncionarios.Name = "btnCadFuncionarios";
            this.btnCadFuncionarios.Size = new System.Drawing.Size(164, 38);
            this.btnCadFuncionarios.TabIndex = 4;
            this.btnCadFuncionarios.Text = "Cadastrar Funcionarios";
            this.btnCadFuncionarios.UseVisualStyleBackColor = false;
            this.btnCadFuncionarios.Click += new System.EventHandler(this.btnCadFuncionarios_Click);
            // 
            // btnAccConsultas
            // 
            this.btnAccConsultas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAccConsultas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccConsultas.Location = new System.Drawing.Point(55, 287);
            this.btnAccConsultas.Name = "btnAccConsultas";
            this.btnAccConsultas.Size = new System.Drawing.Size(164, 38);
            this.btnAccConsultas.TabIndex = 5;
            this.btnAccConsultas.Text = "Consultar cadastros";
            this.btnAccConsultas.UseVisualStyleBackColor = false;
            this.btnAccConsultas.Click += new System.EventHandler(this.btnAccConsultas_Click);
            // 
            // btnCadConsultas
            // 
            this.btnCadConsultas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadConsultas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadConsultas.Location = new System.Drawing.Point(55, 28);
            this.btnCadConsultas.Name = "btnCadConsultas";
            this.btnCadConsultas.Size = new System.Drawing.Size(164, 38);
            this.btnCadConsultas.TabIndex = 6;
            this.btnCadConsultas.Text = "Cadastrar Consultas";
            this.btnCadConsultas.UseVisualStyleBackColor = false;
            this.btnCadConsultas.Click += new System.EventHandler(this.btnCadConsultas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Location = new System.Drawing.Point(190, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadConsultas);
            this.Controls.Add(this.btnAccConsultas);
            this.Controls.Add(this.btnCadFuncionarios);
            this.Controls.Add(this.btnCadDoutores);
            this.Controls.Add(this.btnCadHospital);
            this.Controls.Add(this.btnCadPacientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCadPacientes;
        private Button btnCadHospital;
        private Button btnCadDoutores;
        private Button btnCadFuncionarios;
        private Button btnAccConsultas;
        private Button btnCadConsultas;
        private Button button1;
    }
}