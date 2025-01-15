namespace Calculater
{
    public partial class MainPage : ContentPage
    {
        double y = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void ClearButton(object sender, EventArgs e)
        {
            EntryCalculater.Text = "";
            EntryResult.Text = "";
        }
        private void Numberbutton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EntryCalculater.Text += button.Text;
        }
        private void OperadButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EntryResult.Text = button.Text;
        }
        private void OperadButton2(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EntryResult.Text = button.Text;
        }

    }

}
