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
    public partial class CadFunc : Form
    {
        public CadFunc()
        {
            InitializeComponent();
            CarregarHospitais();
        }


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

                    string nomeFunc = textBox1.Text;
                    string CPFfunc = textBox2.Text;
                    string idade = textBox3.Text;
                    string cargo = textBox4.Text;

                    if (ComboBoxHos.Text == "")
                    {
                        MessageBox.Show("Digite um valor válido.");
                    }
                    else
                    {

                        var selectedHos = ComboBoxHos.SelectedItem as string;
                        int idhospital = int.Parse(selectedHos?.Split(':')[0] ?? "0");

                        if (nomeFunc == "" || CPFfunc == "" || idade == "" || cargo == "")
                        {
                            MessageBox.Show("Digite um valor válido.");
                        }


                        var sqlQuery = "INSERT INTO funcionarios (nomeFunc, CPFfunc, idade, cargo, id_hospital) " +
                            "VALUES (@nomeFunc, @CPFfunc, @idade, @cargo, @idhospital);";

                        using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                        {
                            cmd.Parameters.AddWithValue("@nomeFunc", nomeFunc);
                            cmd.Parameters.AddWithValue("@CPFfunc", CPFfunc);
                            cmd.Parameters.AddWithValue("@idade", idade);
                            cmd.Parameters.AddWithValue("@cargo", cargo);
                            cmd.Parameters.AddWithValue("@idhospital", idhospital);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Funcionário cadastrado com sucesso!");
                        cnn.Close();
                    } // FIM IF
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

        private void CadFunc_Load(object sender, EventArgs e)
        {

        }
    }
}

