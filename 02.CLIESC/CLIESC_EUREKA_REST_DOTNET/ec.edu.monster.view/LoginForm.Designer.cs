namespace ec.edu.monster.view
{
    partial class LoginForm
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
            infoPanel = new Panel();
            logoPictureBox = new PictureBox();
            lblTitle = new Label();
            lblMessage = new Label();
            lblFooter = new Label();
            formPanel = new Panel();
            lblWelcome = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            formPanel.SuspendLayout();
            SuspendLayout();
            // 
            // infoPanel
            // 
            infoPanel.BackColor = Color.FromArgb(255, 192, 255);
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.Location = new Point(0, 0);
            infoPanel.Margin = new Padding(3, 4, 3, 4);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(914, 667);
            infoPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = CLIESC_EUREKA_REST_DOTNET.Properties.Resources.IMAGEN;
            logoPictureBox.Location = new Point(358, 141);
            logoPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(233, 153);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(0, 62, 126);
            lblTitle.Location = new Point(408, 65);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(119, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Grupo 6";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.Black;
            lblMessage.Location = new Point(395, 105);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(158, 32);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Morales Tello";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Click += lblTitle_Click;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.Transparent;
            lblFooter.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFooter.ForeColor = Color.Black;
            lblFooter.Location = new Point(305, 588);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(343, 53);
            lblFooter.TabIndex = 3;
            lblFooter.Text = "2025 - 2026";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.FromArgb(255, 192, 255);
            formPanel.Controls.Add(lblFooter);
            formPanel.Controls.Add(lblMessage);
            formPanel.Controls.Add(lblTitle);
            formPanel.Controls.Add(logoPictureBox);
            formPanel.Controls.Add(lblWelcome);
            formPanel.Controls.Add(lblUsername);
            formPanel.Controls.Add(txtUsername);
            formPanel.Controls.Add(lblPassword);
            formPanel.Controls.Add(txtPassword);
            formPanel.Controls.Add(btnLogin);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Location = new Point(0, 0);
            formPanel.Margin = new Padding(3, 4, 3, 4);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(914, 667);
            formPanel.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.FromArgb(0, 62, 126);
            lblWelcome.Location = new Point(335, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(269, 38);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Eureka Bank";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(306, 322);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(72, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Usuario:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(306, 349);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(342, 26);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(306, 416);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(306, 443);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(342, 26);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Fuchsia;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(0, 62, 126);
            btnLogin.Location = new Point(305, 501);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(343, 53);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 667);
            Controls.Add(formPanel);
            Controls.Add(infoPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel infoPanel;
        private PictureBox logoPictureBox;
        private Label lblTitle;
        private Label lblMessage;
        private Label lblFooter;
        private Panel formPanel;
        private Label lblWelcome;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
