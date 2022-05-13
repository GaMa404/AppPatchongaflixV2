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
    public partial class Suspense : ContentPage
    {
        public Suspense()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");

            btnCorra.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Suspense.corra.jpg");
            btnFragmentado.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Suspense.fragmentado.jpg");
            btnHomemNasTrevas.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Suspense.homem_nas_trevas.jpg");
            btnIlhaDoMedo.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Suspense.ilha_do_medo.jpg");
            btnJoker.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Suspense.joker.jpg");
            btnRedSparrow.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Suspense.red_sparrow.jpg");
        }

        private async void btnCorra_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Suspense.Corra());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnFragmentado_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Suspense.Fragmentado());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnHomemNasTrevas_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Suspense.HomemNasTrevas());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnIlhaDoMedo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Suspense.IlhaDoMedo());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnJoker_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Suspense.Joker());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnRedSparrow_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Suspense.RedSparrow());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}