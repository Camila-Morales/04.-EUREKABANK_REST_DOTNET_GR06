namespace ec.edu.monster.view
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            sidebar = new Panel();
            btnLogout = new Button();
            lblBankName = new Label();
            logoPictureBox = new PictureBox();
            contentPanel = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            btnTransferencia = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btnRetiro = new Button();
            label1 = new Label();
            cardDeposit = new Panel();
            depositPictureBox = new PictureBox();
            depositTitle = new Label();
            depositDescription = new Label();
            btnRegister = new Button();
            cardMovements = new Panel();
            movementsPictureBox = new PictureBox();
            movementsTitle = new Label();
            movementsDescription = new Label();
            btnConsult = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            contentPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cardDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)depositPictureBox).BeginInit();
            cardMovements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)movementsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Dock = DockStyle.Fill;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(1302, 841);
            sidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Fuchsia;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.FromArgb(0, 62, 126);
            btnLogout.Location = new Point(26, 598);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(229, 67);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Cerrar sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblBankName
            // 
            lblBankName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBankName.ForeColor = Color.FromArgb(0, 62, 126);
            lblBankName.Location = new Point(630, 21);
            lblBankName.Name = "lblBankName";
            lblBankName.Size = new Size(286, 53);
            lblBankName.TabIndex = 2;
            lblBankName.Text = "Eureka Bank";
            lblBankName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(26, 21);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(207, 128);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(255, 192, 255);
            contentPanel.Controls.Add(lblBankName);
            contentPanel.Controls.Add(btnLogout);
            contentPanel.Controls.Add(logoPictureBox);
            contentPanel.Controls.Add(panel2);
            contentPanel.Controls.Add(panel1);
            contentPanel.Controls.Add(label1);
            contentPanel.Controls.Add(cardDeposit);
            contentPanel.Controls.Add(cardMovements);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1302, 841);
            contentPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumOrchid;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnTransferencia);
            panel2.Location = new Point(998, 187);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 359);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = CLIESC_EUREKA_REST_DOTNET.Properties.Resources.transferencia1;
            pictureBox2.Location = new Point(71, 15);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 62, 126);
            label4.Location = new Point(21, 180);
            label4.Name = "label4";
            label4.Size = new Size(237, 53);
            label4.TabIndex = 1;
            label4.Text = "Transferencia";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(9, 220);
            label5.Name = "label5";
            label5.Size = new Size(280, 70);
            label5.TabIndex = 2;
            label5.Text = "Disponible las 24 Horas";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // btnTransferencia
            // 
            btnTransferencia.BackColor = Color.DarkSlateBlue;
            btnTransferencia.FlatStyle = FlatStyle.Flat;
            btnTransferencia.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransferencia.ForeColor = Color.White;
            btnTransferencia.Location = new Point(43, 285);
            btnTransferencia.Margin = new Padding(3, 4, 3, 4);
            btnTransferencia.Name = "btnTransferencia";
            btnTransferencia.Size = new Size(198, 53);
            btnTransferencia.TabIndex = 3;
            btnTransferencia.Text = "Transferir";
            btnTransferencia.UseVisualStyleBackColor = false;
            btnTransferencia.Click += btnTransferencia_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumOrchid;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnRetiro);
            panel1.Location = new Point(346, 187);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 359);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CLIESC_EUREKA_REST_DOTNET.Properties.Resources.retiro2;
            pictureBox1.Location = new Point(71, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 62, 126);
            label2.Location = new Point(21, 180);
            label2.Name = "label2";
            label2.Size = new Size(237, 53);
            label2.TabIndex = 1;
            label2.Text = "Retiro";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(9, 220);
            label3.Name = "label3";
            label3.Size = new Size(280, 70);
            label3.TabIndex = 2;
            label3.Text = "Disponible las 24 Horas";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRetiro
            // 
            btnRetiro.BackColor = Color.DarkSlateBlue;
            btnRetiro.FlatStyle = FlatStyle.Flat;
            btnRetiro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetiro.ForeColor = Color.White;
            btnRetiro.Location = new Point(43, 285);
            btnRetiro.Margin = new Padding(3, 4, 3, 4);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(198, 53);
            btnRetiro.TabIndex = 3;
            btnRetiro.Text = "Retirar";
            btnRetiro.UseVisualStyleBackColor = false;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 62, 126);
            label1.Location = new Point(630, 74);
            label1.Name = "label1";
            label1.Size = new Size(308, 38);
            label1.TabIndex = 3;
            label1.Text = "Selecciona una opción";
            // 
            // cardDeposit
            // 
            cardDeposit.BackColor = Color.MediumOrchid;
            cardDeposit.Controls.Add(depositPictureBox);
            cardDeposit.Controls.Add(depositTitle);
            cardDeposit.Controls.Add(depositDescription);
            cardDeposit.Controls.Add(btnRegister);
            cardDeposit.Location = new Point(26, 187);
            cardDeposit.Margin = new Padding(3, 4, 3, 4);
            cardDeposit.Name = "cardDeposit";
            cardDeposit.Size = new Size(292, 359);
            cardDeposit.TabIndex = 1;
            // 
            // depositPictureBox
            // 
            depositPictureBox.Image = CLIESC_EUREKA_REST_DOTNET.Properties.Resources.deposito;
            depositPictureBox.Location = new Point(71, 15);
            depositPictureBox.Margin = new Padding(3, 4, 3, 4);
            depositPictureBox.Name = "depositPictureBox";
            depositPictureBox.Size = new Size(154, 160);
            depositPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            depositPictureBox.TabIndex = 0;
            depositPictureBox.TabStop = false;
            // 
            // depositTitle
            // 
            depositTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            depositTitle.ForeColor = Color.FromArgb(0, 62, 126);
            depositTitle.Location = new Point(21, 180);
            depositTitle.Name = "depositTitle";
            depositTitle.Size = new Size(237, 53);
            depositTitle.TabIndex = 1;
            depositTitle.Text = "Depósito";
            depositTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // depositDescription
            // 
            depositDescription.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            depositDescription.ForeColor = Color.Black;
            depositDescription.Location = new Point(9, 220);
            depositDescription.Name = "depositDescription";
            depositDescription.Size = new Size(280, 70);
            depositDescription.TabIndex = 2;
            depositDescription.Text = "Disponible las 24 Horas";
            depositDescription.TextAlign = ContentAlignment.MiddleCenter;
            depositDescription.Click += depositDescription_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkSlateBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(43, 285);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(198, 53);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnDeposito_Click;
            // 
            // cardMovements
            // 
            cardMovements.BackColor = Color.MediumOrchid;
            cardMovements.Controls.Add(movementsPictureBox);
            cardMovements.Controls.Add(movementsTitle);
            cardMovements.Controls.Add(movementsDescription);
            cardMovements.Controls.Add(btnConsult);
            cardMovements.Location = new Point(671, 187);
            cardMovements.Margin = new Padding(3, 4, 3, 4);
            cardMovements.Name = "cardMovements";
            cardMovements.Size = new Size(291, 359);
            cardMovements.TabIndex = 2;
            // 
            // movementsPictureBox
            // 
            movementsPictureBox.Image = CLIESC_EUREKA_REST_DOTNET.Properties.Resources.consulta;
            movementsPictureBox.Location = new Point(81, 15);
            movementsPictureBox.Margin = new Padding(3, 4, 3, 4);
            movementsPictureBox.Name = "movementsPictureBox";
            movementsPictureBox.Size = new Size(137, 160);
            movementsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            movementsPictureBox.TabIndex = 0;
            movementsPictureBox.TabStop = false;
            // 
            // movementsTitle
            // 
            movementsTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            movementsTitle.ForeColor = Color.FromArgb(0, 62, 126);
            movementsTitle.Location = new Point(30, 174);
            movementsTitle.Name = "movementsTitle";
            movementsTitle.Size = new Size(233, 64);
            movementsTitle.TabIndex = 1;
            movementsTitle.Text = "Movimientos";
            movementsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movementsDescription
            // 
            movementsDescription.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            movementsDescription.ForeColor = Color.Black;
            movementsDescription.Location = new Point(12, 220);
            movementsDescription.Name = "movementsDescription";
            movementsDescription.Size = new Size(266, 70);
            movementsDescription.TabIndex = 2;
            movementsDescription.Text = "Disponible las 24 Horas";
            movementsDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConsult
            // 
            btnConsult.BackColor = Color.DarkSlateBlue;
            btnConsult.FlatStyle = FlatStyle.Flat;
            btnConsult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsult.ForeColor = Color.White;
            btnConsult.Location = new Point(47, 285);
            btnConsult.Margin = new Padding(3, 4, 3, 4);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(198, 53);
            btnConsult.TabIndex = 3;
            btnConsult.Text = "Consultar";
            btnConsult.UseVisualStyleBackColor = false;
            btnConsult.Click += btnConsulta_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 841);
            Controls.Add(contentPanel);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            Load += MainView_Load;
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cardDeposit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)depositPictureBox).EndInit();
            cardMovements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)movementsPictureBox).EndInit();
            ResumeLayout(false);
        }

        private Panel sidebar;
        private Button btnLogout;
        private PictureBox logoPictureBox;
        private Label lblBankName;
        private Panel contentPanel;
        private Panel cardDeposit;
        private PictureBox depositPictureBox;
        private Label depositTitle;
        private Label depositDescription;
        private Button btnRegister;
        private Panel cardMovements;
        private PictureBox movementsPictureBox;
        private Label movementsTitle;
        private Label movementsDescription;
        private Button btnConsult;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Button btnTransferencia;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button btnRetiro;
    }
}
