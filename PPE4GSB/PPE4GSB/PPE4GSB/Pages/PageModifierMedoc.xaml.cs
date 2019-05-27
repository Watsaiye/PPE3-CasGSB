using PPE4GSB.Classes;
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
	public partial class PageModifierMedoc : ContentPage
	{
		public PageModifierMedoc (Medicaments unMedicament)
		{
			InitializeComponent ();
            AfficherInfoMedoc(unMedicament);
		}

        public void AfficherInfoMedoc(Medicaments unMedicament)
        {
            txtDepotLegal.Text = unMedicament.Depot;
            txtNomCommercial.Text = unMedicament.NomCom;
            txtComposition.Text = unMedicament.Compo;
            txtEffets.Text = unMedicament.Effets;
            txtContreIndic.Text = unMedicament.ContreIndic;
            txtPrix.Text = unMedicament.Prix.ToString();
            txtCodeFamille.Text = unMedicament.CodeFam.ToString();
        }

        public void BtnModifMedoc_Clicked(object sender, EventArgs e)
        {
            string Depot = txtDepotLegal.Text;
            string NomCom = txtNomCommercial.Text;
            string Compo = txtComposition.Text;
            string Effets = txtEffets.Text;
            string ContreIndic = txtContreIndic.Text;
            string Prix = txtPrix.Text;
            string CodeFam = txtCodeFamille.Text;


            App.GestWeb.UpdateMedicamentAsync(Depot, NomCom, CodeFam, Compo, Effets, ContreIndic, Prix);

            DisplayAlert("Modification du médicament effectué", "Modification réalisée", "c'est fait");

        }

        private async void BtnAccueil_Clicked(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}