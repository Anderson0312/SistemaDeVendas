namespace SistemaDeVendas
{
    partial class frmProduto
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
            dtgView = new DataGridView();
            txtSearch = new TextBox();
            label12 = new Label();
            btnLimpar = new Button();
            btnDelete = new Button();
            btnAtualizar = new Button();
            btnConfirm = new Button();
            txtDescProd = new TextBox();
            label4 = new Label();
            txtNomeProd = new TextBox();
            label3 = new Label();
            txtIDProd = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            txtPrecoProd = new TextBox();
            label6 = new Label();
            txtQuanti = new TextBox();
            label7 = new Label();
            txtCatProd = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgView
            // 
            dtgView.BackgroundColor = Color.FromArgb(50, 97, 115);
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(511, 121);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(601, 340);
            dtgView.TabIndex = 65;
            dtgView.RowHeaderMouseClick += dtgView_RowHeaderMouseClick;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(50, 97, 115);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(605, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 23);
            txtSearch.TabIndex = 64;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(511, 88);
            label12.Name = "label12";
            label12.Size = new Size(69, 21);
            label12.TabIndex = 63;
            label12.Text = "Search :";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 128, 0);
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.ButtonFace;
            btnLimpar.Location = new Point(251, 429);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(93, 32);
            btnLimpar.TabIndex = 62;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(363, 429);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 32);
            btnDelete.TabIndex = 61;
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
            btnAtualizar.Location = new Point(139, 429);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(93, 32);
            btnAtualizar.TabIndex = 60;
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
            btnConfirm.Location = new Point(27, 429);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(93, 32);
            btnConfirm.TabIndex = 59;
            btnConfirm.Text = "CONFIRMAR";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtDescProd
            // 
            txtDescProd.BackColor = Color.FromArgb(50, 97, 115);
            txtDescProd.BorderStyle = BorderStyle.FixedSingle;
            txtDescProd.Location = new Point(164, 178);
            txtDescProd.Multiline = true;
            txtDescProd.Name = "txtDescProd";
            txtDescProd.Size = new Size(292, 168);
            txtDescProd.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 249);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 57;
            label4.Text = "Descrição:";
            // 
            // txtNomeProd
            // 
            txtNomeProd.BackColor = Color.FromArgb(50, 97, 115);
            txtNomeProd.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProd.Location = new Point(164, 119);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(292, 23);
            txtNomeProd.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 55;
            label3.Text = "Nome Produto :";
            // 
            // txtIDProd
            // 
            txtIDProd.AccessibleRole = AccessibleRole.None;
            txtIDProd.BackColor = Color.FromArgb(50, 97, 115);
            txtIDProd.BorderStyle = BorderStyle.FixedSingle;
            txtIDProd.Enabled = false;
            txtIDProd.Location = new Point(164, 90);
            txtIDProd.Name = "txtIDProd";
            txtIDProd.ReadOnly = true;
            txtIDProd.ShortcutsEnabled = false;
            txtIDProd.Size = new Size(292, 23);
            txtIDProd.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 92);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 53;
            label2.Text = "ID Produto :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 29, 38);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 57);
            panel1.TabIndex = 52;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(1089, 12);
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
            label1.Size = new Size(216, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 151);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 66;
            label5.Text = "Categoria :";
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.BackColor = Color.FromArgb(50, 97, 115);
            txtPrecoProd.BorderStyle = BorderStyle.FixedSingle;
            txtPrecoProd.Location = new Point(164, 352);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.Size = new Size(292, 23);
            txtPrecoProd.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 354);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 68;
            label6.Text = "Preço :";
            // 
            // txtQuanti
            // 
            txtQuanti.BackColor = Color.FromArgb(50, 97, 115);
            txtQuanti.BorderStyle = BorderStyle.FixedSingle;
            txtQuanti.Location = new Point(164, 382);
            txtQuanti.Name = "txtQuanti";
            txtQuanti.Size = new Size(292, 23);
            txtQuanti.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 384);
            label7.Name = "label7";
            label7.Size = new Size(108, 21);
            label7.TabIndex = 70;
            label7.Text = "Quantidade :";
            // 
            // txtCatProd
            // 
            txtCatProd.BackColor = Color.FromArgb(50, 97, 115);
            txtCatProd.FormattingEnabled = true;
            txtCatProd.Items.AddRange(new object[] { "1" });
            txtCatProd.Location = new Point(164, 148);
            txtCatProd.Name = "txtCatProd";
            txtCatProd.Size = new Size(292, 23);
            txtCatProd.TabIndex = 72;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 97, 115);
            ClientSize = new Size(1133, 487);
            Controls.Add(txtCatProd);
            Controls.Add(txtQuanti);
            Controls.Add(label7);
            Controls.Add(txtPrecoProd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtgView);
            Controls.Add(txtSearch);
            Controls.Add(label12);
            Controls.Add(btnLimpar);
            Controls.Add(btnDelete);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConfirm);
            Controls.Add(txtDescProd);
            Controls.Add(label4);
            Controls.Add(txtNomeProd);
            Controls.Add(label3);
            Controls.Add(txtIDProd);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(400, 120);
            Name = "frmProduto";
            StartPosition = FormStartPosition.Manual;
            Text = "frmProduto";
            Load += frmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgView;
        private TextBox txtSearch;
        private Label label12;
        private Button btnLimpar;
        private Button btnDelete;
        private Button btnAtualizar;
        private Button btnConfirm;
        private TextBox txtDescProd;
        private Label label4;
        private TextBox txtNomeProd;
        private Label label3;
        private TextBox txtIDProd;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private TextBox txtPrecoProd;
        private Label label6;
        private TextBox txtQuanti;
        private Label label7;
        private ComboBox txtCatProd;
    }
}