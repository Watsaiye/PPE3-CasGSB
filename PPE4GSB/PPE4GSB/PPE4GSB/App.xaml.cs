using PPE4GSB.Classes;
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
        public static GestWebServices GestWeb { get; set; }


        public App()
        {
            InitializeComponent();

            GestWeb = new GestWebServices();
            LocalHost = "http://arthur.sio19ingetis.lan/PPE4_GSB/WSGSB/";
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
