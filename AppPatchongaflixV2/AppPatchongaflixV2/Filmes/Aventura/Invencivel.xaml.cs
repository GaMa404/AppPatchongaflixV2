using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPatchongaflixV2.Filmes.Aventura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Invencivel : ContentPage
    {
        public Invencivel()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");
            poster.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Aventura.invencivel.jpg");
        }
    }
}