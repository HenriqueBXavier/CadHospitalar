namespace Cadastro_Hospitalar
{
    partial class CadFunc
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
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ComboBoxHos = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(240, 96);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 20;
            label5.Text = "Local da Unidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(147, 96);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 18;
            label4.Text = "Cargo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(100, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(122, 23);
            textBox4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(340, 36);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 16;
            label3.Text = "Idade";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 23);
            textBox3.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(214, 36);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 14;
            label2.Text = "CPF ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(46, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome do Funcionario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(186, 158);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 21;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(186, 199);
            button2.Name = "button2";
            button2.Size = new Size(88, 25);
            button2.TabIndex = 22;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ComboBoxHos
            // 
            ComboBoxHos.FormattingEnabled = true;
            ComboBoxHos.Location = new Point(228, 114);
            ComboBoxHos.Name = "ComboBoxHos";
            ComboBoxHos.Size = new Size(121, 23);
            ComboBoxHos.TabIndex = 23;
            // 
            // CadFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(492, 260);
            Controls.Add(ComboBoxHos);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "CadFunc";
            Text = "CadFunc";
            Load += CadFunc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ComboBox ComboBoxHos;
    }
}