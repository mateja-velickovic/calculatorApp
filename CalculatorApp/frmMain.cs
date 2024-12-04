namespace CalculatorApp
{
    public partial class frmMain : Form
    {
        private readonly Calculator _calc;

        private string _currentOperation="";
        private double _firstOperand;
        private bool _isOperationClicked;

        public frmMain()
        {
            InitializeComponent();

            _calc = new Calculator();
        }



        private void btnEquals_Click(object sender, EventArgs e)
        {
            var secondOperand = double.Parse(txtResult.Text);
            double result;

            try
            {
                result = _currentOperation switch
                {
                    "+" => _calc.Add(_firstOperand, secondOperand),
                    "-" => _calc.Subtract(_firstOperand, secondOperand),
                    "*" => _calc.Multiply(_firstOperand, secondOperand),
                    "/" => _calc.Divide(_firstOperand, secondOperand),
                    "%" => _calc.Percentage(_firstOperand, secondOperand),
                    _ => 0
                };

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            _currentOperation = string.Empty;
            _firstOperand = 0;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            _firstOperand = double.Parse(txtResult.Text);
            _currentOperation = button.Text;
            _isOperationClicked = true;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (_isOperationClicked || txtResult.Text == "0")
            {
                txtResult.Clear();
                _isOperationClicked = false;
            }

            txtResult.Text += button.Text;
        }
    }
 }
