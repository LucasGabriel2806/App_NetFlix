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
    public partial class GuerraInfinita : ContentPage
    {
        public GuerraInfinita()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

			logo.Source = ImageSource.FromResource("AppAdibFlix.Img.lucasflix.png");
			poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.GuerraInfinita.jpeg");

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
			sinopse.Text = "Homem de Ferro, Thor, Hulk e os Vingadores se unem para combater seu inimigo " +
				"mais poderoso, o maligno Thanos. Em uma missão para coletar todas as seis pedras infinitas, " +
				"Thanos planeja usá-las para infligir sua vontade maléfica sobre a realidade.";
        }
    }
}