using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPatchongaflixV2.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");

            btnGenteGrande2.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Comedia.gente_grande2.jpg");
            btnPeacemaker.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Comedia.peacemaker.jpg");
            btnSuperHeroi.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Comedia.super_heroi.jpg");
            btnTodoMundoEmPanico.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Comedia.todo_mundo_panico5.jpg");
            btnVizinhancaDoBarulho.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Comedia.vizinhanca_do_barulho.jpg");
            btnZumbilandia.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Comedia.zumbilandia.jpg");
        }

        private async void btnGenteGrande2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.GenteGrande2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnPeacemaker_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.Peacemaker());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnSuperHeroi_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.SuperHeroi());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnTodoMundoEmPanico_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.TodoMundoPanico5());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnVizinhancaDoBarulho_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.VizinhancaDoBarulho());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnZumbilandia_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Comedia.Zumbilandia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}