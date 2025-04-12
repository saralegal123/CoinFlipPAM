using CoinFlip;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            //sorteio da moeda (random)
            Random random = new Random();
            int sorteio = random.Next(2);

            //animação();
            if(sorteio == 0)
            {
                Moeda.Source = "cara.png";
            }
            else
            {
                Moeda.Source = "coroa.png";
            }

            //verificar qual opção foi selecionada
            //se eu selecionei cara e der cara -->
            if (SelecaoPicker.SelectedIndex == sorteio)
            {
                DisplayAlert("EBA!", "VOCÊ VENCEU! :D ", "Ok");
            }
            else
            {
                DisplayAlert("POXA, NÃO FOI DESSA VEZ...", "TENTE DE NOVO!", "Ok");
            }
        }
    }
}
