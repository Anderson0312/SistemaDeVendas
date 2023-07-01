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
            txtUsername = new TextBox();
            cmbUserType = new ComboBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            pictureBox4 = new PictureBox();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Lime;
            btnLogin.Location = new Point(591, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 45);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtUsername);
            panel2.Location = new Point(175, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 50);
            panel2.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(64, 64, 64);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(3, 13);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(298, 23);
            txtUsername.TabIndex = 1;
            // 
            // cmbUserType
            // 
            cmbUserType.BackColor = Color.FromArgb(64, 64, 64);
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "Usuario\t", "Administrador" });
            cmbUserType.Location = new Point(3, 13);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(298, 23);
            cmbUserType.TabIndex = 6;
            cmbUserType.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(80, 188);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 4;
            label4.Text = "Type User";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(64, 64, 64);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(3, 13);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(298, 23);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(80, 116);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 47);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 0;
            label2.Text = "User Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 29, 38);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(938, 39);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 447);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(903, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(10, 43, 64);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(0, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(344, 384);
            panel4.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(32, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(645, 59);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtPassword);
            panel5.Location = new Point(175, 105);
            panel5.Name = "panel5";
            panel5.Size = new Size(306, 50);
            panel5.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cadeado;
            pictureBox3.Location = new Point(32, 105);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(cmbUserType);
            panel6.Location = new Point(175, 176);
            panel6.Name = "panel6";
            panel6.Size = new Size(306, 50);
            panel6.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.type;
            pictureBox4.Location = new Point(32, 176);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(panel2);
            panel7.Location = new Point(383, 81);
            panel7.Name = "panel7";
            panel7.Size = new Size(506, 248);
            panel7.TabIndex = 13;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.sistemSF11;
            pictureBox5.Location = new Point(12, 67);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(320, 224);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(938, 420);
            Controls.Add(panel7);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(btnLogin);
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
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Panel panel7;
        private PictureBox pictureBox5;
    }
}