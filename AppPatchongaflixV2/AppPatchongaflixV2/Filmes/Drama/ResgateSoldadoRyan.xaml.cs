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
    public partial class ResgateSoldadoRyan : ContentPage
    {
        public ResgateSoldadoRyan()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");
            poster.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Drama.resgate_soldado_ryan.jpg");
        }
    }
}