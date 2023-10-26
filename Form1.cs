namespace Homework2WinF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            button1.Click += CalculateButton_Click;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckIfCalculationEnabled();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CheckIfCalculationEnabled();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckIfCalculationEnabled();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CheckIfCalculationEnabled();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(textBox1.Text, out decimal initialDeposit) &&
                decimal.TryParse(numericUpDown1.Value.ToString(), out decimal interestRate) &&
                int.TryParse(textBox2.Text, out int duration) && duration >= 0)
            {
                decimal finalAmount = initialDeposit * (1 + interestRate / 100) * (decimal)Math.Pow((double)(1 + interestRate / 100), duration);
                textBox3.Text = finalAmount.ToString("F2");
            }
            else
            {
                MessageBox.Show("Некорректные данные. Пожалуйста, введите числовые значения.");
                textBox3.Text = "";
            }
        }

        private void CheckIfCalculationEnabled()
        {
            if (decimal.TryParse(textBox1.Text, out decimal initialDeposit) &&
                decimal.TryParse(numericUpDown1.Value.ToString(), out decimal interestRate) &&
                int.TryParse(textBox2.Text, out int duration) && duration >= 0)
            {
                button1.Enabled = true; // Включить кнопку расчета
            }
            else
            {
                button1.Enabled = false; // Отключить кнопку расчета
            }
        }
    }
}