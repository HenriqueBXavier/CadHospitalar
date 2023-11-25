using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Hospitalar
{
    public partial class CadPac : Form
    {
        public CadPac()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(Conexao.StrCon))
                {
                    cnn.Open();

                    string nome = textBox1.Text;
                    string CPF = textBox2.Text;
                    string idade = textBox3.Text;
                    string respons1 = textBox4.Text;
                    string respons2 = textBox5.Text;
                    string telefone_paciente = textBox6.Text;
                    string telefone_respons1 = textBox7.Text;
                    string telefone_respons2 = textBox8.Text;
                    string alergias = textBox9.Text;
                    string cirurgias = textBox10.Text;

                    if (nome == "" || CPF == "" || idade == "" || respons1 == "" || telefone_paciente == "" || telefone_respons1 == "")
                    {
                        MessageBox.Show("Digite um valor válido.");
                    } else {

                        var sqlQuery = "insert into pacientes (nome, CPF, idade, respons1, respons2, telefone_paciente, telefone_respons1, telefone_respons2, alergias, cirurgias)" +
                    " values (@nome, @CPF, @idade, @respons1, @respons2, @telefone_paciente, @telefone_respons1, @telefone_respons2, @alergias, @cirurgias)";

                        using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                        {
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@CPF", CPF);
                            cmd.Parameters.AddWithValue("@idade", idade);
                            cmd.Parameters.AddWithValue("@respons1", respons1);
                            cmd.Parameters.AddWithValue("@respons2", respons2);
                            cmd.Parameters.AddWithValue("@telefone_paciente", telefone_paciente);
                            cmd.Parameters.AddWithValue("@telefone_respons1", telefone_respons1);
                            cmd.Parameters.AddWithValue("@telefone_respons2", telefone_respons2);
                            cmd.Parameters.AddWithValue("@cirurgias", cirurgias);
                            cmd.Parameters.AddWithValue("@alergias", alergias);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Paciente cadastrado com sucesso!");
                        cnn.Close();
                    }
                }
            } // FIM IF
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados" + ex.Message);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        
    }
 }


