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
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");

            btnAnabelle.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Terror.anabelle.jpg");
            btnBruxa.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Terror.bruxa.jpg");
            btnHalloween.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Terror.halloween.jpg");
            btnHereditario.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Terror.hereditario.jpg");
            btnJigsaw.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Terror.jigsaw.jpg");
            btnNos.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Terror.nos.jpg");
        }

        private async void btnAnabelle_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.Anabelle());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnBruxa_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.Bruxa());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnHalloween_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.Halloween());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnHereditario_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.Hereditario());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnJigsaw_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.Jigsaw());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnNos_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.Nos());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}