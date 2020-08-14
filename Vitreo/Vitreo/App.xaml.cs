using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Vitreo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.SplashScreenPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MessagingCenter.Subscribe<View.SplashScreenPage>(this, "Splash",
                   (sender) =>
                   {
                       MainPage = new NavigationPage(new View.PersonagePage());
                   });
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
