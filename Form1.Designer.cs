namespace apkojekonline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gbpelanggan = new GroupBox();
            txthp = new TextBox();
            lblhp = new Label();
            txtnama = new TextBox();
            lblnama = new Label();
            gbpesanan = new GroupBox();
            btnbatal = new Button();
            btnpesan = new Button();
            lblharga = new Label();
            txtharga = new TextBox();
            cmbmetodepembayaran = new ComboBox();
            cmbjeniskendaraan = new ComboBox();
            txttujuan = new TextBox();
            txtjemput = new TextBox();
            lblpembayaran = new Label();
            lblkendaraan = new Label();
            lbltujuan = new Label();
            lbljemput = new Label();
            dataGridView1 = new DataGridView();
            nama = new DataGridViewTextBoxColumn();
            hp = new DataGridViewTextBoxColumn();
            jemput = new DataGridViewTextBoxColumn();
            tujuan = new DataGridViewTextBoxColumn();
            gbpelanggan.SuspendLayout();
            gbpesanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 28);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 0;
            label1.Text = "Ojek Online";
            // 
            // gbpelanggan
            // 
            gbpelanggan.Controls.Add(txthp);
            gbpelanggan.Controls.Add(lblhp);
            gbpelanggan.Controls.Add(txtnama);
            gbpelanggan.Controls.Add(lblnama);
            gbpelanggan.Location = new Point(12, 77);
            gbpelanggan.Name = "gbpelanggan";
            gbpelanggan.Size = new Size(480, 131);
            gbpelanggan.TabIndex = 1;
            gbpelanggan.TabStop = false;
            gbpelanggan.Text = "Informasi Pelanggan";
            // 
            // txthp
            // 
            txthp.Location = new Point(188, 79);
            txthp.Name = "txthp";
            txthp.Size = new Size(270, 31);
            txthp.TabIndex = 5;
            // 
            // lblhp
            // 
            lblhp.AutoSize = true;
            lblhp.Location = new Point(6, 79);
            lblhp.Name = "lblhp";
            lblhp.Size = new Size(139, 25);
            lblhp.TabIndex = 4;
            lblhp.Text = "No. Handphone";
            // 
            // txtnama
            // 
            txtnama.Location = new Point(188, 36);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(270, 31);
            txtnama.TabIndex = 3;
            txtnama.TextChanged += txtnama_TextChanged;
            // 
            // lblnama
            // 
            lblnama.AutoSize = true;
            lblnama.Location = new Point(6, 36);
            lblnama.Name = "lblnama";
            lblnama.Size = new Size(146, 25);
            lblnama.TabIndex = 2;
            lblnama.Text = "Nama Pelanggan";
            // 
            // gbpesanan
            // 
            gbpesanan.Controls.Add(btnbatal);
            gbpesanan.Controls.Add(btnpesan);
            gbpesanan.Controls.Add(lblharga);
            gbpesanan.Controls.Add(txtharga);
            gbpesanan.Controls.Add(cmbmetodepembayaran);
            gbpesanan.Controls.Add(cmbjeniskendaraan);
            gbpesanan.Controls.Add(txttujuan);
            gbpesanan.Controls.Add(txtjemput);
            gbpesanan.Controls.Add(lblpembayaran);
            gbpesanan.Controls.Add(lblkendaraan);
            gbpesanan.Controls.Add(lbltujuan);
            gbpesanan.Controls.Add(lbljemput);
            gbpesanan.Location = new Point(12, 231);
            gbpesanan.Name = "gbpesanan";
            gbpesanan.Size = new Size(480, 279);
            gbpesanan.TabIndex = 6;
            gbpesanan.TabStop = false;
            gbpesanan.Text = "Detail Pesanan";
            // 
            // btnbatal
            // 
            btnbatal.BackColor = Color.Red;
            btnbatal.ForeColor = SystemColors.ButtonFace;
            btnbatal.Location = new Point(381, 224);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(91, 34);
            btnbatal.TabIndex = 14;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = false;
            btnbatal.Click += button1_Click;
            // 
            // btnpesan
            // 
            btnpesan.BackColor = Color.LimeGreen;
            btnpesan.ForeColor = SystemColors.ButtonFace;
            btnpesan.Location = new Point(284, 224);
            btnpesan.Name = "btnpesan";
            btnpesan.Size = new Size(91, 34);
            btnpesan.TabIndex = 13;
            btnpesan.Text = "Pesan";
            btnpesan.UseVisualStyleBackColor = false;
            btnpesan.Click += btnpesan_Click;
            // 
            // lblharga
            // 
            lblharga.AutoSize = true;
            lblharga.Location = new Point(8, 230);
            lblharga.Name = "lblharga";
            lblharga.Size = new Size(60, 25);
            lblharga.TabIndex = 12;
            lblharga.Text = "Harga";
            // 
            // txtharga
            // 
            txtharga.Location = new Point(8, 227);
            txtharga.Name = "txtharga";
            txtharga.Size = new Size(270, 31);
            txtharga.TabIndex = 11;
            txtharga.TextChanged += textBox2_TextChanged;
            // 
            // cmbmetodepembayaran
            // 
            cmbmetodepembayaran.FormattingEnabled = true;
            cmbmetodepembayaran.Items.AddRange(new object[] { "Cash", "Transfer Bank", "E -Wallet" });
            cmbmetodepembayaran.Location = new Point(188, 175);
            cmbmetodepembayaran.Name = "cmbmetodepembayaran";
            cmbmetodepembayaran.Size = new Size(270, 33);
            cmbmetodepembayaran.TabIndex = 10;
            // 
            // cmbjeniskendaraan
            // 
            cmbjeniskendaraan.FormattingEnabled = true;
            cmbjeniskendaraan.Items.AddRange(new object[] { "Motor", "Mobil" });
            cmbjeniskendaraan.Location = new Point(188, 130);
            cmbjeniskendaraan.Name = "cmbjeniskendaraan";
            cmbjeniskendaraan.Size = new Size(270, 33);
            cmbjeniskendaraan.TabIndex = 9;
            cmbjeniskendaraan.SelectedIndexChanged += cmbjeniskendaraan_SelectedIndexChanged;
            // 
            // txttujuan
            // 
            txttujuan.Location = new Point(188, 84);
            txttujuan.Name = "txttujuan";
            txttujuan.Size = new Size(270, 31);
            txttujuan.TabIndex = 8;
            txttujuan.TextChanged += textBox1_TextChanged;
            // 
            // txtjemput
            // 
            txtjemput.Location = new Point(188, 41);
            txtjemput.Name = "txtjemput";
            txtjemput.Size = new Size(270, 31);
            txtjemput.TabIndex = 7;
            // 
            // lblpembayaran
            // 
            lblpembayaran.AutoSize = true;
            lblpembayaran.Location = new Point(6, 183);
            lblpembayaran.Name = "lblpembayaran";
            lblpembayaran.Size = new Size(176, 25);
            lblpembayaran.TabIndex = 6;
            lblpembayaran.Text = "Metode Pembayaran";
            // 
            // lblkendaraan
            // 
            lblkendaraan.AutoSize = true;
            lblkendaraan.Location = new Point(8, 138);
            lblkendaraan.Name = "lblkendaraan";
            lblkendaraan.Size = new Size(137, 25);
            lblkendaraan.TabIndex = 5;
            lblkendaraan.Text = "Jenis Kendaraan";
            // 
            // lbltujuan
            // 
            lbltujuan.AutoSize = true;
            lbltujuan.Location = new Point(6, 90);
            lbltujuan.Name = "lbltujuan";
            lbltujuan.Size = new Size(118, 25);
            lbltujuan.TabIndex = 4;
            lbltujuan.Text = "Lokasi Tujuan";
            // 
            // lbljemput
            // 
            lbljemput.AutoSize = true;
            lbljemput.Location = new Point(6, 41);
            lbljemput.Name = "lbljemput";
            lbljemput.Size = new Size(124, 25);
            lbljemput.TabIndex = 3;
            lbljemput.Text = "Lokasi Jemput";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nama, hp, jemput, tujuan });
            dataGridView1.Location = new Point(511, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(664, 92);
            dataGridView1.TabIndex = 7;
            // 
            // nama
            // 
            nama.HeaderText = "Nama Pelanggan";
            nama.MinimumWidth = 8;
            nama.Name = "nama";
            nama.Width = 150;
            // 
            // hp
            // 
            hp.HeaderText = "No. Handphone";
            hp.MinimumWidth = 8;
            hp.Name = "hp";
            hp.Width = 150;
            // 
            // jemput
            // 
            jemput.HeaderText = "Lokasi Jemput";
            jemput.MinimumWidth = 8;
            jemput.Name = "jemput";
            jemput.Width = 150;
            // 
            // tujuan
            // 
            tujuan.HeaderText = "Lokasi Tujuan";
            tujuan.MinimumWidth = 8;
            tujuan.Name = "tujuan";
            tujuan.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1278, 523);
            Controls.Add(dataGridView1);
            Controls.Add(gbpesanan);
            Controls.Add(gbpelanggan);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbpelanggan.ResumeLayout(false);
            gbpelanggan.PerformLayout();
            gbpesanan.ResumeLayout(false);
            gbpesanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbpelanggan;
        private TextBox txthp;
        private Label lblhp;
        private TextBox txtnama;
        private Label lblnama;
        private GroupBox gbpesanan;
        private TextBox txttujuan;
        private TextBox txtjemput;
        private Label lblpembayaran;
        private Label lblkendaraan;
        private Label lbltujuan;
        private Label lbljemput;
        private ComboBox cmbjeniskendaraan;
        private Label lblharga;
        private TextBox txtharga;
        private ComboBox cmbmetodepembayaran;
        private Button btnpesan;
        private Button btnbatal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn hp;
        private DataGridViewTextBoxColumn jemput;
        private DataGridViewTextBoxColumn tujuan;
    }
}
