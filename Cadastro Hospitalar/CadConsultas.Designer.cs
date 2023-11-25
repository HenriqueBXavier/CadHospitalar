namespace Cadastro_Hospitalar
{
    partial class CadConsultas
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            ComboBoxPac = new ComboBox();
            ComboBoxDoc = new ComboBox();
            ComboBoxHos = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(235, 181);
            button1.Name = "button1";
            button1.Size = new Size(99, 33);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(70, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Local do Hospital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(261, 25);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Doutor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(397, 25);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Paciente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(397, 104);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Data do Exame";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(76, 132);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(85, 104);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo de Exame";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(187, 132);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(201, 23);
            textBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(214, 104);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 11;
            label6.Text = "Condições para o Exame";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(407, 132);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(61, 23);
            maskedTextBox1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(247, 233);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ComboBoxPac
            // 
            ComboBoxPac.FormattingEnabled = true;
            ComboBoxPac.Location = new Point(354, 53);
            ComboBoxPac.Name = "ComboBoxPac";
            ComboBoxPac.Size = new Size(129, 23);
            ComboBoxPac.TabIndex = 15;
            // 
            // ComboBoxDoc
            // 
            ComboBoxDoc.FormattingEnabled = true;
            ComboBoxDoc.Location = new Point(218, 53);
            ComboBoxDoc.Name = "ComboBoxDoc";
            ComboBoxDoc.Size = new Size(130, 23);
            ComboBoxDoc.TabIndex = 16;
            // 
            // ComboBoxHos
            // 
            ComboBoxHos.FormattingEnabled = true;
            ComboBoxHos.Location = new Point(42, 53);
            ComboBoxHos.Name = "ComboBoxHos";
            ComboBoxHos.Size = new Size(164, 23);
            ComboBoxHos.TabIndex = 17;
            // 
            // CadConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(555, 268);
            Controls.Add(ComboBoxHos);
            Controls.Add(ComboBoxDoc);
            Controls.Add(ComboBoxPac);
            Controls.Add(button2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "CadConsultas";
            Text = "s";
            Load += CadConsultas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private ComboBox ComboBoxPac;
        private ComboBox ComboBoxDoc;
        private ComboBox ComboBoxHos;
    }
}