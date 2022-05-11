using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomemAranha3 : ContentPage
    {
        public HomemAranha3()
        {
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);

			logo.Source = ImageSource.FromResource("AppAdibFlix.Img.lucasflix.png");
			poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.HomemAranha3.jpeg");

			/*var htmlSource = new HtmlWebViewSource();
			htmlSource.html = @"<iframe width='560' 
										height='315'
										src='https://www.youtube.com/embed/FtSL2wCTzhw'
										title='YouTube video player' 
										frameborder='0' 
										allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; 
											   picture-in-picture' 
										allowfullscreen
								</iframe>";*/

			//visualizador.Source = htmlSource;
			sinopse.Text = "O Homem-Aranha precisa lidar com as consequências da sua verdadeira identidade ter sido descoberta.";
		}
    }
}