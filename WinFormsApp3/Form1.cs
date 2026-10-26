namespace WinFormsApp3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void AdditionButtonClick(object sender, EventArgs e) {
            Calculation('+');
        }
        private void SubtractionButtonClick(object sender, EventArgs e) {
            Calculation('-');
        }
        private void MultiplyButtonClick(object sender, EventArgs e) {
            Calculation('*');
        }
        private void DivideButtonClick(object sender, EventArgs e) {
            Calculation('/');
        }
        private void Calculation(char Operand) {
            label1.Text = Convert.ToString(Operand);
            if (double.TryParse(textBox1.Text, out double firstNumber) &&
                double.TryParse(textBox2.Text, out double secondNumber)) {
                switch (Operand) {
                    case '+':
                        label4.Text = "= " + (firstNumber + secondNumber).ToString("F3");
                        break;
                    case '-':
                        label4.Text = "= " + (firstNumber - secondNumber).ToString("F3");
                        break;
                    case '*':
                        label4.Text = "= " + (firstNumber * secondNumber).ToString("F3");
                        break;
                    case '/':
                        if (secondNumber == 0) {
                            label4.Text = "Помилка: ділення на нуль!";
                        } else {
                            label4.Text = "= " + (firstNumber / secondNumber).ToString("F3");
                        }
                        break;
                }
            } else {
                label5.Text = "Будь ласка, введіть коректні числа!";
            }
        }
    }
}
