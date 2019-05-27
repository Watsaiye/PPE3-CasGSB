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
    public partial class PageListIndividu : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        
        public PageListIndividu()
        {
            InitializeComponent();
            AfficherIndividu();
        }

        public async void AfficherIndividu()
        {
            lvIndividus.ItemsSource = await App.GestWeb.GetIndividu_TypesAsync();
        }

        private async void LvIndividu_Selected(object sender, EventArgs e)
        {
            if (lvIndividus.SelectedItem != null)
            {
                Individu_type lIndividuSelectionner = (lvIndividus.SelectedItem as Individu_type);
                Pages.PageModifierIndividu page = new Pages.PageModifierIndividu(lIndividuSelectionner);
                await Navigation.PushModalAsync(page);
            }
        }

        private async void BtnPageAjouterIndividu_Clicked(object sender, EventArgs e)
        {
            Pages.PageAjouterIndividu page = new Pages.PageAjouterIndividu();
            await Navigation.PushModalAsync(page);
        }

        private async void BtnAccueil_Clicked(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }


    }
}
