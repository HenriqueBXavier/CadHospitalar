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
    public partial class CadUnidade : Form
    {
        public CadUnidade()
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

                    String local = textBox1.Text;

                    if (local == "")
                    {

                        MessageBox.Show("Digite um valor válido.");

                    }
                    else
                    {

                        var sqlQuery = "INSERT INTO hospitais (local_unidade)" +
                                    " VALUES (@local);";

                        using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                        {
                            cmd.Parameters.AddWithValue("@local", local);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Unidade Hospitalar cadastrada com sucesso!");
                        cnn.Close();
                    }
                }
            }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
