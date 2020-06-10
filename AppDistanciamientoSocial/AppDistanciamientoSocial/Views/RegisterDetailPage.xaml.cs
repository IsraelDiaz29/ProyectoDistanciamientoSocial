using AppDistanciamientoSocial.Model;
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
    public partial class RegisterDetailPage : ContentPage
    {
        public RegisterDetailPageViewModel ViewModel { get; set; }
        public RegisterDetailPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel = new RegisterDetailPageViewModel();
            this.BindingContext = ViewModel;
            await ViewModel.LoadEmployees();
            ;
        }
    }
}