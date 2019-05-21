
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PPE4GSB
{
    public partial class App : Application
    {
        public static string LocalHost { get; set; }
        public static List<Medicaments> LesMedicaments { get; set; }
        public static List<Individu_type> LesTypesIndividus { get; set; }
        public static GestPrescription UnePrescription { get; set; }


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
