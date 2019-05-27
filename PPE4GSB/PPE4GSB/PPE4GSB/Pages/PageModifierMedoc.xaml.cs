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
            txtDepotLegal.Text = unMedicament.Med_depotlegal;
            txtNomCommercial.Text = unMedicament.Med_nomCommercial;
            txtComposition.Text = unMedicament.Med_composition;
            txtEffets.Text = unMedicament.Med_effets;
            txtContreIndic.Text = unMedicament.Med_contrIndic;
            txtPrix.Text = unMedicament.Med_prixechantillon;
            txtCodeFamille.Text = unMedicament.Fam_code.ToString();
        }

        public void btnModifMedoc_Clicked(object sender, EventArgs e)
        {
            string Med_depotlegal = txtDepotLegal.Text;
            string Med_nomCommercial = txtNomCommercial.Text;
            string Med_composition = txtComposition.Text;
            string Med_effets = txtEffets.Text;
            string Med_contrIndic = txtContreIndic.Text;
            string Med_prixechantillon = txtPrix.Text;
            string Fam_code = txtCodeFamille.Text;


            App.GestWeb.UpdateMedicamentAsync(Med_depotlegal, Med_nomCommercial, Fam_code, Med_composition, Med_effets, Med_contrIndic, Med_prixechantillon);

            DisplayAlert("Modification du médicament effectué", "Modification réalisée", "c'est fait");

        }

        private async void BtnAccueil_Clicked(object sender, EventArgs e)
        {
            MainPage page = new MainPage();
            await Navigation.PushModalAsync(page);
        }
    }
}