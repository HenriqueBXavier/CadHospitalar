using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cadastro_Hospitalar
{


    public partial class AcessarConsultas : Form
    {
        String grupo = "pacientes", RID = "idpaciente";


        public AcessarConsultas()
        {
            InitializeComponent();
            cbxBuscarPAC.Text = "idpaciente";

        }

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Botão Buscar Tudo - button3_Click
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                using (SqlConnection cnn = new SqlConnection(Conexao.StrCon))
                {
                    conexao.conectar();

                    string msg;
                    
                    switch (grupo)
                    {
                        case "pacientes":

                            msg = "select idpaciente as 'ID Paciente', nome as 'Paciente', CPF, idade," +
                                " respons1 as 'Responsável 1', respons2 as 'Responsável 2', telefone_paciente as 'Telefone do Paciente'," +
                                " telefone_respons1 as 'Telefone do Responsável 1', telefone_respons2 as 'Telefone do Responsável 2'," +
                                " cirurgias as 'Cirurgias', alergias as 'Alergias' from pacientes; ";
                            break;

                        case "funcionarios":

                            msg = "SELECT idfuncionario as 'ID Funcionário', nomefunc as 'Funcionário', CPFfunc as 'CPF', idade, cargo, local_unidade as 'Unidade de Trabalho'" +
                                   " FROM funcionarios INNER JOIN hospitais h ON id_hospital = idhospital";

                            break;


                        case "doutores":

                            msg = "SELECT iddoutor as 'ID Doutor', nomedoutor as 'Doutor', salario, telefone_doc as 'Telefone do Doutor', local_unidade as 'Unidade de Trabalho' " +
                                  " FROM doutores INNER JOIN hospitais h ON id_hospital = idhospital";

                            break;


                        case "hospitais":

                            msg = "select idhospital as 'ID Hospital', local_unidade as 'Unidade' from hospitais;";

                            break;


                        case "consultas":

                            msg = "SELECT c.idconsulta as 'ID Consulta', c.id_hospital as 'ID Hospital', c.id_doutor as 'ID Doutor', c.id_paciente as 'ID Paciente', h.local_unidade as 'Unidade de Trabalho', d.nomedoutor as 'Doutor', p.nome as 'Paciente', " +
                                  " tipo_exame as 'Tipo do Exame', data_exame as 'Data do Exame', " +
                                  " regra as 'Condições para o Exame' FROM consultas c " +
                                  " INNER JOIN hospitais h ON id_hospital = idhospital" +
                                  " INNER JOIN doutores d ON id_doutor = iddoutor" +
                                  " INNER JOIN pacientes p ON id_paciente = idpaciente";


                            break;

                        default:
                            msg = "";
                            break;

                    }


                    using (SqlDataAdapter da = new SqlDataAdapter(msg, cnn))
                    {
                        using (DataTable dt = new DataTable())
                        {

                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                        }
                    }

                    conexao.desconectar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados" + ex.Message);
                throw;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        //Botão Filtrar - button3_Click
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cnn = new SqlConnection(Conexao.StrCon))
                {

                    conexao.conectar();

                    var sqlQuery = $"Select * from {grupo} where ";

                    if (cbxBuscarPAC.Visible == true)
                    {
                        switch (cbxBuscarPAC.Text)
                        {

                            case "nome":
                                sqlQuery += $"nome like '%{textBox1.Text}%' ;";
                                break;

                            case "CPF":
                                sqlQuery += $"CPF like '%{textBox1.Text}%' ;";
                                break;

                            case "idpaciente":
                                sqlQuery += $"idpaciente = {textBox1.Text}";
                                break;
                        }

                    }
                    else if (cbxBuscarDOC.Visible == true)
                    {
                        switch (cbxBuscarDOC.Text)
                        {
                            case "nomedoutor":
                                sqlQuery += $"nomedoutor like '%{textBox1.Text}%' ;";
                                break;

                            case "doutorado":
                                sqlQuery += $"doutorado like '%{textBox1.Text}%' ;";
                                break;

                            case "iddoutor":
                                sqlQuery += $"iddoutor = {textBox1.Text}";
                                break;
                        }

                    }
                    else if (cbxBuscarFUNC.Visible == true)
                    {
                        switch (cbxBuscarFUNC.Text)
                        {
                            case "nomeFUNC":
                                sqlQuery += $"nomeFUNC like '%{textBox1.Text}%' ;";
                                break;

                            case "CPFfunc":
                                sqlQuery += $"CPFfunc like '%{textBox1.Text}%' ;";
                                break;

                            case "cargo":
                                sqlQuery += $"cargo like '%{textBox1.Text}%';";
                                break;

                            case "idfuncionario":
                                sqlQuery += $"idfuncionario = {textBox1.Text}";
                                break;

                        }
                    }
                    else if (cbxBuscarCONS.Visible == true)
                    {
                        switch (cbxBuscarCONS.Text)
                        {

                            case "idconsulta":
                                sqlQuery = $"Select c.idconsulta, c.id_paciente, d.nomedoutor, p.nome, h.local_unidade, c.tipo_exame, c.data_exame, c.regra from {grupo} c " +
       $"inner join pacientes p on " +
       $"p.idpaciente = c.id_paciente " +
       $"inner join doutores d on " +
       $"d.iddoutor = c.id_doutor " +
       $"inner join hospitais h on " +
       $"h.idhospital = c.id_hospital where idconsulta = {textBox1.Text}";

                                break;

                            case "tipo_exame":
                                sqlQuery += $"tipo_exame like '%{textBox1.Text}%';";
                                break;

                            case "data_exame":

                                sqlQuery += $"data_exame like '%{textBox1.Text}%';";
                                break;

                            case "id_paciente":
                                sqlQuery = $"Select c.idconsulta, c.id_paciente, d.nomedoutor, p.nome, h.local_unidade, c.tipo_exame, c.data_exame, c.regra from {grupo} c " +
       $"inner join pacientes p on " +
       $"p.idpaciente = c.id_paciente " +
       $"inner join doutores d on " +
       $"d.iddoutor = c.id_doutor " +
       $"inner join hospitais h on " +
       $"h.idhospital = c.id_hospital where id_paciente = {textBox1.Text}";
                                break;
                        }


                    }
                    else if (cbxBuscarHOS.Visible == true)
                    {
                        switch (cbxBuscarHOS.Text)
                        {

                            case "idhospital":
                                sqlQuery += $"idhospital = {textBox1.Text}";
                                break;

                            case "local_unidade":
                                sqlQuery += $"local_unidade like '%{textBox1.Text}%';";
                                break;

                        }


                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cnn))
                    {
                        using (DataTable dt = new DataTable())
                        {

                            da.Fill(dt);
                            dataGridView1.DataSource = dt;

                        }
                    }

                    conexao.desconectar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao banco de dados. \n" + ex.Message);
                throw;
            }

        }

        //Botão SAIR - button4_Click
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                grupo = "pacientes";
                RID = "idpaciente";
                cbxBuscarCONS.Visible = false;
                cbxBuscarPAC.Visible = true;
                cbxBuscarDOC.Visible = false;
                cbxBuscarHOS.Visible = false;
                cbxBuscarFUNC.Visible = false;

                cbxBuscarPAC.Text = "idpaciente";

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                grupo = "doutores";
                RID = "iddoutor";
                cbxBuscarCONS.Visible = false;
                cbxBuscarPAC.Visible = false;
                cbxBuscarDOC.Visible = true;
                cbxBuscarHOS.Visible = false;
                cbxBuscarFUNC.Visible = false;

                cbxBuscarDOC.Text = "iddoutor";

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                grupo = "funcionarios";
                RID = "idfuncionario";
                cbxBuscarCONS.Visible = false;
                cbxBuscarPAC.Visible = false;
                cbxBuscarDOC.Visible = false;
                cbxBuscarHOS.Visible = false;
                cbxBuscarFUNC.Visible = true;

                cbxBuscarFUNC.Text = "idfuncionario";

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                grupo = "hospitais";
                RID = "idhospital";
                cbxBuscarCONS.Visible = false;
                cbxBuscarPAC.Visible = false;
                cbxBuscarDOC.Visible = false;
                cbxBuscarHOS.Visible = true;
                cbxBuscarFUNC.Visible = false;

                cbxBuscarHOS.Text = "idhospital";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                grupo = "consultas";
                RID = "idconsulta";
                cbxBuscarCONS.Visible = true;
                cbxBuscarPAC.Visible = false;
                cbxBuscarDOC.Visible = false;
                cbxBuscarHOS.Visible = false;
                cbxBuscarFUNC.Visible = false;

                cbxBuscarCONS.Text = "id_paciente";
            }
        }


        //Botão Atualizar - button2_Click_1
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(Conexao.StrCon))
                {
                    conexao.conectar();
                    cnn.Open();

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    if (!selectedRow.IsNewRow)
                    {

                        if (grupo == "pacientes" && !string.IsNullOrEmpty(selectedRow.Cells["idpaciente"].Value?.ToString()))
                        {
                            int id = Convert.ToInt32(selectedRow.Cells["idpaciente"].Value);

                            string novoNome = selectedRow.Cells["nome"].Value.ToString();
                            string novoCPF = selectedRow.Cells["CPF"].Value.ToString();
                            string novaidade = selectedRow.Cells["idade"].Value.ToString();
                            string nresp1 = selectedRow.Cells["respons1"].Value.ToString();
                            string nresp2 = selectedRow.Cells["respons2"].Value.ToString();
                            string ntelpac = selectedRow.Cells["telefone_paciente"].Value.ToString();
                            string ntelres1 = selectedRow.Cells["telefone_respons1"].Value.ToString();
                            string ntelres2 = selectedRow.Cells["telefone_respons2"].Value.ToString();
                            string ncirurgia = selectedRow.Cells["cirurgias"].Value.ToString();
                            string nalergias = selectedRow.Cells["alergias"].Value.ToString();

                            string sqlQuery = $"UPDATE {grupo} SET nome = '{novoNome}', CPF = '{novoCPF}', idade = '{novaidade}', respons1 = '{nresp1}', respons2 " +
                                $"= '{nresp2}', telefone_paciente = '{ntelpac}', telefone_respons1 = '{ntelres1}', telefone_respons2 = '{ntelres2}'," +
                                $"cirurgias = '{ncirurgia}', alergias = '{nalergias}'  where idpaciente = {id};";

                            using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                            {
                                cmd.ExecuteNonQuery();

                            }

                        }
                        else if (grupo == "doutores" && !string.IsNullOrEmpty(selectedRow.Cells["iddoutor"].Value?.ToString()))
                        {
                            int idDoutor = Convert.ToInt32(selectedRow.Cells["iddoutor"].Value);

                            string novoNomeDoutor = selectedRow.Cells["nomedoutor"].Value.ToString();
                            string novoDoutorado = selectedRow.Cells["doutorado"].Value.ToString();
                            double novoSalario = Convert.ToDouble(selectedRow.Cells["salario"].Value);
                            string novoTelefoneDoutor = selectedRow.Cells["telefone_doc"].Value.ToString();
                            int idHospital = Convert.ToInt32(selectedRow.Cells["id_hospital"].Value);

                            string sqlQuery = $"UPDATE doutores SET nomedoutor = '{novoNomeDoutor}', doutorado = '{novoDoutorado}', salario = {novoSalario}," +
                                $" telefone_doc = '{novoTelefoneDoutor}', id_hospital = {idHospital} WHERE iddoutor = {idDoutor}";

                            using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else if (grupo == "consultas" && !string.IsNullOrEmpty(selectedRow.Cells["idconsulta"].Value?.ToString()))
                        {
                            int idConsulta = Convert.ToInt32(selectedRow.Cells["idconsulta"].Value);
                            int idHospital = Convert.ToInt32(selectedRow.Cells["id_hospital"].Value);
                            int idDoutor = Convert.ToInt32(selectedRow.Cells["id_doutor"].Value);
                            int idPaciente = Convert.ToInt32(selectedRow.Cells["id_paciente"].Value);
                            string tipoExame = selectedRow.Cells["tipo_exame"].Value.ToString();
                            string dataExame = selectedRow.Cells["data_exame"].Value.ToString();
                            string regra = selectedRow.Cells["regra"].Value.ToString();

                            string sqlQuery = $"UPDATE consultas SET id_hospital = {idHospital}, id_doutor = {idDoutor}, id_paciente = {idPaciente}, tipo_exame = '{tipoExame}', data_exame = '{dataExame}', regra = '{regra}' WHERE idconsulta = {idConsulta}";

                            using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                        }
                        else if (grupo == "hospitais" && !string.IsNullOrEmpty(selectedRow.Cells["idhospital"].Value?.ToString()))
                        {
                            int idhos = Convert.ToInt32(selectedRow.Cells["idhospital"].Value);
                            int local_uni = Convert.ToInt32(selectedRow.Cells["local_unidade"].Value);

                            string sqlQuery = $"UPDATE consultas SET local_unidade = '{local_uni}' WHERE idhospital = {idhos}";

                            using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                        }
                        else if (grupo == "funcionarios" && !string.IsNullOrEmpty(selectedRow.Cells["idfuncionario"].Value?.ToString()))
                        {
                            int idFuncionario = Convert.ToInt32(selectedRow.Cells["idfuncionario"].Value);

                            string nomeFunc = selectedRow.Cells["nomefunc"].Value.ToString();
                            string cpfFunc = selectedRow.Cells["CPFfunc"].Value.ToString();
                            string idade = selectedRow.Cells["idade"].Value.ToString();
                            string cargo = selectedRow.Cells["cargo"].Value.ToString();
                            int idHospital = Convert.ToInt32(selectedRow.Cells["id_hospital"].Value);

                            string sqlQuery = $"UPDATE funcionarios SET nomefunc = '{nomeFunc}', CPFfunc = '{cpfFunc}'," +
                                $" idade = '{idade}', cargo = '{cargo}', id_hospital = {idHospital} WHERE idfuncionario = {idFuncionario}";

                            using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                            {
                                cmd.ExecuteNonQuery();

                            }

                        }

                        MessageBox.Show("Dados atualizados com sucesso! \nReiniciando tela...");

                        AtualizarDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados" + ex.Message);
                throw;
            }
        }

        private void AtualizarDataGridView()
        {

            using (SqlConnection cnn = new SqlConnection(Conexao.StrCon))
            {
                conexao.conectar();

                var sqlQuery = $"SELECT * FROM {grupo};";

                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cnn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                conexao.desconectar();
            }


        }

        private void AcessarConsultas_Load(object sender, EventArgs e)
        {

        }
        //Botão APAGAR - button2_Click
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(Conexao.StrCon))
                {

                    conexao.conectar();

                    List<object> idsExcluir = new List<object>();

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        object id = row.Cells[RID].Value;
                        idsExcluir.Add(id);
                    }

                    var sqlQuery = $"DELETE FROM {grupo} WHERE {RID} IN ({string.Join(",", idsExcluir)})";

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }

                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cnn))
                    {

                        cmd.ExecuteNonQuery();

                    }

                    conexao.desconectar();

                }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel se conectar ao banco de dados" + ex.Message);
                    throw;
                }
            }
        }
    }



