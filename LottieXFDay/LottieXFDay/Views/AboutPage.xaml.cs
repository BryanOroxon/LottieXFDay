using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LottieXFDay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            Title = "About Page";

            LabelName.Text = "Name: " + $"{AppInfo.Name}";

            LabelVersion.Text = "Version " + $"{AppInfo.VersionString} " +
                $"{AppInfo.BuildString}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}