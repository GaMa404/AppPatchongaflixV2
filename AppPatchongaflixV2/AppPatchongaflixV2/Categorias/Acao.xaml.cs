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
    public partial class Acao : ContentPage
    {
        public Acao()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");

            btnBatman.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Acao.batman.jpg");
            btnBreakingBad.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Acao.breaking_bad.jpg");
            btnDjangoLivre.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Acao.django_livre.jpg");
            btnFastFurious2.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Acao.fast_furious2.jpg");
            btnPeakyBlinders.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Acao.peaky_blinders.jpg");
            btnTheWalkingDead.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Acao.the_walking_dead.jpg");
        }

        private async void btnBatman_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Acao.Batman());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnBreakingBad_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Acao.BreakingBad());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnDjangoLivre_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Acao.DjangoLivre());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnFastFurious2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Acao.FastFurious2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnPeakyBlinders_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Acao.PeakyBlinders());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnTheWalkingDead_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Acao.TheWalkingDead());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}