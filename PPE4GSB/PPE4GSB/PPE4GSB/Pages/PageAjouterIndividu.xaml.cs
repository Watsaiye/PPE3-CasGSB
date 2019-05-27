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
	public partial class PageAjouterIndividu : ContentPage
	{
		public PageAjouterIndividu()
		{
			InitializeComponent();
		}

        private void BtnAjouterIndividu_Clicked(object sender, EventArgs e)
        {
            if(txtLibelletype.Text == null)
            {

            }
        }
    }
}