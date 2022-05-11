using System;
using AppAdibFlix.Filmes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppAdibFlix.Img.lucasflix.png");

            btnSonic2.Source = ImageSource.FromResource("AppAdibFlix.Posters.Sonic2.jpg");
            btnDpa3.Source = ImageSource.FromResource("AppAdibFlix.Posters.Dpa3.jpeg");
            btnDrEstranho2.Source = ImageSource.FromResource("AppAdibFlix.Posters.DrEstranho2.jpeg");
            btnHomemAranha3.Source = ImageSource.FromResource("AppAdibFlix.Posters.HomemAranha3.jpeg");
            btnUltimato.Source = ImageSource.FromResource("AppAdibFlix.Posters.Ultimato.jpeg");
            btnGuerraInfinita.Source = ImageSource.FromResource("AppAdibFlix.Posters.GuerraInfinita.jpeg");
        }


        private async void Btn_Open_Sonic2(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Sonic2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops ocorreu um erro... \n", ex.Message, "OK");
            }
        }


        private async void Btn_Open_Dpa3(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Dpa3());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops ocorreu um erro... \n", ex.Message, "OK");
            }
        }


        private async void Btn_Open_DrEstranho2(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new DrEstranho2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops ocorreu um erro... \n", ex.Message, "OK");
            }
        }


        private async void Btn_Open_HomemAranha3(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new HomemAranha3());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops ocorreu um erro... \n", ex.Message, "OK");
            }
        }


        private async void Btn_Open_Ultimato(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Ultimato());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops ocorreu um erro... \n", ex.Message, "OK");
            }
        }


        private async void Btn_Open_GuerraInfinita(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new GuerraInfinita());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops ocorreu um erro... \n", ex.Message, "OK");
            }
        }
    }
}