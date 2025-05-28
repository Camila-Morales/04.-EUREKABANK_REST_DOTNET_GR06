namespace ec.edu.monster.view
{
    partial class Transferencia
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
            sidebar = new Panel();
            btnBackToMenu = new Button();
            logoPictureBox = new PictureBox();
            lblBankName = new Label();
            contentPanel = new Panel();
            titleLabel = new Label();
            formPanel = new Panel();
            txtCuentaOrigen = new TextBox();
            txtCuentaDestino = new TextBox();
            txtValor = new TextBox();
            btnTransferir = new Button();
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
            btnBackToMenu.Location = new Point(482, 546);
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
            logoPictureBox.BackgroundImage = CLIESC_EUREKA_REST_DOTNET.Properties.Resources.espe;
            logoPictureBox.Location = new Point(12, 13);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(316, 65);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // lblBankName
            // 
            lblBankName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankName.ForeColor = Color.FromArgb(0, 62, 126);
            lblBankName.Location = new Point(936, 0);
            lblBankName.Name = "lblBankName";
            lblBankName.Size = new Size(149, 53);
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
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.FromArgb(0, 62, 126);
            titleLabel.Location = new Point(279, 62);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(629, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Realizar Transferencia";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.MediumOrchid;
            formPanel.Controls.Add(txtCuentaOrigen);
            formPanel.Controls.Add(txtCuentaDestino);
            formPanel.Controls.Add(txtValor);
            formPanel.Controls.Add(btnTransferir);
            formPanel.Location = new Point(377, 106);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(436, 409);
            formPanel.TabIndex = 1;
            // 
            // txtCuentaOrigen
            // 
            txtCuentaOrigen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuentaOrigen.Location = new Point(37, 60);
            txtCuentaOrigen.Margin = new Padding(3, 4, 3, 4);
            txtCuentaOrigen.Name = "txtCuentaOrigen";
            txtCuentaOrigen.PlaceholderText = "Cuenta Origen";
            txtCuentaOrigen.Size = new Size(354, 30);
            txtCuentaOrigen.TabIndex = 0;
            // 
            // txtCuentaDestino
            // 
            txtCuentaDestino.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuentaDestino.Location = new Point(37, 140);
            txtCuentaDestino.Margin = new Padding(3, 4, 3, 4);
            txtCuentaDestino.Name = "txtCuentaDestino";
            txtCuentaDestino.PlaceholderText = "Cuenta Destino";
            txtCuentaDestino.Size = new Size(354, 30);
            txtCuentaDestino.TabIndex = 1;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(37, 220);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Cantidad a Transferir";
            txtValor.Size = new Size(354, 30);
            txtValor.TabIndex = 2;
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.FromArgb(0, 62, 126);
            btnTransferir.FlatStyle = FlatStyle.Flat;
            btnTransferir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransferir.ForeColor = Color.White;
            btnTransferir.Location = new Point(131, 321);
            btnTransferir.Margin = new Padding(3, 4, 3, 4);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(171, 53);
            btnTransferir.TabIndex = 4;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // Transferencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 674);
            Controls.Add(contentPanel);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Transferencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Realizar Transferencia";
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
        private TextBox txtCuentaOrigen;
        private TextBox txtCuentaDestino;
        private TextBox txtValor;
        private Button btnTransferir;
    }
}
