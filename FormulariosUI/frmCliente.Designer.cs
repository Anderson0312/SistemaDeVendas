namespace SistemaDeVendas
{
    partial class frmCliente
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
            btnDelete = new Button();
            btnAtualizar = new Button();
            btnConfirm = new Button();
            txtSearch = new TextBox();
            label12 = new Label();
            txtAdrress = new TextBox();
            label9 = new Label();
            txtContac = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtClientName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtClientID = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmbtype = new ComboBox();
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
            btnLimpar.Location = new Point(236, 389);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(93, 32);
            btnLimpar.TabIndex = 86;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dtgView
            // 
            dtgView.BackgroundColor = Color.FromArgb(50, 97, 115);
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(488, 103);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(601, 318);
            dtgView.TabIndex = 85;
            dtgView.RowHeaderMouseClick += dtgView_RowHeaderMouseClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(348, 389);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 32);
            btnDelete.TabIndex = 82;
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
            btnAtualizar.Location = new Point(124, 389);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(93, 32);
            btnAtualizar.TabIndex = 81;
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
            btnConfirm.Location = new Point(12, 389);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(93, 32);
            btnConfirm.TabIndex = 80;
            btnConfirm.Text = "CONFIRMAR";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(50, 97, 115);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(582, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 23);
            txtSearch.TabIndex = 79;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(488, 70);
            label12.Name = "label12";
            label12.Size = new Size(69, 21);
            label12.TabIndex = 78;
            label12.Text = "Search :";
            // 
            // txtAdrress
            // 
            txtAdrress.BackColor = Color.FromArgb(50, 97, 115);
            txtAdrress.BorderStyle = BorderStyle.FixedSingle;
            txtAdrress.Location = new Point(149, 219);
            txtAdrress.Multiline = true;
            txtAdrress.Name = "txtAdrress";
            txtAdrress.Size = new Size(292, 126);
            txtAdrress.TabIndex = 75;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 240);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 74;
            label9.Text = "Adrress :";
            // 
            // txtContac
            // 
            txtContac.BackColor = Color.FromArgb(50, 97, 115);
            txtContac.BorderStyle = BorderStyle.FixedSingle;
            txtContac.Location = new Point(149, 188);
            txtContac.Name = "txtContac";
            txtContac.Size = new Size(292, 23);
            txtContac.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 190);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 68;
            label6.Text = "Contato :";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(50, 97, 115);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(149, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 23);
            txtEmail.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 66;
            label5.Text = "Email :";
            // 
            // txtClientName
            // 
            txtClientName.BackColor = Color.FromArgb(50, 97, 115);
            txtClientName.BorderStyle = BorderStyle.FixedSingle;
            txtClientName.Location = new Point(149, 130);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(292, 23);
            txtClientName.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 64;
            label4.Text = "Nome :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 62;
            label3.Text = "Tipo :";
            // 
            // txtClientID
            // 
            txtClientID.AccessibleRole = AccessibleRole.None;
            txtClientID.BackColor = Color.FromArgb(50, 97, 115);
            txtClientID.BorderStyle = BorderStyle.FixedSingle;
            txtClientID.Enabled = false;
            txtClientID.Location = new Point(149, 72);
            txtClientID.Name = "txtClientID";
            txtClientID.ReadOnly = true;
            txtClientID.ShortcutsEnabled = false;
            txtClientID.Size = new Size(292, 23);
            txtClientID.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 60;
            label2.Text = "ID Cliente :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 29, 38);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 57);
            panel1.TabIndex = 59;
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
            label1.Size = new Size(203, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cliente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbtype
            // 
            cmbtype.BackColor = Color.FromArgb(50, 97, 115);
            cmbtype.FormattingEnabled = true;
            cmbtype.Items.AddRange(new object[] { "Cliente", "Revendedor" });
            cmbtype.Location = new Point(149, 101);
            cmbtype.Name = "cmbtype";
            cmbtype.Size = new Size(292, 23);
            cmbtype.TabIndex = 87;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 97, 115);
            ClientSize = new Size(1107, 453);
            Controls.Add(cmbtype);
            Controls.Add(btnLimpar);
            Controls.Add(dtgView);
            Controls.Add(btnDelete);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConfirm);
            Controls.Add(txtSearch);
            Controls.Add(label12);
            Controls.Add(txtAdrress);
            Controls.Add(label9);
            Controls.Add(txtContac);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtClientName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtClientID);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCliente";
            Load += frmCliente_Load;
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
        private Button btnDelete;
        private Button btnAtualizar;
        private Button btnConfirm;
        private TextBox txtSearch;
        private Label label12;
        private TextBox txtAdrress;
        private Label label9;
        private TextBox txtContac;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtClientName;
        private Label label4;
        private Label label3;
        private TextBox txtClientID;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cmbtype;
    }
}