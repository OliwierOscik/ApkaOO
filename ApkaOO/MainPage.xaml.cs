namespace ApkaOO
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           Random r = new Random();
            int ApkaOO = r.Next(1, 7);
            CounterBtn.Text = "Wylosowany rzut:"+ ApkaOO.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
