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
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");

            btnAteOUltimoHomem.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Drama.ate_ultimo_homem.jpg");
            btnBastardosInglorios.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Drama.bastardos_inglorios.jpeg");
            btnInterestelar.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Drama.interestelar.jpg");
            btnOResgateDoSoldadoRyan.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Drama.resgate_soldado_ryan.jpg");
            btnSully.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Drama.sully.jpg");
            btnPoderosoChefao.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Drama.the_godfather.jpg");
        }

        private async void btnAteOUltimoHomem_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Drama.AteUltimoHomem());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnBastardosInglorios_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Drama.BastardosInglorios());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnInterestelar_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Drama.Interestelar());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnOResgateDoSoldadoRyan_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Drama.ResgateSoldadoRyan());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnSully_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Drama.Sully());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnPoderosoChefao_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Drama.TheGodfather());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}