namespace ec.edu.monster.view
{
    partial class Consulta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            sidebar = new Panel();
            btnBackToMenu = new Button();
            logoPictureBox = new PictureBox();
            lblBankName = new Label();
            contentPanel = new Panel();
            titleLabel = new Label();
            txtCuenta = new TextBox();
            btnBuscar = new Button();
            lblResultadoCuenta = new Label();
            dgvMovimientos = new DataGridView();
            ColNumero = new DataGridViewTextBoxColumn();
            ColTipoMovimiento = new DataGridViewTextBoxColumn();
            ColValor = new DataGridViewTextBoxColumn();
            ColFecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Dock = DockStyle.Fill;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(1143, 800);
            sidebar.TabIndex = 0;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.FromArgb(255, 128, 255);
            btnBackToMenu.FlatStyle = FlatStyle.Flat;
            btnBackToMenu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackToMenu.ForeColor = Color.FromArgb(0, 62, 126);
            btnBackToMenu.Location = new Point(483, 694);
            btnBackToMenu.Margin = new Padding(3, 4, 3, 4);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(229, 67);
            btnBackToMenu.TabIndex = 0;
            btnBackToMenu.Text = "Volver al Menú";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(12, 4);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(171, 72);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // lblBankName
            // 
            lblBankName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankName.ForeColor = Color.FromArgb(0, 62, 126);
            lblBankName.Location = new Point(975, 4);
            lblBankName.Name = "lblBankName";
            lblBankName.Size = new Size(165, 53);
            lblBankName.TabIndex = 2;
            lblBankName.Text = "Eureka Bank";
            lblBankName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(255, 192, 255);
            contentPanel.Controls.Add(btnBackToMenu);
            contentPanel.Controls.Add(titleLabel);
            contentPanel.Controls.Add(lblBankName);
            contentPanel.Controls.Add(logoPictureBox);
            contentPanel.Controls.Add(txtCuenta);
            contentPanel.Controls.Add(btnBuscar);
            contentPanel.Controls.Add(lblResultadoCuenta);
            contentPanel.Controls.Add(dgvMovimientos);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1143, 800);
            contentPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(0, 62, 126);
            titleLabel.Location = new Point(321, 36);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(563, 53);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Consulta de Movimientos";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCuenta
            // 
            txtCuenta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuenta.Location = new Point(333, 113);
            txtCuenta.Margin = new Padding(3, 4, 3, 4);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.PlaceholderText = "Número de cuenta";
            txtCuenta.Size = new Size(342, 30);
            txtCuenta.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 62, 126);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(699, 106);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(137, 53);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Consultar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblResultadoCuenta
            // 
            lblResultadoCuenta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultadoCuenta.ForeColor = Color.Black;
            lblResultadoCuenta.Location = new Point(219, 202);
            lblResultadoCuenta.Name = "lblResultadoCuenta";
            lblResultadoCuenta.Size = new Size(157, 40);
            lblResultadoCuenta.TabIndex = 3;
            lblResultadoCuenta.Text = "Movimientos:";
            lblResultadoCuenta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { ColNumero, ColTipoMovimiento, ColValor, ColFecha });
            dgvMovimientos.Location = new Point(219, 246);
            dgvMovimientos.Margin = new Padding(3, 4, 3, 4);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersWidth = 51;
            dgvMovimientos.Size = new Size(743, 419);
            dgvMovimientos.TabIndex = 4;
            // 
            // ColNumero
            // 
            ColNumero.HeaderText = "No.";
            ColNumero.MinimumWidth = 6;
            ColNumero.Name = "ColNumero";
            ColNumero.Width = 50;
            // 
            // ColTipoMovimiento
            // 
            ColTipoMovimiento.HeaderText = "Tipo";
            ColTipoMovimiento.MinimumWidth = 6;
            ColTipoMovimiento.Name = "ColTipoMovimiento";
            ColTipoMovimiento.Width = 200;
            // 
            // ColValor
            // 
            ColValor.HeaderText = "Monto";
            ColValor.MinimumWidth = 6;
            ColValor.Name = "ColValor";
            ColValor.Width = 150;
            // 
            // ColFecha
            // 
            ColFecha.HeaderText = "Fecha";
            ColFecha.MinimumWidth = 6;
            ColFecha.Name = "ColFecha";
            ColFecha.Width = 200;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 800);
            Controls.Add(contentPanel);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Consulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de Movimientos";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
        }

        private Panel sidebar;
        private Button btnBackToMenu;
        private PictureBox logoPictureBox;
        private Label lblBankName;
        private Panel contentPanel;
        private Label titleLabel;
        private TextBox txtCuenta;
        private Button btnBuscar;
        private Label lblResultadoCuenta;
        private DataGridView dgvMovimientos;
        private DataGridViewTextBoxColumn ColNumero;
        private DataGridViewTextBoxColumn ColTipoMovimiento;
        private DataGridViewTextBoxColumn ColValor;
        private DataGridViewTextBoxColumn ColFecha;
    }
}
