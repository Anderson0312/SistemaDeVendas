namespace SistemaDeVendas
{
    partial class frmUsers
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
            btnLimpar = new Button();
            dtgView = new DataGridView();
            cmbSex = new ComboBox();
            cmbTypeUser = new ComboBox();
            btnDelete = new Button();
            btnAtualizar = new Button();
            btnConfirm = new Button();
            txtSearch = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtAdrress = new TextBox();
            label9 = new Label();
            txtPhoneNumber = new TextBox();
            label8 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtUserName = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtUserID = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 128, 0);
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.ButtonFace;
            btnLimpar.Location = new Point(248, 434);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(93, 32);
            btnLimpar.TabIndex = 58;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dtgView
            // 
            dtgView.BackgroundColor = Color.FromArgb(50, 97, 115);
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(500, 107);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(601, 359);
            dtgView.TabIndex = 57;
            dtgView.RowHeaderMouseClick += dtgView_RowHeaderMouseClick;
            // 
            // cmbSex
            // 
            cmbSex.BackColor = Color.FromArgb(50, 97, 115);
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Masculine", "Feminine" });
            cmbSex.Location = new Point(161, 355);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(292, 23);
            cmbSex.TabIndex = 56;
            // 
            // cmbTypeUser
            // 
            cmbTypeUser.BackColor = Color.FromArgb(50, 97, 115);
            cmbTypeUser.FormattingEnabled = true;
            cmbTypeUser.Items.AddRange(new object[] { "Usuario", "Administrador" });
            cmbTypeUser.Location = new Point(161, 384);
            cmbTypeUser.Name = "cmbTypeUser";
            cmbTypeUser.Size = new Size(292, 23);
            cmbTypeUser.TabIndex = 55;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(360, 434);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 32);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "DELETAR";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Yellow;
            btnAtualizar.FlatStyle = FlatStyle.Popup;
            btnAtualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnAtualizar.Location = new Point(136, 434);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(93, 32);
            btnAtualizar.TabIndex = 53;
            btnAtualizar.Text = "ATUALIZAR";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = SystemColors.ButtonFace;
            btnConfirm.Location = new Point(24, 434);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(93, 32);
            btnConfirm.TabIndex = 52;
            btnConfirm.Text = "CONFIRMAR";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(50, 97, 115);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(594, 74);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 23);
            txtSearch.TabIndex = 51;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(500, 74);
            label12.Name = "label12";
            label12.Size = new Size(69, 21);
            label12.TabIndex = 50;
            label12.Text = "Search :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(24, 382);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 49;
            label11.Text = "Type User :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(24, 353);
            label10.Name = "label10";
            label10.Size = new Size(45, 21);
            label10.TabIndex = 48;
            label10.Text = "Sex :";
            // 
            // txtAdrress
            // 
            txtAdrress.BackColor = Color.FromArgb(50, 97, 115);
            txtAdrress.BorderStyle = BorderStyle.FixedSingle;
            txtAdrress.Location = new Point(161, 279);
            txtAdrress.Multiline = true;
            txtAdrress.Name = "txtAdrress";
            txtAdrress.Size = new Size(292, 66);
            txtAdrress.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 300);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 46;
            label9.Text = "Adrress :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(50, 97, 115);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(161, 250);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(292, 23);
            txtPhoneNumber.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 252);
            label8.Name = "label8";
            label8.Size = new Size(131, 21);
            label8.TabIndex = 44;
            label8.Text = "Phone Number:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(50, 97, 115);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(161, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(292, 23);
            txtPassword.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 223);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 42;
            label7.Text = "Password :";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(50, 97, 115);
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(161, 192);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(292, 23);
            txtUserName.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 194);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 40;
            label6.Text = "User Name :";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(50, 97, 115);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(161, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 23);
            txtEmail.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 165);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 38;
            label5.Text = "Email :";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(50, 97, 115);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(161, 134);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(292, 23);
            txtLastName.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 136);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 36;
            label4.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(50, 97, 115);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(161, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(292, 23);
            txtFirstName.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 107);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 34;
            label3.Text = "First Name :";
            // 
            // txtUserID
            // 
            txtUserID.AccessibleRole = AccessibleRole.None;
            txtUserID.BackColor = Color.FromArgb(50, 97, 115);
            txtUserID.BorderStyle = BorderStyle.FixedSingle;
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(161, 76);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.ShortcutsEnabled = false;
            txtUserID.Size = new Size(292, 23);
            txtUserID.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 32;
            label2.Text = "ID Usuario :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 29, 38);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 57);
            panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(1057, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(459, 14);
            label1.Name = "label1";
            label1.Size = new Size(210, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 97, 115);
            ClientSize = new Size(1142, 492);
            Controls.Add(btnLimpar);
            Controls.Add(dtgView);
            Controls.Add(cmbSex);
            Controls.Add(cmbTypeUser);
            Controls.Add(btnDelete);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConfirm);
            Controls.Add(txtSearch);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtAdrress);
            Controls.Add(label9);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label8);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtUserName);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtUserID);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(385, 120);
            Name = "frmUsers";
            StartPosition = FormStartPosition.Manual;
            Text = "frmUsers";
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private DataGridView dtgView;
        private ComboBox cmbSex;
        private ComboBox cmbTypeUser;
        private Button btnDelete;
        private Button btnAtualizar;
        private Button btnConfirm;
        private TextBox txtSearch;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtAdrress;
        private Label label9;
        private TextBox txtPhoneNumber;
        private Label label8;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtUserName;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtUserID;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}