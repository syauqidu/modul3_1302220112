namespace modul3_1302220112
{
    public partial class Form1 : Form
    {
        int jumlah;
        int angka1;
        int angka2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToInt32(txtBoxOut.Text);
            txtBoxOut.Clear();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void but1_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "1";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "5";
        }

        private void but6_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "6";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            txtBoxOut.Text = "9";
        }

        private void butEqual_Click(object sender, EventArgs e)
        {
            angka2 = Convert.ToInt32(txtBoxOut.Text);
            jumlah = angka1 + angka2;
            txtBoxOut.Text = Convert.ToString(jumlah);
        }

        private void txtBoxOut_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
