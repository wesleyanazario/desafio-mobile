using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//Classe da View SplashScreenPage , usada apenas para animação da View
namespace Vitreo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SplashScreenPage : ContentPage
	{
		public SplashScreenPage ()
		{
			InitializeComponent ();
		}
        //Metodo para produção do efeito no Logo na View SplashScreenPage
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await imageLogo.TranslateTo(0, 150, 2000, Easing.BounceOut);
            await imageLogo.TranslateTo(0, -150, 2000, Easing.BounceIn);
            await imageLogo.TranslateTo(0, 0, 2000, Easing.BounceOut);
            //await imageLogo.RotateTo(360, 2000, Easing.SinInOut);
            await imageLogo.ScaleTo(1.2, 2000, Easing.CubicIn);
            MessagingCenter.Send<SplashScreenPage>(this, "Splash");

        }

    }
}