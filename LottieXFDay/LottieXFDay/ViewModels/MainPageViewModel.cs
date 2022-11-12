using LottieXFDay.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace LottieXFDay.ViewModels 
{
    public class MainPageViewModel : BaseViewModel
    {
        
        public MainPageViewModel()
        {
            Title = "Main Page";

            AboutCommand = new Command(() =>
            {
                Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new AboutPage());
            });
            UrlCommand = new Command(() =>
            {
                Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new UrlPage());
            });
            ResourceCommand = new Command(() =>
            {
                Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new ResourcePage());
            });
        }   
    

    private ICommand _aboutCommand;
    public ICommand AboutCommand
    {
        get => _aboutCommand;
        set => Set(ref _aboutCommand, value);
    }

    private ICommand _urlCommand;
    public ICommand UrlCommand
    {
        get => _urlCommand;
        set => Set(ref _urlCommand, value);
    }

    private ICommand _resourceCommand;
    public ICommand ResourceCommand
    {
        get => _resourceCommand;
        set => Set(ref _resourceCommand, value);
    }
    }
}
