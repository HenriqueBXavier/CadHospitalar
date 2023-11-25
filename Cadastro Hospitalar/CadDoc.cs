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
    public partial class CadDoc : Form
    {
        public CadDoc()
        {
            InitializeComponent();
            CarregarHospitais();
        }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        private void CarregarHospitais()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Conexao.StrCon))
                {
                    con.Open();

                    string query = "SELECT idhospital, local_unidade FROM dbo.hospitais";

                    using (SqlCommand command = new SqlCommand(query, con))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idhospital = reader.GetInt32(0);
                            string local_unidade = reader.GetString(1);
                            string itemText = $"{idhospital}: {local_unidade}";

                            ComboBoxHos.Items.Add(itemText);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível se conectar ao banco de dados" + ex.Message);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cnn = new SqlConnection(Conexao.StrCon))
                {
                    cnn.Open();

                    string NomeDoutor = textBox1.Text;
                    string Doutorado = textBox2.Text;
                    string TelefoneDoutor = textBox4.Text;

                    if (ComboBoxHos.Text == "" || textBox3.Text == "" || NomeDoutor == "" || Doutorado == "" || TelefoneDoutor == "")
                    {
                        MessageBox.Show("Digite um valor válido.");
                    }
                    else
                    {

                        double Salario = double.Parse(textBox3.Text);

                        var selectedHos = ComboBoxHos.SelectedItem as string;
                        int idhospital = int.Parse(selectedHos?.Split(':')[0] ?? "0");

                        var sqlQuery = "INSERT INTO doutores (nomedoutor, doutorado, salario, telefone_doc, id_hospital) " +
                            "VALUES (@nomedoutor, @doutorado, @salario, @telefone_doc, @idhospital);";

                        using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                        {
                            cmd.Parameters.AddWithValue("@nomedoutor", NomeDoutor);
                            cmd.Parameters.AddWithValue("@doutorado", Doutorado);
                            cmd.Parameters.AddWithValue("@salario", Salario);
                            cmd.Parameters.AddWithValue("@telefone_doc", TelefoneDoutor);
                            cmd.Parameters.AddWithValue("@idhospital", idhospital);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Doutor cadastrado com sucesso!");
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

        private void CadDoc_Load(object sender, EventArgs e)
        {

        }
    }
}
