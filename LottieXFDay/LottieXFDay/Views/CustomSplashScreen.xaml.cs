using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieXFDay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomSplashScreen : ContentPage
    {
        public CustomSplashScreen()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(4000);
            App.Current.MainPage = new NavigationPage(new MainPage());
        }

    }
}