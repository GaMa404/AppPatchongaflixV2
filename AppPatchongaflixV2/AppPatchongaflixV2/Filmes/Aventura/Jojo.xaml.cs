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
    public partial class Jojo : ContentPage
    {
        public Jojo()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");
            poster.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Aventura.jojo.jpg");
        }
    }
}