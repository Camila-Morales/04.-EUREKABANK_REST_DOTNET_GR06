using ec.edu.monster.controller;
using System;
using System.Windows.Forms;

namespace ec.edu.monster.view
{
    public partial class Transferencia : Form
    {
        private readonly HomeController _homeController;

        public Transferencia(HomeController homeController)
        {
            InitializeComponent();
            _homeController = homeController;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            _homeController.RealizarTransferencia(txtCuentaOrigen.Text.Trim(), txtCuentaDestino.Text.Trim(), Convert.ToDecimal(txtValor.Text));
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Cerrar esta ventana y volver al menú principal
            this.Close();
        }
    }
}
