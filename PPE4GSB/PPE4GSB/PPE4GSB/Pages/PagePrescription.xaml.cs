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
	public partial class PagePrescription : ContentPage
	{
		public PagePrescription ()
		{
			InitializeComponent ();
		}

        private async void btnAccueil_Clicked(object sender, EventArgs e)
        {
            Pages.PageAccueil page = new Pages.PageAccueil();
            await Navigation.PushModalAsync(page);
        }
    }
}