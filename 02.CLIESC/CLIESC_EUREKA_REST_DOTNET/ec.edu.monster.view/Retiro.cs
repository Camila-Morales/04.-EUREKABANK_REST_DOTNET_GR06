using ec.edu.monster.controller;
using System;
using System.Windows.Forms;

namespace ec.edu.monster.view
{
    public partial class Retiro : Form
    {
        private readonly HomeController _homeController;

        public Retiro(HomeController homeController)
        {
            InitializeComponent();
            _homeController = homeController;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            _homeController.RealizarRetiro(txtCuenta.Text.Trim(), Convert.ToDecimal(txtValor.Text));
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual y regresa al menú principal
        }
    }
}
