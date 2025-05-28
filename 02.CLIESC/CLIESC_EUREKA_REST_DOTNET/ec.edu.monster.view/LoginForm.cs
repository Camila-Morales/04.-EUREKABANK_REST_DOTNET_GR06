using ec.edu.monster.controller;
using System;
using System.Windows.Forms;

namespace ec.edu.monster.view
{
    public partial class LoginForm : Form
    {
        private readonly HomeController _homeController;

        public LoginForm()
        {
            InitializeComponent();
            _homeController = new HomeController(); // Crear controlador si es necesario
        }

        public LoginForm(HomeController homeController)
        {
            InitializeComponent();
            _homeController = homeController;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validar credenciales
            if (_homeController.Login(username, password))
            {
                // Crear y mostrar el formulario principal, asignando este formulario como dueño
                var mainView = new MainView(_homeController)
                {
                    Owner = this // Asignar el dueño del formulario
                };

                // Ocultar el formulario de inicio de sesión
                this.Hide();

                // Mostrar el formulario principal
                mainView.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
