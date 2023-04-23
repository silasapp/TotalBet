namespace TotalBet
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var amount = Convert.ToInt64(textBox3.Text);
            var underOdd = Convert.ToDouble(textBox1.Text);
            var overOdd = Convert.ToDouble(textBox2.Text);

            var amountToStake = Math.Ceiling(amount / (overOdd - 1));

            var profit = (amount * underOdd) - (amountToStake * overOdd);
            label6.Text = (Math.Ceiling(amount / (overOdd - 1))).ToString();
            if (profit > 0)
            {
                label3.Text = "Profit is: " + Math.Round(profit, 2);
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.Text = "Lose is: " + Math.Round(profit, 2);
                label3.ForeColor = Color.Red;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}