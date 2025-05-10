namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        private void FlipButton_Clicked(object sender, EventArgs e)
        {

            DiceRoller dice = new DiceRoller();
            int sorteio = dice.Flip();

            DadoImage1.Source = null;
            DadoImage1.Source = $"dado{sorteio}.png";

            if (SelecaoPicker.SelectedIndex + 1 == sorteio)
            {
                DisplayAlert("Parabéns", "Você venceu!", "Ok");
            }
            else
            {
                DisplayAlert("Se ferrou", "Você perdeu!", "Ok");
            }
        }
    }
}
