using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Cadastro_Hospitalar
{
    public partial class CadConsultas : Form
    {
        public CadConsultas()
        {
            InitializeComponent();
            CarregarPacientes();
            CarregarHospitais();
            CarregarDoutores();

        }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        private void CarregarPacientes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Conexao.StrCon))
                {
                    con.Open();

                    string query = "SELECT idpaciente, nome FROM dbo.pacientes";

                    using (SqlCommand command = new SqlCommand(query, con))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idpaciente = reader.GetInt32(0);
                            string nome = reader.GetString(1);
                            string itemText = $"{idpaciente}: {nome}";

                            ComboBoxPac.Items.Add(itemText);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível se conectar ao banco de dados" + ex.Message);

            }

        }

        private void CarregarDoutores()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Conexao.StrCon))
                {
                    con.Open();

                    string query = "SELECT iddoutor, nomedoutor FROM dbo.doutores";

                    using (SqlCommand command = new SqlCommand(query, con))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int iddoutor = reader.GetInt32(0);
                            string nomedoutor = reader.GetString(1);
                            string itemText = $"{iddoutor}: {nomedoutor}";

                            ComboBoxDoc.Items.Add(itemText);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível se conectar ao banco de dados" + ex.Message);

            }

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

                    if (ComboBoxDoc.Text == "" || ComboBoxHos.Text == "" || ComboBoxPac.Text == "")
                    {
                        MessageBox.Show("Digite um ID válido.");
                    }
                    else
                    {

                        string tipo_ex = textBox5.Text;
                        string data_ex = maskedTextBox1.Text;
                        string regras = textBox6.Text;

                        if (tipo_ex == "" || data_ex == "")
                        {
                            MessageBox.Show("Digite um valor válido. ");
                        }
                        else
                        {
                            var selectedPac = ComboBoxPac.SelectedItem as string;
                            int idpaciente = int.Parse(selectedPac?.Split(':')[0] ?? "0");

                            var selectedDoc = ComboBoxDoc.SelectedItem as string;
                            int iddoutor = int.Parse(selectedDoc?.Split(':')[0] ?? "0");

                            var selectedHos = ComboBoxHos.SelectedItem as string;
                            int idhospital = int.Parse(selectedHos?.Split(':')[0] ?? "0");


                            var sqlQuery = "INSERT INTO consultas (id_hospital, id_doutor, id_paciente, tipo_exame, data_exame, regra)" +
                                " VALUES (@id_hospital, @id_doutor, @id_paciente, @tipo_exame, @data_exame, @regra);";

                            using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                            {
                                cmd.Parameters.AddWithValue("@id_hospital", idhospital);
                                cmd.Parameters.AddWithValue("@id_doutor", iddoutor);
                                cmd.Parameters.AddWithValue("@id_paciente", idpaciente);
                                cmd.Parameters.AddWithValue("@tipo_exame", tipo_ex);
                                cmd.Parameters.AddWithValue("@data_exame", data_ex);
                                cmd.Parameters.AddWithValue("@regra", regras);

                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Consulta cadastrada com sucesso!");
                            cnn.Close();
                        } // FIM IF
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

        private void CadConsultas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
