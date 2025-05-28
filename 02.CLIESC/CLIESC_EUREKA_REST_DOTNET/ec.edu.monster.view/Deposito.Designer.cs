namespace ec.edu.monster.view
{
    partial class Deposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposito));
            sidebar = new Panel();
            btnBackToMenu = new Button();
            logoPictureBox = new PictureBox();
            lblBankName = new Label();
            contentPanel = new Panel();
            titleLabel = new Label();
            formPanel = new Panel();
            txtCuenta = new TextBox();
            txtValor = new TextBox();
            btnDepositar = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            contentPanel.SuspendLayout();
            formPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Dock = DockStyle.Fill;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(1085, 674);
            sidebar.TabIndex = 0;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.FromArgb(255, 128, 255);
            btnBackToMenu.FlatStyle = FlatStyle.Flat;
            btnBackToMenu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackToMenu.ForeColor = Color.FromArgb(0, 62, 126);
            btnBackToMenu.Location = new Point(464, 549);
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
            logoPictureBox.Location = new Point(32, 13);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(171, 95);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // lblBankName
            // 
            lblBankName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankName.ForeColor = Color.FromArgb(0, 62, 126);
            lblBankName.Location = new Point(899, 9);
            lblBankName.Name = "lblBankName";
            lblBankName.Size = new Size(183, 53);
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
            contentPanel.Controls.Add(formPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1085, 674);
            contentPanel.TabIndex = 1;
            contentPanel.Paint += contentPanel_Paint;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(0, 62, 126);
            titleLabel.Location = new Point(267, 51);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(629, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Registrar Depósito";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.MediumOrchid;
            formPanel.Controls.Add(txtCuenta);
            formPanel.Controls.Add(txtValor);
            formPanel.Controls.Add(btnDepositar);
            formPanel.Location = new Point(365, 132);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(436, 371);
            formPanel.TabIndex = 1;
            // 
            // txtCuenta
            // 
            txtCuenta.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuenta.Location = new Point(37, 46);
            txtCuenta.Margin = new Padding(3, 4, 3, 4);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.PlaceholderText = "Número de Cuenta";
            txtCuenta.Size = new Size(354, 45);
            txtCuenta.TabIndex = 0;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(37, 154);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Cantidad a Depositar";
            txtValor.Size = new Size(354, 30);
            txtValor.TabIndex = 1;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.FromArgb(0, 62, 126);
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnDepositar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDepositar.ForeColor = Color.White;
            btnDepositar.Location = new Point(127, 255);
            btnDepositar.Margin = new Padding(3, 4, 3, 4);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(171, 53);
            btnDepositar.TabIndex = 4;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // Deposito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 674);
            Controls.Add(contentPanel);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Deposito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Depósito";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            contentPanel.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel sidebar;
        private Button btnBackToMenu;
        private PictureBox logoPictureBox;
        private Label lblBankName;
        private Panel contentPanel;
        private Label titleLabel;
        private Panel formPanel;
        private TextBox txtCuenta;
        private TextBox txtValor;
        private Button btnDepositar;
    }
}
