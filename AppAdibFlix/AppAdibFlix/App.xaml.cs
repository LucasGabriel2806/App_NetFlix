using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppAdibFlix
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
            /**
             * No appEtecFlix vamos exercitar a navegação entre telas, para isso
             * vamos iniciar um nobo objeto chamado NavigationPage e definir aqui 
             * que a página inicial do nosso app será MainPage. Este objeto nos
             * dará acesso os recursos de navegação entre telas que veremos mais 
             * a frente. Nunca se esqueça de inicial este objeto se seu App tera
             * mais de uma tela.
             * NavigationPage: permite trocar de pagina
             */
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
