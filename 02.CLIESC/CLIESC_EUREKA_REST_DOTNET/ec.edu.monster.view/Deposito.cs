using ec.edu.monster.controller;
using System;
using System.Windows.Forms;

namespace ec.edu.monster.view
{
    public partial class Deposito : Form
    {
        private readonly HomeController _homeController;

        public Deposito(HomeController homeController)
        {
            InitializeComponent();
            _homeController = homeController;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            _homeController.RealizarDeposito(txtCuenta.Text.Trim(), Convert.ToDecimal(txtValor.Text));
        }
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Cerrar esta ventana y volver al menú principal
            this.Close();
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
