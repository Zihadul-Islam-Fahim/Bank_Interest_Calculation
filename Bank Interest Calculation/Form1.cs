namespace Bank_Interest_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BankList.Text == "SONALI BANK") 
            {
                double total;
                total = Convert.ToDouble(year.Text) * 0.08 * Convert.ToDouble(balance.Text);
                totalInterest.Text = total.ToString();
            }
            else  if (BankList.Text == "BRAC BANK")
            {
                double total;
                total = Convert.ToDouble(year.Text) * 0.05 * Convert.ToDouble(balance.Text);
                totalInterest.Text = total.ToString();
            }
            else if (BankList.Text == "DBBL BANK")
            {
                double total;
                total = Convert.ToDouble(year.Text) * 0.07 * Convert.ToDouble(balance.Text);
                totalInterest.Text = total.ToString();
            }
            else if (BankList.Text == "HSBC BANK")
            {
                double total;
                total = Convert.ToDouble(year.Text) * 0.06 * Convert.ToDouble(balance.Text);
                totalInterest.Text = total.ToString();
            }
        }
    }
}