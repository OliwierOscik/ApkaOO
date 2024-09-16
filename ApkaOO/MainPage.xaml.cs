namespace ApkaOO
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //wyswietlanie wyniku
            Random r = new Random();
            int ApkaOO = r.Next(1, 7);
            RollValueLabel.Text = "Wylosowany rzut:"+ ApkaOO.ToString();

            SemanticScreenReader.Announce(RollValueLabel.Text);

        }

        
        //private void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        //{
          //  if (e.Value)
          //  {
            //    var selectedRadioButton = sender as RadioButton;

              //  if (selectedRadioButton != null)
                //{
                   
                  //  if (selectedRadioButton.Content is Image image)
                    //{
                      
                      //  MainImage.Source = image.Source;
                    //}
                //}
            //}
        //}
    }

}
