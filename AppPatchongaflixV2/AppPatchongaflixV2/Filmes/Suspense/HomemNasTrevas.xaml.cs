using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPatchongaflixV2.Filmes.Suspense
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomemNasTrevas : ContentPage
    {
        public HomemNasTrevas()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");
            poster.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Suspense.homem_nas_trevas.jpg");
        }
    }
}