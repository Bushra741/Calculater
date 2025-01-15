namespace Calculater
{
    public partial class MainPage : ContentPage
    {
        private double accumulator = 0;
        private string operation = "";
        private double operand = 0;
        

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void ClearButton(object sender, EventArgs e)
        {
            
        }
        private void Numberbutton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EntryCalculater.Text += button.Text; 
            operation += button.Text;
        }
        private void OperandButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EntryResult.Text += button.Text;
            operation = button.Text;
            Calculate();
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
                    accumulator *= operand;
                    break;
                case "/":
                    if (operand == 0)
                    {
                        EntryResult.Text= ("Error");
                        return;
                    }
                    accumulator /= operand;
                    break;
                }
            }
    }

}
