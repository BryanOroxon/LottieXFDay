using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieXFDay
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.CustomSplashScreen();
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
