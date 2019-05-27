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
            txtCode_Type.Text = lIndividuSelectionner.Code_Type.ToString();
            txtLibelle_Type.Text = lIndividuSelectionner.Libelle_Type;
        }
	}
}