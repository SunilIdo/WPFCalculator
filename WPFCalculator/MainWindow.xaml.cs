using System.Windows;

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        long result = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {

                number1 = number1 * 10;
                txtDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = number2 * 10;
                txtDisplay.Text = number2.ToString();
            }


        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 1;
                txtDisplay.Text = number1.ToString();

            }
            else
            {
                number2 = number2 * 10 + 1;
                txtDisplay.Text = number2.ToString();
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 2;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 2;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 3;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 3;
                txtDisplay.Text = number2.ToString();
            }
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 4;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 4;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 5;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 5;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 6;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 6;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 7;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 8;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 8;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 9;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 9;
                txtDisplay.Text = number2.ToString();
            }
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                number1 = result;
                number2 = 0;
            }
            operation = "/";
            txtDisplay.Text = "0";
        }



        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    break;
            }
            txtDisplay.Text = result.ToString();
            operation = "";
        }

        private void btnPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                if (result == 0)
                {
                    number1 *= -1;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    result *= -1;
                    txtDisplay.Text = result.ToString();
                }

            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = number2.ToString();
            }
        }



        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                number1 = result;
                number2 = 0;
            }
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                number1 = result;
                number2 = 0;
            }
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                number1 = result;
                number2 = 0;
            }
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 / 10;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 / 10;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            result = 0;
            txtDisplay.Text = "0";
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";
        }
    }
}
