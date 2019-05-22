using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PPE4GSB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //liste de bouton permettant de bouger d'une page à une autre
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

        private async void btnStat_Clicked(object sender, EventArgs e)
        {
            Pages.PageStat page = new Pages.PageStat();
            await Navigation.PushModalAsync(page);
        }
    }
}
