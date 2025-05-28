using ec.edu.monster.controller;
using ec.edu.monster.view;
using System;
using System.Windows.Forms;

namespace CLIESC_EUREKA_REST_DOTNET
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var homeController = new HomeController();
            Application.Run(new LoginForm(homeController));
        }
    }
}
