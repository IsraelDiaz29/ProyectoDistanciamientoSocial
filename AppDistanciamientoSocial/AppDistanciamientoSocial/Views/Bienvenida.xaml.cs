using Android.Content.Res;
using AppDistanciamientoSocial.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDistanciamientoSocial.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bienvenida : ContentPage
    {
        public BienvenidaViewModel ViewModel { get; set; }
        public Bienvenida()
        {
            InitializeComponent();
            ViewModel = new BienvenidaViewModel(Navigation);
            this.BindingContext = ViewModel;
        }

    

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // new NavigationPage(new SeleccionarCuenta());
            //await Navigation.PushAsync(new SeleccionarCuenta());       
            await Navigation.PushAsync(new SeleccionarCuenta());
        }
    }
}