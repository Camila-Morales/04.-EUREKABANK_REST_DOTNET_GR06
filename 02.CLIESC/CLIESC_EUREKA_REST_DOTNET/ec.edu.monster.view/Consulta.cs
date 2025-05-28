using ec.edu.monster.controller;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ec.edu.monster.view
{
    public partial class Consulta : Form
    {
        private readonly HomeController _homeController;

        public Consulta(HomeController homeController)
        {
            InitializeComponent();
            _homeController = homeController;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numeroCuenta = txtCuenta.Text.Trim();

            if (string.IsNullOrEmpty(numeroCuenta))
            {
                MessageBox.Show("Por favor, ingresa el número de cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal saldoActual;
            var movimientos = _homeController.ConsultarMovimientos(numeroCuenta, out saldoActual);

            if (movimientos != null && movimientos.Count > 0)
            {
                lblResultadoCuenta.Text = $"Saldo actual: ${saldoActual:N2}"; // Mostrar saldo actual
                dgvMovimientos.Rows.Clear();

                int rowNumber = 1;
                foreach (var movimiento in movimientos)
                {
                    dgvMovimientos.Rows.Add(
                        rowNumber++,
                        movimiento.TipoMovimiento,
                        movimiento.MovValor.ToString("F2"),
                        movimiento.MovFechaFormateada // Usar la fecha formateada
                    );
                }
            }
            else
            {
                lblResultadoCuenta.Text = string.Empty;
                MessageBox.Show("No se encontraron movimientos para esta cuenta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Cerrar esta ventana y volver al menú principal
            this.Close();
        }


    }
}
