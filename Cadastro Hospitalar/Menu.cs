using System.Data.SqlClient;
using System.Threading;

namespace Cadastro_Hospitalar
{

    public partial class Menu : Form
    {

        Thread t1;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            t1 = new Thread(CadPac);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void CadPac(object obj)
        {
            Application.Run(new CadPac());
        }

        private void btnCadConsultas_Click(object sender, EventArgs e)
        {

            t1 = new Thread(CadConsulta);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void CadConsulta(object obj)
        {
            Application.Run(new CadConsultas());

        }

        private void btnCadDoutores_Click(object sender, EventArgs e)
        {

            t1 = new Thread(CadDoctor);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void CadDoctor(object obj)
        {

            Application.Run(new CadDoc());

        }

        private void btnCadHospital_Click(object sender, EventArgs e)
        {

            t1 = new Thread(CadUnidade);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void CadUnidade(object obj)
        {
            Application.Run(new CadUnidade());
        }

        private void btnAccConsultas_Click(object sender, EventArgs e)
        { 
            t1 = new Thread(AccCons);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void AccCons(object obj)
        {
            Application.Run(new AcessarConsultas());
        }

        private void btnCadFuncionarios_Click(object sender, EventArgs e)
        {
            t1 = new Thread(CadFun);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }

        private void CadFun(object obj)
        {
            Application.Run(new CadFunc());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}