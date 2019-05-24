using PPE4GSB.Classes
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
	public partial class PageAjouterMedicament : ContentPage
	{
		public PageAjouterMedicament ()
		{
			InitializeComponent ();
		}

        private void BtnAjouterLeComposant_Clicked(object sender, EventArgs e)
        {
            if (txtDepotLegal.Text == null || txtNomCommercial.Text == null || txtComposition.Text == null || txtEffets.Text == null || txtContreIndic.Text == null || txtPrix.Text == null || txtCodeFamille.Text == null)
            {
                DisplayAlert("Saisir toutes les informations", "Veuillez saisir toutes les informations nécéssaire", "Valider");
            }
            else
            {
                App.GestWeb.InsertMedicamentAsync(txtDepotLegal.Text, txtNomCommercial.Text, txtComposition.Text, txtEffets.Text, txtContreIndic.Text, txtPrix.Text, txtCodeFamille.Text);
                DisplayAlert("L'insertion s'est bien passé", "Le composant à été ajouté", "Ok");
            }
        }
    }
}