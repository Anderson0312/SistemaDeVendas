namespace SistemaDeVendas.FormulariosUI
{
    partial class frmInventario
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
            dvgInventario = new DataGridView();
            btnSearch = new Button();
            cmbSearchCateg = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgInventario).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dvgInventario
            // 
            dvgInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgInventario.Location = new Point(12, 103);
            dvgInventario.Name = "dvgInventario";
            dvgInventario.RowTemplate.Height = 25;
            dvgInventario.Size = new Size(1115, 512);
            dvgInventario.TabIndex = 62;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(979, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 34);
            btnSearch.TabIndex = 61;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbSearchCateg
            // 
            cmbSearchCateg.FormattingEnabled = true;
            cmbSearchCateg.Items.AddRange(new object[] { "Compra", "Venda" });
            cmbSearchCateg.Location = new Point(153, 71);
            cmbSearchCateg.Name = "cmbSearchCateg";
            cmbSearchCateg.Size = new Size(742, 23);
            cmbSearchCateg.TabIndex = 60;
            cmbSearchCateg.SelectedIndexChanged += cmbSearchCateg_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 73);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 59;
            label2.Text = "Categorias :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 57);
            panel1.TabIndex = 58;
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
            label1.Location = new Point(506, 14);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 627);
            Controls.Add(dvgInventario);
            Controls.Add(btnSearch);
            Controls.Add(cmbSearchCateg);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInventario";
            Load += frmInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dvgInventario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgInventario;
        private Button btnSearch;
        private ComboBox cmbSearchCateg;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}