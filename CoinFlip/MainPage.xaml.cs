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

            if(sorteio == 0)
            {
                MoedaImage.Source = "cara.png";
            }
            else
            {
                MoedaImage.Source = "coroa.png";
            }

            //verificar qual opção foi selecionada
            //se eu selecionei cara e deu...
            if (SelecaoPicker.SelectedIndex == sorteio)
            {
                DisplayAlert("EBA!", "VOCÊ VENCEU", "Ok");
            }
            else
            {
                DisplayAlert("POXA, NÃO FOI DESSA VEZ...", "TENTE DE NOVO!", "Ok");
            }
        }
    }
}
