namespace Cadastro_Hospitalar
{
    partial class AcessarConsultas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnApagar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbxBuscarPAC = new System.Windows.Forms.ComboBox();
            this.cbxBuscarDOC = new System.Windows.Forms.ComboBox();
            this.cbxBuscarFUNC = new System.Windows.Forms.ComboBox();
            this.cbxBuscarCONS = new System.Windows.Forms.ComboBox();
            this.cbxBuscarHOS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar todos os resultados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 221);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pacientes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Doutores";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 19);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Funcionarios";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 97);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 19);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "Hospitais";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(25, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um grupo para consulta.";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(5, 122);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(77, 19);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.Text = "Consultas";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(442, 440);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 9;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Filtrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(825, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbxBuscarPAC
            // 
            this.cbxBuscarPAC.FormattingEnabled = true;
            this.cbxBuscarPAC.Items.AddRange(new object[] {
            "nome",
            "CPF",
            "idpaciente"});
            this.cbxBuscarPAC.Location = new System.Drawing.Point(624, 312);
            this.cbxBuscarPAC.Name = "cbxBuscarPAC";
            this.cbxBuscarPAC.Size = new System.Drawing.Size(121, 23);
            this.cbxBuscarPAC.TabIndex = 13;
            // 
            // cbxBuscarDOC
            // 
            this.cbxBuscarDOC.FormattingEnabled = true;
            this.cbxBuscarDOC.Items.AddRange(new object[] {
            "nomedoutor",
            "doutorado",
            "iddoutor"});
            this.cbxBuscarDOC.Location = new System.Drawing.Point(624, 312);
            this.cbxBuscarDOC.Name = "cbxBuscarDOC";
            this.cbxBuscarDOC.Size = new System.Drawing.Size(121, 23);
            this.cbxBuscarDOC.TabIndex = 14;
            this.cbxBuscarDOC.Visible = false;
            // 
            // cbxBuscarFUNC
            // 
            this.cbxBuscarFUNC.FormattingEnabled = true;
            this.cbxBuscarFUNC.Items.AddRange(new object[] {
            "nomefunc",
            "CPFfunc",
            "cargo",
            "idfuncionario"});
            this.cbxBuscarFUNC.Location = new System.Drawing.Point(624, 312);
            this.cbxBuscarFUNC.Name = "cbxBuscarFUNC";
            this.cbxBuscarFUNC.Size = new System.Drawing.Size(121, 23);
            this.cbxBuscarFUNC.TabIndex = 15;
            this.cbxBuscarFUNC.Visible = false;
            // 
            // cbxBuscarCONS
            // 
            this.cbxBuscarCONS.FormattingEnabled = true;
            this.cbxBuscarCONS.Items.AddRange(new object[] {
            "idconsulta",
            "data_exame",
            "tipo_exame",
            "id_paciente"});
            this.cbxBuscarCONS.Location = new System.Drawing.Point(624, 312);
            this.cbxBuscarCONS.Name = "cbxBuscarCONS";
            this.cbxBuscarCONS.Size = new System.Drawing.Size(121, 23);
            this.cbxBuscarCONS.TabIndex = 16;
            this.cbxBuscarCONS.Visible = false;
            // 
            // cbxBuscarHOS
            // 
            this.cbxBuscarHOS.FormattingEnabled = true;
            this.cbxBuscarHOS.Items.AddRange(new object[] {
            "idhospital",
            "local_unidade"});
            this.cbxBuscarHOS.Location = new System.Drawing.Point(624, 312);
            this.cbxBuscarHOS.Name = "cbxBuscarHOS";
            this.cbxBuscarHOS.Size = new System.Drawing.Size(121, 23);
            this.cbxBuscarHOS.TabIndex = 17;
            this.cbxBuscarHOS.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(650, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtrar por...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(327, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Insira o dado aqui. (Ex.  1, filtro escolhido: idpaciente).\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Alterar item selecionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AcessarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(924, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbxBuscarHOS);
            this.Controls.Add(this.cbxBuscarCONS);
            this.Controls.Add(this.cbxBuscarFUNC);
            this.Controls.Add(this.cbxBuscarDOC);
            this.Controls.Add(this.cbxBuscarPAC);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "AcessarConsultas";
            this.Text = "AcessarConsultas";
            this.Load += new System.EventHandler(this.AcessarConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private Button btnApagar;
        private RadioButton radioButton5;
        private Button button3;
        private Button button4;
        private ComboBox cbxBuscarPAC;
        private ComboBox cbxBuscarDOC;
        private ComboBox cbxBuscarFUNC;
        private ComboBox cbxBuscarCONS;
        private ComboBox cbxBuscarHOS;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}