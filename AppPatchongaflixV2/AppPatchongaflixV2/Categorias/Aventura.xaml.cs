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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");

            btnArrow.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Aventura.arrow.jpg");
            btnDororo.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Aventura.dororo.jpg");
            btnInvencivel.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Aventura.invencivel.jpg");
            btnJojo.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Aventura.jojo.jpg");
            btnLigaZackSnyder.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Aventura.justice_league_zack_snyder.jpg");
            btnTheBoys.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Aventura.the_boys.jpg");
        }

        private async void btnArrow_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.Arrow());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnDororo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.Dororo());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnInvencivel_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.Invencivel());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnJojo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.Jojo());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnLigaZackSnyder_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.JusticeLeague());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnTheBoys_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.TheBoys());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}