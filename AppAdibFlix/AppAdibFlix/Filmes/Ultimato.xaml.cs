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
    public partial class Ultimato : ContentPage
    {
        public Ultimato()
        {
            InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);

			logo.Source = ImageSource.FromResource("AppAdibFlix.Img.lucasflix.png");
			poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.Ultimato.jpeg");

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
			sinopse.Text = "Após Thanos eliminar metade das criaturas vivas, os Vingadores têm de lidar com a " +
				"perda de amigos e entes queridos. Com Tony Stark vagando perdido no espaço sem água e comida, " +
				"Steve Rogers e Natasha Romanov lideram a resistência contra o titã louco.";





		}
    }
}