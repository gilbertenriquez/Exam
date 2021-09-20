using System;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exam
{
    public partial class App : Application
    {
        public static MobileServiceClient MobileService = new MobileServiceClient(mobileAppUri: "http://greenmarketwebapp.azurewebsites.net");
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
