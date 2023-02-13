using System.Linq.Expressions;

namespace Sumator
{
    public partial class Sumator : Form
    {
        public Sumator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = decimal.Parse(this.textBox1.Text);
                var num2 = decimal.Parse(this.textBox2.Text);
                var sum = num1 + num2;
                textBoxSum.Text = sum.ToString();
            }
            catch (Exception)
            {
                textBoxSum.Text = "error";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}