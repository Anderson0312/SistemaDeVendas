namespace SistemaDeVendas
{
    partial class frmCategoria
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
            txtDesc = new TextBox();
            label4 = new Label();
            txtTituloCatego = new TextBox();
            label3 = new Label();
            txtCategoriaID = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(517, 116);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(601, 287);
            dtgView.TabIndex = 51;
            dtgView.RowHeaderMouseClick += dtgView_RowHeaderMouseClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(611, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 23);
            txtSearch.TabIndex = 50;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(517, 83);
            label12.Name = "label12";
            label12.Size = new Size(69, 21);
            label12.TabIndex = 49;
            label12.Text = "Search :";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 128, 0);
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.ButtonFace;
            btnLimpar.Location = new Point(257, 371);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(93, 32);
            btnLimpar.TabIndex = 48;
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
            btnDelete.Location = new Point(369, 371);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 32);
            btnDelete.TabIndex = 47;
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
            btnAtualizar.Location = new Point(145, 371);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(93, 32);
            btnAtualizar.TabIndex = 46;
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
            btnConfirm.Location = new Point(33, 371);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(93, 32);
            btnConfirm.TabIndex = 45;
            btnConfirm.Text = "CONFIRMAR";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(170, 143);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(292, 207);
            txtDesc.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 214);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 43;
            label4.Text = "Descrição:";
            // 
            // txtTituloCatego
            // 
            txtTituloCatego.Location = new Point(170, 114);
            txtTituloCatego.Name = "txtTituloCatego";
            txtTituloCatego.Size = new Size(292, 23);
            txtTituloCatego.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 116);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 41;
            label3.Text = "Titulo Categoria:";
            // 
            // txtCategoriaID
            // 
            txtCategoriaID.AccessibleRole = AccessibleRole.None;
            txtCategoriaID.Enabled = false;
            txtCategoriaID.Location = new Point(170, 85);
            txtCategoriaID.Name = "txtCategoriaID";
            txtCategoriaID.ReadOnly = true;
            txtCategoriaID.ShortcutsEnabled = false;
            txtCategoriaID.Size = new Size(292, 23);
            txtCategoriaID.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 87);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 39;
            label2.Text = "ID Categoria :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 57);
            panel1.TabIndex = 38;
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
            label1.Location = new Point(459, 14);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Categoria";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1147, 429);
            Controls.Add(dtgView);
            Controls.Add(txtSearch);
            Controls.Add(label12);
            Controls.Add(btnLimpar);
            Controls.Add(btnDelete);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConfirm);
            Controls.Add(txtDesc);
            Controls.Add(label4);
            Controls.Add(txtTituloCatego);
            Controls.Add(label3);
            Controls.Add(txtCategoriaID);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoria";
            Load += frmCategoria_Load;
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
        private TextBox txtDesc;
        private Label label4;
        private TextBox txtTituloCatego;
        private Label label3;
        private TextBox txtCategoriaID;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}