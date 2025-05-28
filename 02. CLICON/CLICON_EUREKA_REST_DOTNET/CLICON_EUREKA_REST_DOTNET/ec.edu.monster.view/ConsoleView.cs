using System;
using System.Collections.Generic;
using ec.edu.monster.model;

namespace ec.edu.monster.view
{
    public class ConsoleView
    {
        public void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("           ╔════════════════════════════════════╗");
            Console.WriteLine("           ║                                    ║");
            Console.WriteLine("           ║   BIENVENIDO A EUREKABANK - REST   ║");
            Console.WriteLine("           ║                                    ║");
            Console.WriteLine("           ╚════════════════════════════════════╝");
            Console.WriteLine("1. Consultar Movimientos");
            Console.WriteLine("2. Realizar Depósito");
            Console.WriteLine("3. Realizar Retiro");
            Console.WriteLine("4. Realizar Transferencia");
            Console.WriteLine("6. Salir");
            Console.WriteLine("====================");
            Console.Write("Seleccione una opción: ");
        }

        public void ShowMovimientos(List<Movimiento> movimientos, decimal saldoActual)
        {
            Console.Clear();
            Console.WriteLine("==== Movimientos ====");
            Console.WriteLine("| {0,-5} | {1,-25} | {2,-10} | {3,-20} |", "No.", "Tipo de Movimiento", "Valor", "Fecha");

            int count = 1;
            foreach (var mov in movimientos)
            {
                Console.WriteLine("| {0,-5} | {1,-25} | {2,-10:N2} | {3,-20} |",
                                  count,
                                  mov.TipoMovimiento,
                                  mov.MovValor,
                                  mov.MovFecha.ToString("dd/MM/yyyy") ?? "N/A");
                count++;
            }

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Presione 'Enter' para volver al menú principal...");
            Console.ReadLine();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowLogin()
        {
            Console.Clear();
            Console.WriteLine("Iniciar Sesión");
        }

        public string PromptForUsername()
        {
            Console.Write("Usuario: ");
            return Console.ReadLine();
        }

        public string PromptForPassword()
        {
            Console.Write("Contraseña: ");
            return Console.ReadLine();
        }

        public void Pause(string message = "Presione 'Enter' para continuar...")
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
