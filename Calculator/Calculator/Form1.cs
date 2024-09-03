namespace Calculator
{
    public partial class Form1 : Form
    {
        private double num1, num2;
        private Char _operator;

        public Form1()
        {
            InitializeComponent();
        }

        private void digit_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox.Text += btn.Text;
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num1 = Convert.ToDouble(textBox.Text);
            _operator = Convert.ToChar(btn.Text);
            textBox.Clear();
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void equalto_click(object sender, EventArgs e)
        {
            double ans = 0.0;
            num2 = Convert.ToDouble(textBox.Text);

            switch (_operator)
            {
                case '+':
                    ans = num1 + num2;
                    break;
                case '-':
                    ans = num1 - num2;
                    break;
                case '*':
                    ans = num1 * num2;
                    break;
                case '/':
                    ans = num1 / num2;
                    break;
            }
            textBox.Text = Convert.ToString(ans);
        }
    }
}
