namespace DiskonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numDiskon = 0;
            bool isNumA = int.TryParse(txtNominal.Text, out numA);
            bool isNumDiskon = int.TryParse(txtDiskon.Text, out numDiskon);
            int Diskon = (int) ((double) numA * (double) numDiskon / 100.0);
            int totalBayar = numA - Diskon;
            if (isNumA && isNumDiskon)
            {
                txtTotal.Text = totalBayar.ToString();
            } else
            {
                MessageBox.Show("Hanya Format Angka!", "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNominal.Text = "";
            txtDiskon.Text = "";
            txtTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}