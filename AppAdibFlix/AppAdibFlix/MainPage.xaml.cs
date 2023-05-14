﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


using AppAdibFlix.Categorias;// vai reconhecer Aventura da pasta categoria

namespace AppAdibFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Aqui estamos apontando o endereço da imagem
            logo.Source = ImageSource.FromResource("AppAdibFlix.Img.lucasflix.png");
            //Linha d ecódigo abaixo desabilita a barra no topo da tela(onde fica as notificações)
			NavigationPage.SetHasNavigationBar(this, false);	
		}

        /**
         * Este é o método responsável por trocar para a tela de Aventura. Veja que colocamos
         * a notação async. Isso acontece porque temos que esperar a outra tela responder. Observe
         * que o Navigation.PushAsync tem a notação await antes, que determina que o App deve esperar
         * a outra tela responder para dar seguimento.
         * 
         */
        private async void Btn_Open_Aventura(object sender, EventArgs e)
        {
            try
            {
		// push.async: coloca uma pagina em cima da outra, 
		// embaralha uma pagina em cima da outra,como se fosse 
		// um jogo de baralho, que coloca uma carta em cima da outra
		// pop.async: pra voltar pra pagina anterior
		// await: espera 
                await Navigation.PushAsync(new Aventura());

            } catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
		
		private async void Btn_Open_Comedia(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Comedia());

            } catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
		
		private async void Btn_Open_Drama(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Drama());

            } catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
		
		private async void Btn_Open_Terror(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Terror());

            } catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "OK");
            }
        }
		
        
        
    }
}
