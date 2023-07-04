namespace SistemaDeVendas
{
    partial class frmAdminDashBoard
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lbDateTime = new Label();
            label2 = new Label();
            nameSistem = new Label();
            logedUser = new Label();
            lblLogado = new Label();
            MnuStripTop = new MenuStrip();
            btnSales = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            invoiceToolStripMenuItem = new ToolStripMenuItem();
            transitionsToolStripMenuItem = new ToolStripMenuItem();
            labelFooter = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            MnuStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(6, 29, 38);
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(897, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 14);
            label1.TabIndex = 21;
            label1.Text = "Data:";
            // 
            // lbDateTime
            // 
            lbDateTime.AutoSize = true;
            lbDateTime.BackColor = Color.FromArgb(6, 29, 38);
            lbDateTime.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDateTime.ForeColor = SystemColors.MenuHighlight;
            lbDateTime.Location = new Point(950, 30);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(95, 14);
            lbDateTime.TabIndex = 20;
            lbDateTime.Text = "10/10/2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(461, 379);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 19;
            // 
            // nameSistem
            // 
            nameSistem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameSistem.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameSistem.ForeColor = SystemColors.InfoText;
            nameSistem.Location = new Point(338, 187);
            nameSistem.Name = "nameSistem";
            nameSistem.Size = new Size(767, 305);
            nameSistem.TabIndex = 18;
            nameSistem.Text = "Sales of Sistem ";
            nameSistem.TextAlign = ContentAlignment.MiddleCenter;
            nameSistem.Click += nameSistem_Click;
            // 
            // logedUser
            // 
            logedUser.AutoSize = true;
            logedUser.BackColor = Color.FromArgb(6, 29, 38);
            logedUser.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logedUser.ForeColor = Color.DarkGray;
            logedUser.Location = new Point(767, 30);
            logedUser.Name = "logedUser";
            logedUser.Size = new Size(47, 14);
            logedUser.TabIndex = 17;
            logedUser.Text = "User: ";
            // 
            // lblLogado
            // 
            lblLogado.AutoSize = true;
            lblLogado.BackColor = Color.FromArgb(6, 29, 38);
            lblLogado.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogado.ForeColor = SystemColors.MenuHighlight;
            lblLogado.Location = new Point(820, 30);
            lblLogado.Name = "lblLogado";
            lblLogado.Size = new Size(55, 14);
            lblLogado.TabIndex = 16;
            lblLogado.Text = "Logged";
            lblLogado.Click += lblLogado_Click;
            // 
            // MnuStripTop
            // 
            MnuStripTop.BackColor = Color.FromArgb(10, 43, 64);
            MnuStripTop.Dock = DockStyle.Left;
            MnuStripTop.Items.AddRange(new ToolStripItem[] { btnSales, usersToolStripMenuItem, categoryToolStripMenuItem, productsToolStripMenuItem, clientesToolStripMenuItem, invoiceToolStripMenuItem, transitionsToolStripMenuItem });
            MnuStripTop.Location = new Point(0, 61);
            MnuStripTop.Name = "MnuStripTop";
            MnuStripTop.Padding = new Padding(6, 4, 0, 4);
            MnuStripTop.RenderMode = ToolStripRenderMode.Professional;
            MnuStripTop.Size = new Size(292, 557);
            MnuStripTop.TabIndex = 15;
            MnuStripTop.Text = "menuStrip1";
            // 
            // btnSales
            // 
            btnSales.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSales.ForeColor = SystemColors.MenuHighlight;
            btnSales.Image = Properties.Resources.sistemSF12;
            btnSales.ImageScaling = ToolStripItemImageScaling.None;
            btnSales.Margin = new Padding(5, 20, 10, 20);
            btnSales.Name = "btnSales";
            btnSales.Padding = new Padding(0, 0, 0, 20);
            btnSales.Size = new Size(264, 91);
            btnSales.Text = "SALES SISTEM";
            btnSales.Click += toolStripMenuItem1_Click;
            btnSales.MouseEnter += toolStripMenuItem1_MouseEnter;
            btnSales.MouseHover += btnSales_MouseHover;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usersToolStripMenuItem.Image = Properties.Resources.group__1_;
            usersToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usersToolStripMenuItem.Margin = new Padding(5, 0, 0, 0);
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Padding = new Padding(4, 10, 4, 10);
            usersToolStripMenuItem.Size = new Size(274, 56);
            usersToolStripMenuItem.Text = "Usuario";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            categoryToolStripMenuItem.Image = Properties.Resources.categories;
            categoryToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            categoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            categoryToolStripMenuItem.Margin = new Padding(5, 0, 0, 0);
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Padding = new Padding(4, 10, 4, 10);
            categoryToolStripMenuItem.Size = new Size(274, 56);
            categoryToolStripMenuItem.Text = "Categoria";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productsToolStripMenuItem.Image = Properties.Resources.features__1_;
            productsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            productsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            productsToolStripMenuItem.Margin = new Padding(5, 0, 0, 0);
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Padding = new Padding(4, 10, 4, 10);
            productsToolStripMenuItem.Size = new Size(274, 56);
            productsToolStripMenuItem.Text = "Produto";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientesToolStripMenuItem.Image = Properties.Resources.customer__1_;
            clientesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            clientesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            clientesToolStripMenuItem.Margin = new Padding(5, 0, 0, 0);
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Padding = new Padding(4, 10, 4, 10);
            clientesToolStripMenuItem.Size = new Size(274, 56);
            clientesToolStripMenuItem.Text = "Cliente";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // invoiceToolStripMenuItem
            // 
            invoiceToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            invoiceToolStripMenuItem.Image = Properties.Resources.inventory__1_;
            invoiceToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            invoiceToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            invoiceToolStripMenuItem.Margin = new Padding(5, 0, 0, 0);
            invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            invoiceToolStripMenuItem.Padding = new Padding(4, 10, 4, 10);
            invoiceToolStripMenuItem.Size = new Size(274, 56);
            invoiceToolStripMenuItem.Text = "Inventario";
            invoiceToolStripMenuItem.Click += invoiceToolStripMenuItem_Click;
            // 
            // transitionsToolStripMenuItem
            // 
            transitionsToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transitionsToolStripMenuItem.Image = Properties.Resources.transaction__1_;
            transitionsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            transitionsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            transitionsToolStripMenuItem.Margin = new Padding(5, 0, 0, 0);
            transitionsToolStripMenuItem.Name = "transitionsToolStripMenuItem";
            transitionsToolStripMenuItem.Padding = new Padding(4, 10, 4, 10);
            transitionsToolStripMenuItem.Size = new Size(274, 56);
            transitionsToolStripMenuItem.Text = "Transações";
            transitionsToolStripMenuItem.Click += transitionsToolStripMenuItem_Click;
            // 
            // labelFooter
            // 
            labelFooter.BackColor = Color.FromArgb(6, 29, 38);
            labelFooter.Dock = DockStyle.Bottom;
            labelFooter.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelFooter.Location = new Point(292, 557);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(861, 61);
            labelFooter.TabIndex = 22;
            labelFooter.Text = "Developement by Anderson Sistemas";
            labelFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(6, 29, 38);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1153, 61);
            label3.TabIndex = 23;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(6, 29, 38);
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(1111, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(10, 43, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Image = Properties.Resources.logout;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1050, 564);
            button1.Name = "button1";
            button1.Size = new Size(93, 46);
            button1.TabIndex = 27;
            button1.Text = "Logout";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmAdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1153, 618);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(labelFooter);
            Controls.Add(label1);
            Controls.Add(lbDateTime);
            Controls.Add(label2);
            Controls.Add(nameSistem);
            Controls.Add(logedUser);
            Controls.Add(lblLogado);
            Controls.Add(MnuStripTop);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel Administrador";
            WindowState = FormWindowState.Maximized;
            Load += frmAdminDashBoard_Load;
            MnuStripTop.ResumeLayout(false);
            MnuStripTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label lbDateTime;
        private Label label2;
        private Label nameSistem;
        private Label logedUser;
        public Label lblLogado;
        private MenuStrip MnuStripTop;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem invoiceToolStripMenuItem;
        private ToolStripMenuItem transitionsToolStripMenuItem;
        private Label labelFooter;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem btnSales;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
    }
}