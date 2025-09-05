namespace apkojekonline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnpesan_Click(object sender, EventArgs e)
        {
            string nama = txtnama.Text;
            string hp = txthp.Text;
            string jemput = txtjemput.Text;
            string tujuan = txttujuan.Text;

            dataGridView1.Rows.Clear(); // clear dulu
            dataGridView1.Rows.Add(nama, hp, jemput, tujuan); // tambah data
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbjeniskendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbjeniskendaraan.SelectedItem.ToString() == "Motor")
                lblharga.Text = "10000";
            else if (cmbjeniskendaraan.SelectedItem.ToString() == "Mobil")
                lblharga.Text = "20000";
        }
    }
}
