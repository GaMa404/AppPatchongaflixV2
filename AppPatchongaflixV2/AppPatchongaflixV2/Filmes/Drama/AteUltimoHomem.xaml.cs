using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPatchongaflixV2.Filmes.Drama
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AteUltimoHomem : ContentPage
    {
        public AteUltimoHomem()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");
            poster.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Drama.ate_ultimo_homem.jpg");
        }
    }
}