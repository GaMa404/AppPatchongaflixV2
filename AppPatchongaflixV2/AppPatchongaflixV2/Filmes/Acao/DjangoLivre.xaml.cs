using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPatchongaflixV2.Filmes.Acao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DjangoLivre : ContentPage
    {
        public DjangoLivre()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppPatchongaflixV2.Logo.patchongaflix.png");
            poster.Source = ImageSource.FromResource("AppPatchongaflixV2.Posters.Acao.django_livre.jpg");
        }
    }
}