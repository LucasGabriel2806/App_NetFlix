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
    public partial class DrEstranho2 : ContentPage
    {
        public DrEstranho2()
        {
            InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);

			logo.Source = ImageSource.FromResource("AppAdibFlix.Img.lucasflix.png");
			poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.DrEstranho2.jpeg");

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
			sinopse.Text = "O aguardado filme trata da jornada do Doutor Estranho rumo ao desconhecido. " +
						   "Além de receber ajuda de novos aliados místicos e outros já conhecidos do público, " +
						   "o personagem atravessa as realidades alternativas incompreensíveis e perigosas do Multiverso " +
						   "para enfrentar um novo e misterioso adversário.";





		}
    }
}