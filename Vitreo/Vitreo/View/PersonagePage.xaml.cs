using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vitreo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PersonagePage : ContentPage
	{
		public PersonagePage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Model.Result>(this, "ResultDetail",
                (sender) =>
                {
                    Model.Global.Result = sender;
                    Navigation.PushAsync(new PersonaDatailPage());
                }
            );
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Model.Result>(this, "ResultDetail");
        }
    }
}