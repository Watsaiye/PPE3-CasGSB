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
        }

        private async void BtnAccueil_Clicked(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}
