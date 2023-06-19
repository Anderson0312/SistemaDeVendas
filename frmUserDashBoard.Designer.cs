namespace SistemaDeVendas
{
    partial class frmUserDashBoard
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
            label1 = new Label();
            lbDateTime = new Label();
            label2 = new Label();
            nameSistem = new Label();
            logedUser = new Label();
            lblLogado = new Label();
            MnuStripTop = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            labelFooter = new Label();
            MnuStripTop.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 14);
            label1.TabIndex = 20;
            label1.Text = "Data:";
            // 
            // lbDateTime
            // 
            lbDateTime.AutoSize = true;
            lbDateTime.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDateTime.ForeColor = SystemColors.MenuHighlight;
            lbDateTime.Location = new Point(65, 41);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(95, 14);
            lbDateTime.TabIndex = 19;
            lbDateTime.Text = "10/10/2023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(492, 362);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 18;
            // 
            // nameSistem
            // 
            nameSistem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameSistem.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameSistem.ForeColor = SystemColors.InfoText;
            nameSistem.Location = new Point(178, 151);
            nameSistem.Name = "nameSistem";
            nameSistem.Size = new Size(845, 270);
            nameSistem.TabIndex = 17;
            nameSistem.Text = "Sales of Sistem ";
            nameSistem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logedUser
            // 
            logedUser.AutoSize = true;
            logedUser.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logedUser.Location = new Point(12, 69);
            logedUser.Name = "logedUser";
            logedUser.Size = new Size(47, 14);
            logedUser.TabIndex = 16;
            logedUser.Text = "User: ";
            // 
            // lblLogado
            // 
            lblLogado.AutoSize = true;
            lblLogado.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogado.ForeColor = SystemColors.MenuHighlight;
            lblLogado.Location = new Point(65, 69);
            lblLogado.Name = "lblLogado";
            lblLogado.Size = new Size(55, 14);
            lblLogado.TabIndex = 15;
            lblLogado.Text = "Logged";
            // 
            // MnuStripTop
            // 
            MnuStripTop.BackColor = SystemColors.InactiveCaption;
            MnuStripTop.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, categoryToolStripMenuItem, productsToolStripMenuItem });
            MnuStripTop.Location = new Point(0, 0);
            MnuStripTop.Name = "MnuStripTop";
            MnuStripTop.Padding = new Padding(6, 4, 0, 4);
            MnuStripTop.Size = new Size(1135, 27);
            MnuStripTop.TabIndex = 14;
            MnuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(39, 19);
            usersToolStripMenuItem.Text = "Buy";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(45, 19);
            categoryToolStripMenuItem.Text = "Sales";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(69, 19);
            productsToolStripMenuItem.Text = "Inventory";
            // 
            // labelFooter
            // 
            labelFooter.BackColor = SystemColors.GradientActiveCaption;
            labelFooter.Dock = DockStyle.Bottom;
            labelFooter.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelFooter.Location = new Point(0, 501);
            labelFooter.Name = "labelFooter";
            labelFooter.Size = new Size(1135, 61);
            labelFooter.TabIndex = 21;
            labelFooter.Text = "Developement by Anderson Sistemas";
            labelFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmUserDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1135, 562);
            Controls.Add(labelFooter);
            Controls.Add(label1);
            Controls.Add(lbDateTime);
            Controls.Add(label2);
            Controls.Add(nameSistem);
            Controls.Add(logedUser);
            Controls.Add(lblLogado);
            Controls.Add(MnuStripTop);
            Name = "frmUserDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel Usuario";
            WindowState = FormWindowState.Maximized;
            MnuStripTop.ResumeLayout(false);
            MnuStripTop.PerformLayout();
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
        private Label labelFooter;
    }
}