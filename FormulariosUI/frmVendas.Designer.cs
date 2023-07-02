namespace SistemaDeVendas.FormulariosUI
{
    partial class frmVendas
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
            panel1 = new Panel();
            lblTopo = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            cmbData = new DateTimePicker();
            txtEndercoCliente = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtContatoCli = new TextBox();
            label5 = new Label();
            txtEmailCli = new TextBox();
            label6 = new Label();
            txtNomeCli = new TextBox();
            label4 = new Label();
            txtSearchCli = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnCadastrarProd = new Button();
            txtValor = new TextBox();
            label16 = new Label();
            txtQuanti = new TextBox();
            label11 = new Label();
            txtInventario = new TextBox();
            label12 = new Label();
            txtNomeProd = new TextBox();
            label13 = new Label();
            txtsearchProd = new TextBox();
            label14 = new Label();
            label15 = new Label();
            panel4 = new Panel();
            dgvAddedProducts = new DataGridView();
            label20 = new Label();
            panel5 = new Panel();
            txtTroco = new TextBox();
            label17 = new Label();
            txtTotalPago = new TextBox();
            label22 = new Label();
            txtTotalGeral = new TextBox();
            label9 = new Label();
            txtImpost = new TextBox();
            label10 = new Label();
            btnFinalizar = new Button();
            txtDescont = new TextBox();
            label18 = new Label();
            txtSubTotal = new TextBox();
            label19 = new Label();
            label21 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 29, 38);
            panel1.Controls.Add(lblTopo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 49);
            panel1.TabIndex = 32;
            // 
            // lblTopo
            // 
            lblTopo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTopo.AutoSize = true;
            lblTopo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopo.ForeColor = SystemColors.MenuHighlight;
            lblTopo.Location = new Point(566, 9);
            lblTopo.Name = "lblTopo";
            lblTopo.Size = new Size(65, 30);
            lblTopo.TabIndex = 3;
            lblTopo.Text = "Label";
            lblTopo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delete;
            pictureBox1.Location = new Point(1150, 9);
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
            label1.Location = new Point(459, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "Pedido de";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbData);
            panel2.Controls.Add(txtEndercoCliente);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtContatoCli);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtEmailCli);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtNomeCli);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtSearchCli);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(1186, 115);
            panel2.TabIndex = 33;
            // 
            // cmbData
            // 
            cmbData.Location = new Point(889, 34);
            cmbData.Name = "cmbData";
            cmbData.Size = new Size(280, 23);
            cmbData.TabIndex = 36;
            // 
            // txtEndercoCliente
            // 
            txtEndercoCliente.BackColor = Color.FromArgb(50, 97, 115);
            txtEndercoCliente.BorderStyle = BorderStyle.FixedSingle;
            txtEndercoCliente.Location = new Point(962, 63);
            txtEndercoCliente.Multiline = true;
            txtEndercoCliente.Name = "txtEndercoCliente";
            txtEndercoCliente.Size = new Size(207, 23);
            txtEndercoCliente.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(840, 69);
            label8.Name = "label8";
            label8.Size = new Size(116, 17);
            label8.TabIndex = 10;
            label8.Text = "Endereço Cliente :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(840, 40);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 9;
            label7.Text = "Data :";
            // 
            // txtContatoCli
            // 
            txtContatoCli.BackColor = Color.FromArgb(50, 97, 115);
            txtContatoCli.BorderStyle = BorderStyle.FixedSingle;
            txtContatoCli.Location = new Point(510, 63);
            txtContatoCli.Name = "txtContatoCli";
            txtContatoCli.Size = new Size(315, 23);
            txtContatoCli.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(431, 69);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 7;
            label5.Text = "Contato :";
            // 
            // txtEmailCli
            // 
            txtEmailCli.BackColor = Color.FromArgb(50, 97, 115);
            txtEmailCli.BorderStyle = BorderStyle.FixedSingle;
            txtEmailCli.Location = new Point(510, 34);
            txtEmailCli.Name = "txtEmailCli";
            txtEmailCli.Size = new Size(315, 23);
            txtEmailCli.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(431, 40);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 5;
            label6.Text = "Email :";
            // 
            // txtNomeCli
            // 
            txtNomeCli.BackColor = Color.FromArgb(50, 97, 115);
            txtNomeCli.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCli.Location = new Point(94, 69);
            txtNomeCli.Name = "txtNomeCli";
            txtNomeCli.Size = new Size(315, 23);
            txtNomeCli.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 75);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 3;
            label4.Text = "Nome :";
            // 
            // txtSearchCli
            // 
            txtSearchCli.BackColor = Color.FromArgb(50, 97, 115);
            txtSearchCli.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCli.Location = new Point(94, 40);
            txtSearchCli.Name = "txtSearchCli";
            txtSearchCli.Size = new Size(315, 23);
            txtSearchCli.TabIndex = 2;
            txtSearchCli.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 46);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 1;
            label3.Text = "Pesquisar :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 0;
            label2.Text = "DETALHE DO CLIENTE";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnCadastrarProd);
            panel3.Controls.Add(txtValor);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(txtQuanti);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtInventario);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtNomeProd);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtsearchProd);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(12, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(1186, 115);
            panel3.TabIndex = 34;
            // 
            // btnCadastrarProd
            // 
            btnCadastrarProd.BackColor = Color.Green;
            btnCadastrarProd.FlatStyle = FlatStyle.Flat;
            btnCadastrarProd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarProd.Location = new Point(1019, 29);
            btnCadastrarProd.Name = "btnCadastrarProd";
            btnCadastrarProd.Size = new Size(110, 49);
            btnCadastrarProd.TabIndex = 38;
            btnCadastrarProd.Text = "ADICIONAR ITEM";
            btnCadastrarProd.UseVisualStyleBackColor = false;
            btnCadastrarProd.Click += btnCadastrarProd_Click;
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.FromArgb(50, 97, 115);
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Location = new Point(718, 63);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(114, 23);
            txtValor.TabIndex = 37;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(639, 69);
            label16.Name = "label16";
            label16.Size = new Size(45, 17);
            label16.TabIndex = 36;
            label16.Text = "Valor :";
            // 
            // txtQuanti
            // 
            txtQuanti.BackColor = Color.FromArgb(50, 97, 115);
            txtQuanti.BorderStyle = BorderStyle.FixedSingle;
            txtQuanti.Location = new Point(517, 63);
            txtQuanti.Name = "txtQuanti";
            txtQuanti.Size = new Size(114, 23);
            txtQuanti.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(431, 69);
            label11.Name = "label11";
            label11.Size = new Size(90, 17);
            label11.TabIndex = 7;
            label11.Text = "Quantidade : ";
            // 
            // txtInventario
            // 
            txtInventario.BackColor = Color.FromArgb(50, 97, 115);
            txtInventario.BorderStyle = BorderStyle.FixedSingle;
            txtInventario.Location = new Point(517, 34);
            txtInventario.Name = "txtInventario";
            txtInventario.Size = new Size(315, 23);
            txtInventario.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(431, 40);
            label12.Name = "label12";
            label12.Size = new Size(77, 17);
            label12.TabIndex = 5;
            label12.Text = "Inventario :";
            // 
            // txtNomeProd
            // 
            txtNomeProd.BackColor = Color.FromArgb(50, 97, 115);
            txtNomeProd.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProd.Location = new Point(94, 69);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(315, 23);
            txtNomeProd.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(15, 75);
            label13.Name = "label13";
            label13.Size = new Size(52, 17);
            label13.TabIndex = 3;
            label13.Text = "Nome :";
            // 
            // txtsearchProd
            // 
            txtsearchProd.BackColor = Color.FromArgb(50, 97, 115);
            txtsearchProd.BorderStyle = BorderStyle.FixedSingle;
            txtsearchProd.Location = new Point(94, 40);
            txtsearchProd.Name = "txtsearchProd";
            txtsearchProd.Size = new Size(315, 23);
            txtsearchProd.TabIndex = 2;
            txtsearchProd.TextChanged += txtsearchProd_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(15, 46);
            label14.Name = "label14";
            label14.Size = new Size(73, 17);
            label14.TabIndex = 1;
            label14.Text = "Pesquisar :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(15, 10);
            label15.Name = "label15";
            label15.Size = new Size(180, 21);
            label15.TabIndex = 0;
            label15.Text = "DETALHE DO PRODUTO";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvAddedProducts);
            panel4.Controls.Add(label20);
            panel4.Location = new Point(12, 297);
            panel4.Name = "panel4";
            panel4.Size = new Size(625, 331);
            panel4.TabIndex = 35;
            // 
            // dgvAddedProducts
            // 
            dgvAddedProducts.BackgroundColor = Color.FromArgb(50, 97, 115);
            dgvAddedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAddedProducts.Location = new Point(3, 34);
            dgvAddedProducts.Name = "dgvAddedProducts";
            dgvAddedProducts.RowTemplate.Height = 25;
            dgvAddedProducts.Size = new Size(617, 292);
            dgvAddedProducts.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Navy;
            label20.Location = new Point(15, 10);
            label20.Name = "label20";
            label20.Size = new Size(168, 21);
            label20.TabIndex = 0;
            label20.Text = "LISTA DE PRODUTOS :";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtTroco);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(txtTotalPago);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(txtTotalGeral);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtImpost);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(btnFinalizar);
            panel5.Controls.Add(txtDescont);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(txtSubTotal);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label21);
            panel5.Location = new Point(643, 297);
            panel5.Name = "panel5";
            panel5.Size = new Size(555, 331);
            panel5.TabIndex = 36;
            // 
            // txtTroco
            // 
            txtTroco.BackColor = Color.FromArgb(50, 97, 115);
            txtTroco.BorderStyle = BorderStyle.FixedSingle;
            txtTroco.Location = new Point(94, 191);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(444, 23);
            txtTroco.TabIndex = 46;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(15, 197);
            label17.Name = "label17";
            label17.Size = new Size(48, 17);
            label17.TabIndex = 45;
            label17.Text = "Troco :";
            // 
            // txtTotalPago
            // 
            txtTotalPago.BackColor = Color.FromArgb(50, 97, 115);
            txtTotalPago.BorderStyle = BorderStyle.FixedSingle;
            txtTotalPago.Location = new Point(94, 162);
            txtTotalPago.Name = "txtTotalPago";
            txtTotalPago.Size = new Size(444, 23);
            txtTotalPago.TabIndex = 44;
            txtTotalPago.TextChanged += txtTotalPago_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(15, 168);
            label22.Name = "label22";
            label22.Size = new Size(79, 17);
            label22.TabIndex = 43;
            label22.Text = "Total Pago :";
            // 
            // txtTotalGeral
            // 
            txtTotalGeral.BackColor = Color.FromArgb(50, 97, 115);
            txtTotalGeral.BorderStyle = BorderStyle.FixedSingle;
            txtTotalGeral.Location = new Point(94, 131);
            txtTotalGeral.Name = "txtTotalGeral";
            txtTotalGeral.Size = new Size(444, 23);
            txtTotalGeral.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(15, 137);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 41;
            label9.Text = "Total Geral :";
            // 
            // txtImpost
            // 
            txtImpost.BackColor = Color.FromArgb(50, 97, 115);
            txtImpost.BorderStyle = BorderStyle.FixedSingle;
            txtImpost.Location = new Point(94, 102);
            txtImpost.Name = "txtImpost";
            txtImpost.Size = new Size(444, 23);
            txtImpost.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(15, 108);
            label10.Name = "label10";
            label10.Size = new Size(81, 17);
            label10.TabIndex = 39;
            label10.Text = "Imposto % :";
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Green;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalizar.Location = new Point(234, 249);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(110, 49);
            btnFinalizar.TabIndex = 38;
            btnFinalizar.Text = "FINALIZAR VENDA";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // txtDescont
            // 
            txtDescont.BackColor = Color.FromArgb(50, 97, 115);
            txtDescont.BorderStyle = BorderStyle.FixedSingle;
            txtDescont.Location = new Point(94, 69);
            txtDescont.Name = "txtDescont";
            txtDescont.Size = new Size(444, 23);
            txtDescont.TabIndex = 4;
            txtDescont.TextChanged += txtDescont_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(15, 75);
            label18.Name = "label18";
            label18.Size = new Size(83, 17);
            label18.TabIndex = 3;
            label18.Text = "Disconto % :";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.FromArgb(50, 97, 115);
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.Location = new Point(94, 40);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(444, 23);
            txtSubTotal.TabIndex = 2;
            txtSubTotal.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(15, 46);
            label19.Name = "label19";
            label19.Size = new Size(70, 17);
            label19.TabIndex = 1;
            label19.Text = "Sub total :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Navy;
            label21.Location = new Point(15, 10);
            label21.Name = "label21";
            label21.Size = new Size(167, 21);
            label21.TabIndex = 0;
            label21.Text = "DETALHES CALCULO :";
            // 
            // frmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 97, 115);
            ClientSize = new Size(1210, 640);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVendas";
            Load += frmVendas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAddedProducts).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private TextBox txtEndercoCliente;
        private Label label8;
        private Label label7;
        private TextBox txtContatoCli;
        private Label label5;
        private TextBox txtEmailCli;
        private Label label6;
        private TextBox txtNomeCli;
        private Label label4;
        private TextBox txtSearchCli;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button btnCadastrarProd;
        private TextBox txtValor;
        private Label label16;
        private TextBox txtQuanti;
        private Label label11;
        private TextBox txtInventario;
        private Label label12;
        private TextBox txtNomeProd;
        private Label label13;
        private TextBox txtsearchProd;
        private Label label14;
        private Label label15;
        private Panel panel4;
        private DataGridView dgvAddedProducts;
        private Label label20;
        private Panel panel5;
        private TextBox txtTotalGeral;
        private Label label9;
        private TextBox txtImpost;
        private Label label10;
        private Button btnFinalizar;
        private TextBox txtDescont;
        private Label label18;
        private TextBox txtSubTotal;
        private Label label19;
        private Label label21;
        private TextBox txtTroco;
        private Label label17;
        private TextBox txtTotalPago;
        private Label label22;
        private Label lblTopo;
        private DateTimePicker cmbData;
    }
}