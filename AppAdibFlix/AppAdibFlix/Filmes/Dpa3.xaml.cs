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
    public partial class Dpa3 : ContentPage
    {
        public Dpa3()
        {
            InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);

			logo.Source = ImageSource.FromResource("AppAdibFlix.Img.lucasflix.png");
			poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.Dpa3.jpeg");

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
			sinopse.Text = "Severino encontra um objeto em meio aos escombros de um avião, sem saber que " +
				"se trata de uma das faces do Medalhão de Uzur. Ao colocá-lo no pescoço, o porteiro do Prédio " +
				"Azul passa a se tornar cada vez mais malvado. Com a bruxa Duvíbora e sua filha Dunhoca dispostas " +
				"a roubá-lo, Pippo, Sol e Bento não têm outra saída a não ser encontrar a metade do bem do medalhão. " +
				"Para tanto, eles contam com a ajuda da feiticeira Berenice, dos Inspetores de la Casa Naranja e ainda " +
				"do mago Elergun.";
		}
    }
}