namespace SistemaDeVendas
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            panel2 = new Panel();
            cmbUserType = new ComboBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(212, 430);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbUserType);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(57, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 325);
            panel2.TabIndex = 5;
            // 
            // cmbUserType
            // 
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "Usuario\t", "Administrador" });
            cmbUserType.Location = new Point(47, 259);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(321, 23);
            cmbUserType.TabIndex = 6;
            cmbUserType.Text = "Usuario\t";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(47, 226);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 4;
            label4.Text = "Tipo Usuario";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveBorder;
            txtPassword.Location = new Point(47, 151);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(321, 23);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(47, 127);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(47, 61);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(321, 23);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(47, 37);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 59);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 14);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(480, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(530, 487);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Panel panel2;
        private ComboBox cmbUserType;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}