//using AndroidX.Activity;
using System.Reflection.Metadata;

namespace Calculater
{
    public partial class MainPage : ContentPage
    {
        private double accumulator = 0;
        private string operation = "";
        private double operand = 0;
        private bool mobil = false;
        

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Numberbutton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EntryCalculator.Text += button.Text;
            
            if (button.Text == ",")
            {
                mobil = true;
                return;
            }
            if (mobil)
            {
                operand = double.Parse(operand.ToString() + "," + button.Text);
                mobil = false;
                return;
            }
            //EntryResult.Text += button.Text;      
           
            operand = operand * 10 + double.Parse(button.Text);
        }

       
        
        private void OperandButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EntryCalculator.Text += button.Text;
            //EntryResult.Text += button.Text;
            operation = button.Text;

            if (!string.IsNullOrEmpty(operation))
            {
                if (accumulator == 0)
                {
                    accumulator = operand;
                }
                else
                {

                    Calculate();
                }

                operand = 0;
            }
        }

        
        private void EqualButton(object sender, EventArgs e)
        {

            Calculate();
        }
        public void Calculate()
        {
            switch (operation)
            {
                case "+":
                    accumulator += operand;
                    break;
                case "-":
                    accumulator -= operand;
                    break;
                case "*":
                    if (operand == 0)
                    {
                        EntryResult.Text = ("");
                        return;
                    }
                    accumulator *= operand;

                    break;

                case "/":

                    if (operand == 0)
                    {
                        EntryResult.Text = ("");
                        return;
                    }
                    accumulator /= operand;
                    break;
            }

            EntryResult.Text = accumulator.ToString();
            operand = 0;
        }

        private void ClearButton(object sender, EventArgs e)
        {
            EntryCalculator.Text = "";
            EntryResult.Text = "";
            accumulator = 0;
            operand = 0;
        }
        private void AnotherButton(object sender, EventArgs e)
        {
            EntryCalculator.Text = "";
            EntryResult.Text = "Error";
        }
        private void ClearCloneButton(object sender, EventArgs e)
        {
            EntryCalculator.Text = "";

        }
        
    }

}
