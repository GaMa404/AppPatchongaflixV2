using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPatchongaflixV2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void acao_Clicked(object sender, EventArgs e)
        {
            try
            {
               await Navigation.PushAsync(new Categorias.Acao());
            }
            catch (Exception ex)
            {
               await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void comedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Comedia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void terror_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Terror());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void aventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void drama_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Drama());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void suspense_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Suspense());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}
