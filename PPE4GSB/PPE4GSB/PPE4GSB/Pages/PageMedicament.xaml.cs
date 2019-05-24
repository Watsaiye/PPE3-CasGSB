using PPE4GSB.Classes;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PPE4GSB.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMedicament : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public PageMedicament()
        {
            InitializeComponent();
            AfficherMedicaments();
        }

        public async void AfficherMedicaments()
        {
            lvMedicaments.ItemsSource = await App.GestWeb.GetMedicamentsAsync();
        }

        private async void LvMedicaments_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lvMedicaments.SelectedItem != null)
            {
                Medicaments leMedicamentSelectionner = (lvMedicaments.SelectedItem as Medicaments);
                Pages.PageModifierMedoc page = new Pages.PageModifierMedoc(leMedicamentSelectionner);
                await Navigation.PushModalAsync(page);
            }
        }


        private async void BtnAjouterComposant_Clicked(object sender, EventArgs e)
        {
            Pages.PageAjouterComposant page = new Pages.PageAjouterComposant((lvComposants.ItemsSource as List<Composant>).Count);
            await Navigation.PushModalAsync(page);
        }

        private async void btnAccueil_Clicked(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}
