namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtOkulNo.Clear();
            txtSýnýf.Clear();
            maskedTextBox1.Clear();
            lstGöster.Items.Clear();
            sayac = 1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            lstGöster.Items.Add(sayac+"-"+txtAdSoyad.Text+" "+ txtOkulNo.Text +" "+maskedTextBox1.Text+" "+comboBox1.SelectedItem+" "+txtSýnýf.Text+" "+comboBox2.SelectedItem);
            sayac++;
        }
    }
}
