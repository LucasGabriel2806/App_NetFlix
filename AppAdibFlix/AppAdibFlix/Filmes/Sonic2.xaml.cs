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
    public partial class Sonic2 : ContentPage
    {
        public Sonic2()
        {
            InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
			
			logo.Source = ImageSource.FromResource("AppAdibFlix.Img.lucasflix.png");
			poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.Sonic2.jpg");
			
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
			sinopse.Text = "O Dr. Robotnik retorna à procura de uma esmeralda mística que tem o poder" +
						   "de destruir civilizações. Para detê-lo, Sonic se une a seu antigo parceiro," +
						   "Tails, e parte em uma jornada para encontrar a joia antes que ela caia em mãos erradas.";
						   
			
        }								
    }
}