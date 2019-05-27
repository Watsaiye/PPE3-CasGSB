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
	public partial class PageModifierIndividu : ContentPage
	{
		public PageModifierIndividu (Individu_type lIndividuSelectionner)
		{
			InitializeComponent ();
            AfficherInfoIndividu(lIndividuSelectionner);
		}

        public void AfficherInfoIndividu(Individu_type lIndividuSelectionner)
        {
            txtCode_Type.Text = lIndividuSelectionner.Code_Type;
            txtLibelle_Type.Text = lIndividuSelectionner.Libelle_Type;
        }

        public void BtnModifierIndividu_Clicked(object sender, EventArgs e)
        {
            string Code_Type = txtCode_Type.Text;
            string Libelle_Type = txtLibelle_Type.Text;

            App.GestWeb.UpdateIndividuAsync(Code_Type, Libelle_Type);

            DisplayAlert("Modification du type d'individu effectué", "Modification réalisée", "c'est fait");
        }
	}
}