using ec.edu.monster.controller;
using ec.edu.monster.view;

namespace Clicon_Eureka_Rest_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new ConsoleView();
            var loginController = new LoginController(view);
            var homeController = new HomeController(view);

            while (true)
            {
                if (loginController.Login())
                {
                    homeController.Start();
                }
                else
                {
                    view.ShowMessage("Inicio de sesión fallido. Intente nuevamente.");
                }
            }
        }
    }
}
