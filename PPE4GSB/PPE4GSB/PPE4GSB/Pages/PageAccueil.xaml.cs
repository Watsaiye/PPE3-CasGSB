using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPE4GSB.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAccueil : ContentPage
    {
        public PageAccueil()
        {
            InitializeComponent();
        }

        private async void btnListeMedicament_Clicked(object sender, EventArgs e)
        {
            Pages.PageMedicament page = new Pages.PageMedicament();
            await Navigation.PushModalAsync(page);
        }

        private async void btnListeIndividu_Clicked(object sender, EventArgs e)
        {
            Pages.PageListIndividu page = new Pages.PageListIndividu();
            await Navigation.PushModalAsync(page);
        }

        private async void btnPrescription_Clicked(object sender, EventArgs e)
        {
            Pages.PagePrescription page = new Pages.PagePrescription();
            await Navigation.PushModalAsync(page);
        }
    }
}
