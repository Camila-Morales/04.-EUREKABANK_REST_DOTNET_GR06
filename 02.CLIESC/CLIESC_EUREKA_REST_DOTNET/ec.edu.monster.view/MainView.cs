using ec.edu.monster.controller;
using System;
using System.Windows.Forms;

namespace ec.edu.monster.view
{
    public partial class MainView : Form
    {
        private readonly HomeController _homeController;

        public MainView(HomeController homeController)
        {
            InitializeComponent();
            _homeController = homeController;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var consultaForm = new Consulta(_homeController);
            consultaForm.ShowDialog();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var depositoForm = new Deposito(_homeController);
            depositoForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Mostrar nuevamente el formulario de inicio de sesión
            this.Owner?.Show(); // Mostrar el formulario dueño (LoginForm)

            // Cerrar este formulario por completo
            this.Close();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            var retiroForm = new Retiro(_homeController);
            retiroForm.ShowDialog();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            var transferenciaForm = new Transferencia(_homeController);
            transferenciaForm.ShowDialog();
        }



        private void lblBankName_Click(object sender, EventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void depositDescription_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
